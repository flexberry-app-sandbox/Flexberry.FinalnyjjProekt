﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.FinalnyjjProekt
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Сотрудники.
    /// </summary>
    // *** Start programmer edit section *** (Сотрудники CustomAttributes)

    // *** End programmer edit section *** (Сотрудники CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("СотрудникиE", new string[] {
            "Id as \'Id\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "СерияПас as \'Серия паспорта\'",
            "НомерПас as \'Номер паспарта\'",
            "Отделы as \'Отделы\'",
            "Отделы.Наимнование as \'Отдел\'",
            "Организации as \'Организации\'",
            "Организации.Наименование as \'ОрганизациЯ\'",
            "Должности as \'Должности\'",
            "Должности.Наименование as \'Должность\'"}, Hidden=new string[] {
            "Отделы.Наимнование",
            "Организации.Наименование",
            "Должности.Наименование"})]
    [MasterViewDefineAttribute("СотрудникиE", "Отделы", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наимнование")]
    [MasterViewDefineAttribute("СотрудникиE", "Организации", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [MasterViewDefineAttribute("СотрудникиE", "Должности", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Наименование")]
    [View("СотрудникиL", new string[] {
            "Id as \'Id\'",
            "Фамилия as \'Фамилия\'",
            "Имя as \'Имя\'",
            "Отчество as \'Отчество\'",
            "СерияПас as \'Серия паспорта\'",
            "НомерПас as \'Номер паспорта\'",
            "Отделы.Наимнование as \'Отдел\'",
            "Организации.Наименование as \'Организация\'",
            "Должности.Наименование as \'Должность\'"})]
    public class Сотрудники : ICSSoft.STORMNET.DataObject
    {
        
        private int fId;
        
        private string fФамилия;
        
        private string fОтчество;
        
        private string fИмя;
        
        private string fСерияПас;
        
        private string fНомерПас;
        
        private IIS.FinalnyjjProekt.Отделы fОтделы;
        
        private IIS.FinalnyjjProekt.Организации fОрганизации;
        
        private IIS.FinalnyjjProekt.Должности fДолжности;
        
        // *** Start programmer edit section *** (Сотрудники CustomMembers)

        // *** End programmer edit section *** (Сотрудники CustomMembers)

        
        /// <summary>
        /// Id.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Id CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Id CustomAttributes)
        public virtual int Id
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Id Get start)

                // *** End programmer edit section *** (Сотрудники.Id Get start)
                int result = this.fId;
                // *** Start programmer edit section *** (Сотрудники.Id Get end)

                // *** End programmer edit section *** (Сотрудники.Id Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Id Set start)

                // *** End programmer edit section *** (Сотрудники.Id Set start)
                this.fId = value;
                // *** Start programmer edit section *** (Сотрудники.Id Set end)

                // *** End programmer edit section *** (Сотрудники.Id Set end)
            }
        }
        
        /// <summary>
        /// Имя.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Имя CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Имя CustomAttributes)
        [StrLen(255)]
        public virtual string Имя
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Имя Get start)

                // *** End programmer edit section *** (Сотрудники.Имя Get start)
                string result = this.fИмя;
                // *** Start programmer edit section *** (Сотрудники.Имя Get end)

                // *** End programmer edit section *** (Сотрудники.Имя Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Имя Set start)

                // *** End programmer edit section *** (Сотрудники.Имя Set start)
                this.fИмя = value;
                // *** Start programmer edit section *** (Сотрудники.Имя Set end)

                // *** End programmer edit section *** (Сотрудники.Имя Set end)
            }
        }
        
        /// <summary>
        /// НомерПас.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.НомерПас CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.НомерПас CustomAttributes)
        [StrLen(255)]
        public virtual string НомерПас
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.НомерПас Get start)

                // *** End programmer edit section *** (Сотрудники.НомерПас Get start)
                string result = this.fНомерПас;
                // *** Start programmer edit section *** (Сотрудники.НомерПас Get end)

                // *** End programmer edit section *** (Сотрудники.НомерПас Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.НомерПас Set start)

                // *** End programmer edit section *** (Сотрудники.НомерПас Set start)
                this.fНомерПас = value;
                // *** Start programmer edit section *** (Сотрудники.НомерПас Set end)

                // *** End programmer edit section *** (Сотрудники.НомерПас Set end)
            }
        }
        
        /// <summary>
        /// Отчество.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Отчество CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Отчество CustomAttributes)
        [StrLen(255)]
        public virtual string Отчество
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Отчество Get start)

                // *** End programmer edit section *** (Сотрудники.Отчество Get start)
                string result = this.fОтчество;
                // *** Start programmer edit section *** (Сотрудники.Отчество Get end)

                // *** End programmer edit section *** (Сотрудники.Отчество Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Отчество Set start)

                // *** End programmer edit section *** (Сотрудники.Отчество Set start)
                this.fОтчество = value;
                // *** Start programmer edit section *** (Сотрудники.Отчество Set end)

                // *** End programmer edit section *** (Сотрудники.Отчество Set end)
            }
        }
        
        /// <summary>
        /// СерияПас.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.СерияПас CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.СерияПас CustomAttributes)
        [StrLen(255)]
        public virtual string СерияПас
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.СерияПас Get start)

                // *** End programmer edit section *** (Сотрудники.СерияПас Get start)
                string result = this.fСерияПас;
                // *** Start programmer edit section *** (Сотрудники.СерияПас Get end)

                // *** End programmer edit section *** (Сотрудники.СерияПас Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.СерияПас Set start)

                // *** End programmer edit section *** (Сотрудники.СерияПас Set start)
                this.fСерияПас = value;
                // *** Start programmer edit section *** (Сотрудники.СерияПас Set end)

                // *** End programmer edit section *** (Сотрудники.СерияПас Set end)
            }
        }
        
        /// <summary>
        /// Фамилия.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Фамилия CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Фамилия CustomAttributes)
        [StrLen(255)]
        public virtual string Фамилия
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Фамилия Get start)

                // *** End programmer edit section *** (Сотрудники.Фамилия Get start)
                string result = this.fФамилия;
                // *** Start programmer edit section *** (Сотрудники.Фамилия Get end)

                // *** End programmer edit section *** (Сотрудники.Фамилия Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Фамилия Set start)

                // *** End programmer edit section *** (Сотрудники.Фамилия Set start)
                this.fФамилия = value;
                // *** Start programmer edit section *** (Сотрудники.Фамилия Set end)

                // *** End programmer edit section *** (Сотрудники.Фамилия Set end)
            }
        }
        
        /// <summary>
        /// Сотрудники.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Должности CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Должности CustomAttributes)
        [PropertyStorage(new string[] {
                "Должности"})]
        [NotNull()]
        public virtual IIS.FinalnyjjProekt.Должности Должности
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Должности Get start)

                // *** End programmer edit section *** (Сотрудники.Должности Get start)
                IIS.FinalnyjjProekt.Должности result = this.fДолжности;
                // *** Start programmer edit section *** (Сотрудники.Должности Get end)

                // *** End programmer edit section *** (Сотрудники.Должности Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Должности Set start)

                // *** End programmer edit section *** (Сотрудники.Должности Set start)
                this.fДолжности = value;
                // *** Start programmer edit section *** (Сотрудники.Должности Set end)

                // *** End programmer edit section *** (Сотрудники.Должности Set end)
            }
        }
        
        /// <summary>
        /// Сотрудники.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Организации CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Организации CustomAttributes)
        [PropertyStorage(new string[] {
                "Организации"})]
        [NotNull()]
        public virtual IIS.FinalnyjjProekt.Организации Организации
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Организации Get start)

                // *** End programmer edit section *** (Сотрудники.Организации Get start)
                IIS.FinalnyjjProekt.Организации result = this.fОрганизации;
                // *** Start programmer edit section *** (Сотрудники.Организации Get end)

                // *** End programmer edit section *** (Сотрудники.Организации Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Организации Set start)

                // *** End programmer edit section *** (Сотрудники.Организации Set start)
                this.fОрганизации = value;
                // *** Start programmer edit section *** (Сотрудники.Организации Set end)

                // *** End programmer edit section *** (Сотрудники.Организации Set end)
            }
        }
        
        /// <summary>
        /// Сотрудники.
        /// </summary>
        // *** Start programmer edit section *** (Сотрудники.Отделы CustomAttributes)

        // *** End programmer edit section *** (Сотрудники.Отделы CustomAttributes)
        [PropertyStorage(new string[] {
                "Отделы"})]
        [NotNull()]
        public virtual IIS.FinalnyjjProekt.Отделы Отделы
        {
            get
            {
                // *** Start programmer edit section *** (Сотрудники.Отделы Get start)

                // *** End programmer edit section *** (Сотрудники.Отделы Get start)
                IIS.FinalnyjjProekt.Отделы result = this.fОтделы;
                // *** Start programmer edit section *** (Сотрудники.Отделы Get end)

                // *** End programmer edit section *** (Сотрудники.Отделы Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Сотрудники.Отделы Set start)

                // *** End programmer edit section *** (Сотрудники.Отделы Set start)
                this.fОтделы = value;
                // *** Start programmer edit section *** (Сотрудники.Отделы Set end)

                // *** End programmer edit section *** (Сотрудники.Отделы Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "СотрудникиE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиE", typeof(IIS.FinalnyjjProekt.Сотрудники));
                }
            }
            
            /// <summary>
            /// "СотрудникиL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View СотрудникиL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("СотрудникиL", typeof(IIS.FinalnyjjProekt.Сотрудники));
                }
            }
        }
    }
}
