using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using Xamarin.Forms;

namespace Util
{
    /// <summary>
    /// デバッグログ出力クラス
    /// </summary>
    public static class Trace
    {
        /// <summary>
        /// ファイル名＋行番号＋メソッド名をログ出力
        /// </summary>
        public static void WriteLine(string message,
                                     [CallerFilePath] string file = "",
                                     [CallerLineNumber] int line = 0,
                                     [CallerMemberName] string member = "")
        {
            var s = string.Format("{0}:{1} - {2}: {3}", file, line, member, message);
            Debug.WriteLine(s);
        }

        /// <summary>
        /// ファイル名＋メソッド名をログ出力
        /// </summary>
        public static void WriteMethod([CallerFilePath] string file = "",
                                       [CallerMemberName] string member = "")
        {
            // ファイルパスからファイル名のみ抜き出す
            var paths = file.Split('/');
            var fileName = paths[paths.Length - 1];

            var s = string.Format("{0} - {1}", fileName, member);
            Debug.WriteLine(s);
        }

        /// <summary>
        /// NavigationStackをログ出力
        /// </summary>
        public static void WriteNavigationStack(Page currentPage)
        {
            var s = "***** NavigationStack *****\n";

            foreach (var page in currentPage.Navigation.NavigationStack)
            {
                s += (page.ToString() + "\n");
            }

            Debug.WriteLine(s);
        }

        /// <summary>
        /// ModalStackをログ出力
        /// </summary>
        public static void WriteModalStack(Page currentPage)
        {
            var s = "***** ModalStack *****\n";

            foreach (var page in currentPage.Navigation.ModalStack)
            {
                s += (page.ToString() + "\n");
            }

            Debug.WriteLine(s);
        }
    }
}
