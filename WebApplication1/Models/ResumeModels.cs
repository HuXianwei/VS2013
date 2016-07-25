using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace WebApplication2.Models
{
    /// <summary>
    /// 学生信息
    /// </summary>
    public class ResumeModels
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "ID")]
        public virtual string Uid { get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "用户名")]
        public virtual string Username { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "性别")]
        public virtual string Sex { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "年龄")]
        public virtual string Age { get; set; }
        /// <summary>
        /// 成绩
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "成绩")]
        public virtual string Score { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "班级")]
        public virtual string Classid { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        [Required(ErrorMessage = "*")]
        [Display(Name = "学号")]
        public virtual string Stuid { get; set; }
    }
}
