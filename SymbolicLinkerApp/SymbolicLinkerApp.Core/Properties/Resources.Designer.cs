//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SymbolicLinkerApp.Core.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SymbolicLinkerApp.Core.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 절대 경로 방식.
        /// </summary>
        internal static string Absolute {
            get {
                return ResourceManager.GetString("Absolute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 심볼릭 링크 생성 방식.
        /// </summary>
        internal static string CreateSymbolicTypeTitle {
            get {
                return ResourceManager.GetString("CreateSymbolicTypeTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 중복.
        /// </summary>
        internal static string Duplicate {
            get {
                return ResourceManager.GetString("Duplicate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 에러.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 진행.
        /// </summary>
        internal static string Progress {
            get {
                return ResourceManager.GetString("Progress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 상대 경로 방식(기본 값).
        /// </summary>
        internal static string Relative {
            get {
                return ResourceManager.GetString("Relative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 대기.
        /// </summary>
        internal static string Wait {
            get {
                return ResourceManager.GetString("Wait", resourceCulture);
            }
        }
    }
}
