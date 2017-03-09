﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.Attributes;

namespace ExtApp.Model
{
    /// <summary>
    /// 组织机构表
    /// </summary>
    [Class(Table = "AppDept")]
    public class Dept
    {
        /// <summary>
        /// 机构ID
        /// </summary>
        [Id(0, Name = "ID"), Generator(Class = "identity")]
        public virtual int ID { get; set; }

        /// <summary>
        /// 父机构
        /// </summary>
        [ManyToOne(1, ClassType = typeof(Dept), Column = "PID")]
        public virtual Dept PDept { get; set; }

        /// <summary>
        /// 编码
        /// </summary>
        [Property(2)]
        public virtual string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [Property(3)]
        public virtual string Name { get; set; }

        /// <summary>
        /// 类型（Organization-机构，District-区域）
        /// </summary>
        [ManyToOne(4, ClassType = typeof(DicItem), Column = "TypeID")]
        public virtual DicItem Type { get; set; }

        /// <summary>
        /// 负责人
        /// </summary>
        [ManyToOne(5, ClassType = typeof(User), Column = "HeadID")]
        public virtual User Head { get; set; }

        /// <summary>
        /// 添加人
        /// </summary>
        [ManyToOne(6, ClassType = typeof(User), Column = "AddUserID")]
        public virtual User AddUser { get; set; }

        /// <summary>
        /// 添加时间
        /// </summary>
        [Property(7)]
        public virtual DateTime AddTime { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [Property(8)]
        public virtual int Sort { get; set; }

        /// <summary>
        /// 状态（0-正常，-1-删除）
        /// </summary>
        [Property(9)]
        public virtual int Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Property(10)]
        public virtual string Comment { get; set; }
    }
}