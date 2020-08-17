using DialCommuna.FormResult;
using MyEngDictionary.BL.Entities;
using MyEngDictionary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEngDictionary.Forms
{
	public partial class PhrasePackManagerForm : Form, IPhrasePackManagerView
	{
		private PhrasePack CurrentPhraseGroup => lvGroups.SelectedItems[0].Tag as PhrasePack;

		public PhrasePackManagerForm()
		{
			InitializeComponent();
		}

		public event EventHandler<CRUDRequest<PhrasePack>> PhrasePackCRUDRequset;

		public ViewResult<PhrasePack> Go()
		{
			var dr = ShowDialog();

			var res = new ViewResult<PhrasePack>();

			res.Answer = ViewAnswer.Cancel;
			res.Data = null;

			if (DialogResult.OK == dr)
			{
				res.Answer = ViewAnswer.Ok;
				res.Data = CurrentPhraseGroup;
			}

			return res;
		}

		public void PutPhrasePackCollection(IEnumerable<PhrasePack> groups)
		{
			lvGroups.Items.Clear();

			foreach (var item in groups)
			{
				var i = lvGroups.Items.Add(item.Name);
				i.Tag = item;
			}

			if (lvGroups.Items.Count == 0) return;

			lvGroups.Items[0].Selected = true;
			lvGroups.Items[0].Focused = true;
		}

		private void lvGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lvGroups.SelectedItems.Count == 0) return;
			var i = lvGroups.SelectedItems[0].Tag as PhrasePack;

			put_phrasepack(i);
		}

		private void put_phrasepack(PhrasePack pack)
		{
			txtSelectedPhraseGroup.Text = pack.Name;

			lvPhrases.Items.Clear();

			foreach (var item in pack.Phrases)
			{
				lvPhrases.Items.Add(item.TextEng);
			}
		}

		private void btnCreatePhrasePack_Click(object sender, EventArgs e)
		{
			PhrasePackCRUDRequset?.Invoke(null, new CRUDRequest<PhrasePack> { CRUDCode = CRUDType.Create});
		}

		private void lvGroups_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				PhrasePackCRUDRequset?.Invoke(null, new CRUDRequest<PhrasePack> { CRUDCode = CRUDType.Delete, Data = CurrentPhraseGroup });
			}
		}

		private void lvGroups_DoubleClick(object sender, EventArgs e)
		{
			if (lvGroups.SelectedItems.Count == 0) return;
			DialogResult = DialogResult.OK;
		}
	}
}
