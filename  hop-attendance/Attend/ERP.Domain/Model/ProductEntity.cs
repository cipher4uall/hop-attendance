using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace ERP.Domain.Model
{
	public class ProductEntity
	{
		public string Id
		{
			get;
			set;
		}
        [Required(ErrorMessage = "*")]
		public string Name
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}
        [Required(ErrorMessage = "*")]
		public string Packsizeid
		{
			get;
			set;
		}
        [Required(ErrorMessage = "*")]
		public string Price
		{
			get;
			set;
		}
        [Required(ErrorMessage = "*")]
		public string Companyid
		{
			get;
			set;
		}
		public bool Status
		{
			get;
			set;
		}
		public string CreatedBy
		{
			get;
			set;
		}
		public string CreatedDate
		{
			get;
			set;
		}
		public string UpdatedBy
		{
			get;
			set;
		}
		public string UpdatedDate
		{
			get;
			set;
		}
	}
}

