﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTest.Model
{
    [Table("District")]
    public class ModelDistrict
    {
        [Key]
        public int Id { get; set; }
        public string DistrictName { get; set;}
        public int ProvinceID { get; set; }
        public ModelProvince Province { get; set; }
    }
}
