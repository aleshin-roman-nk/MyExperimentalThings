using MyBibleStudy.BL.DataSources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Project -> session
 * 
 * 
 * 
 * session : tag_begin; tag_end; tag_pause; tag_resume;
 *			session_info (txt, different files)
 * 
 * Project -> part
 * 
 * PlannedWork: link to Project.Part
 * 
 */


namespace MyBibleStudy.BL
{
	public class WeeksModel
	{
		public Week Week { get; set; } = null;

		public string[] Weeks
		{
			get
			{
				return WeekFile.Weeks;
			}
		}

	}
}
