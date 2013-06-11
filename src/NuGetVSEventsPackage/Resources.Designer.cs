﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGet.NuGetVSEventsPackage {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NuGet.NuGetVSEventsPackage.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Error occurred while restoring NuGet packages: {0}.
        /// </summary>
        internal static string ErrorOccurredRestoringPackages {
            get {
                return ResourceManager.GetString("ErrorOccurredRestoringPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error: NuGet package {0} needs to be restored but couldn&apos;t be because consent has not been granted..
        /// </summary>
        internal static string PackageNotRestoredBecauseOfNoConsent {
            get {
                return ResourceManager.GetString("PackageNotRestoredBecauseOfNoConsent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package {0} is restored..
        /// </summary>
        internal static string PackageRestored {
            get {
                return ResourceManager.GetString("PackageRestored", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package restore failed for project {0}: {1}.
        /// </summary>
        internal static string PackageRestoreFailedForProject {
            get {
                return ResourceManager.GetString("PackageRestoreFailedForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package restore failed for solution {0}: {1}.
        /// </summary>
        internal static string PackageRestoreFailedForSolution {
            get {
                return ResourceManager.GetString("PackageRestoreFailedForSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package restore finished..
        /// </summary>
        internal static string PackageRestoreFinished {
            get {
                return ResourceManager.GetString("PackageRestoreFinished", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package restored finished for project {0}.
        /// </summary>
        internal static string PackageRestoreFinishedForProject {
            get {
                return ResourceManager.GetString("PackageRestoreFinishedForProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet Package restored finished for solution {0}.
        /// </summary>
        internal static string PackageRestoreFinishedForSolution {
            get {
                return ResourceManager.GetString("PackageRestoreFinishedForSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to NuGet package restore started.
        /// </summary>
        internal static string PackageRestoreStarted {
            get {
                return ResourceManager.GetString("PackageRestoreStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet package {0}.
        /// </summary>
        internal static string RestoringPackage {
            get {
                return ResourceManager.GetString("RestoringPackage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet packages....
        /// </summary>
        internal static string RestoringPackages {
            get {
                return ResourceManager.GetString("RestoringPackages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet packages of project {0}.
        /// </summary>
        internal static string RestoringPackagesOfProject {
            get {
                return ResourceManager.GetString("RestoringPackagesOfProject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Restoring NuGet packages of solution {0}.
        /// </summary>
        internal static string RestoringPackagesOfSolution {
            get {
                return ResourceManager.GetString("RestoringPackagesOfSolution", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Skip NuGet package {0} since it is already installed..
        /// </summary>
        internal static string SkipInstalledPackage {
            get {
                return ResourceManager.GetString("SkipInstalledPackage", resourceCulture);
            }
        }
    }
}
