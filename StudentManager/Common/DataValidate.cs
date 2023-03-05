using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentManager
{
    /// <summary>
    ///  通用验证类
    /// </summary>
   public class DataValidate
    {
        /// <summary>
        /// 验证正整数
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsInteger(string text)
        {
            Regex regex = new Regex(@"^[1-9]\d*$");
            return regex.IsMatch(text);
        }


        /// <summary>
        /// 验证是否是Email
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsEmail(string txt)
        {
            Regex objReg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            return objReg.IsMatch(txt);
        }
        /// <summary>
        /// 验证身份证
        /// </summary>
        /// <param name="txt"></param>
        /// <returns></returns>
        public static bool IsIdentityCard(string txt)
        {
            Regex objReg = new Regex(@"^(\d{15}$|^\d{18}$|^\d{17}(\d|X|x))$");
            return objReg.IsMatch(txt);
        }
    }
}
