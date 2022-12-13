﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Constant;

public static class Constant
{
   public static class Model{
    public static class OrderConstants {

        public static string ABSENCE = "غياب بدون إذن";
        public static string PUNISHMENT_ABSENCE = "امر عقاب جزاء عن الغياب بدون إذن";
        public static string VACATION_WITHOT_SALLARY = "أجازة بدون مرتب";
        public static string PUNISHMENT_EXAMINATION_REWARD = "أمر عقاب خصم من مكافأة الامتحانات";

       public static string ABSENCE_DEDUCTION = "خصم غياب بدون إذن";
       public static string PUNISHMENT_ABSENCE_DEDUCTION = "خصم من المرتب امر عقاب";
       public static string VACATION_WITHOT_SALLARY_DEDUCTION = "أجازة بدون مرتب";
       public static string PUNISHMENT_EXAMINATION_REWARD_DEDUCTION = "أمر عقاب خصم من مكافأة الامتحانات";



        }

    public static class BudgetItems {
        public static string WAZIFI = "اجر وظيفى ";
        public static string MOKAMEL = "اجر مكمل";
        public static string TA3WIDI = "أجر تعويضى";
        public static string GAZAA = "جزاء";
        public static string ABSENCE = "غياب";
       public static string SUBSCRIPTIONS = "اشتراكات";

        } 
}

    public static class ResultMessages
    {

        public static class SuccessMessages {
           // public static string SAVED_SUCCESSFULLY = "تم الحفظ بنجاح";
        }
        public static class ErrorMessages
        {
            public static string FAIL_WHILE_SAVING_DATA = "خطأ اثناء الحفظ";
            public static string ENTITY_NOT_EXIST = "العنصر المطلوب غير موجود";

        }
        public class CommonMessages {
            private readonly int _messageCode;
            private readonly string? _message;

            public CommonMessages(int messageCode,string? message =null)
            {
                this._messageCode = messageCode;
                this._message = message;
            }
        }

    }
}