﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessagingToolkit.SmartGateway.ManagementConsole.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MessagingToolkit.SmartGateway.ManagementConsole.Properties.Resources", typeof(Resources).Assembly);
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
        
        internal static System.Drawing.Bitmap exit {
            get {
                object obj = ResourceManager.GetObject("exit", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid application directory.
        /// </summary>
        internal static string InvalidApplicationDirectoryException {
            get {
                return ResourceManager.GetString("InvalidApplicationDirectoryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid port.
        /// </summary>
        internal static string InvalidPortException {
            get {
                return ResourceManager.GetString("InvalidPortException", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon MessageServer {
            get {
                object obj = ResourceManager.GetObject("MessageServer", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exit application?.
        /// </summary>
        internal static string MsgConfirmExitApplication {
            get {
                return ResourceManager.GetString("MsgConfirmExitApplication", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SmartGateway Management Console is already running. Please close it before opening up another instance..
        /// </summary>
        internal static string MsgInstanceRunning {
            get {
                return ResourceManager.GetString("MsgInstanceRunning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopped.
        /// </summary>
        internal static string PortalStatusStopped {
            get {
                return ResourceManager.GetString("PortalStatusStopped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Started.
        /// </summary>
        internal static string PortStatusStarted {
            get {
                return ResourceManager.GetString("PortStatusStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MessageToolkit SmartGateway Server is not started. Please start it in order for the application to work properly..
        /// </summary>
        internal static string ServerServiceNotStarted {
            get {
                return ResourceManager.GetString("ServerServiceNotStarted", resourceCulture);
            }
        }
        
        internal static System.Drawing.Icon WebServer {
            get {
                object obj = ResourceManager.GetObject("WebServer", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
