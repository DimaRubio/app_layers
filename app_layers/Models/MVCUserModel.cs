using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace app_layers.Models
{
	//MVC...Model - это средство для передачи инфы с фронта в бекенд
	public class MVCUserModel
	{
		[HiddenInput(DisplayValue = false)]
		public int ID { get; set; } //must be Hidden - не отображать в UI. При создании нового юзера ID не известен

		[Required (ErrorMessage ="mandantory field")]
		public string Name { get; set; }

		public string LastANme { get; set; }

		public string Adress { get; set; }

		[Required(ErrorMessage = "mandantory field")]

		public string Email { get; set; }

		[Required(ErrorMessage = "mandantory field")]
		[Range(50, 120, ErrorMessage = "within 50 to 120")]
		public int Age { get; set; }
	}
}