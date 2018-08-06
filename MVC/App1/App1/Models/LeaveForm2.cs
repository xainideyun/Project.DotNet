using System;
using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;
using App1.Attribute;

namespace App1.Models
{
    public class LeaveForm2 : IModelBinder
    {
        [Required(AllowEmptyStrings = true, ErrorMessage = "姓名不能为空...")]
        public string Name { get; set; }
        [Range(18, 50, ErrorMessage = "年龄必须在18到50之间...")]
        public int Age { get; set; }
        [TextValidator(20)]
        public string Reason { get; set; }

        public bool BindModel(ModelBindingExecutionContext modelBindingExecutionContext, ModelBindingContext bindingContext)
        {
            Name = modelBindingExecutionContext.HttpContext.Request["Name"];
            Age = Convert.ToInt32(modelBindingExecutionContext.HttpContext.Request["Age"]);
            Reason = modelBindingExecutionContext.HttpContext.Request["Reason"];
            return true;
        }
    }

}