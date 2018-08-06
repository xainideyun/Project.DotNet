using System;
using System.ComponentModel.DataAnnotations;
using App1.Attribute;

namespace App1.Models
{
    public class LeaveForm
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "姓名不能为空...")]
        public string Name { get; set; }
        [Range(18, 50, ErrorMessage = "年龄必须在18到50之间...")]
        public int Age { get; set; }
        [TextValidator(20)]
        public string Reason { get; set; }
    }
    
}