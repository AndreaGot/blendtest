﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione Runtime:4.0.30319.17626
//
//     Le modifiche apportate a questo file possono causare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlendTest.Resources
{
    using System;


    /// <summary>
    ///   Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e così via.
    /// </summary>
    // Questa classe è stata generata automaticamente dalla classe StronglyTypedResourceBuilder
    // tramite uno strumento quale ResGen o Visual Studio.
    // Per aggiungere o rimuovere un membro, modificare il file .ResX, quindi eseguire di nuovo ResGen
    // con l'opzione /str oppure ricompilare il progetto VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class AppResources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResources()
        {
        }

        /// <summary>
        ///   Restituisce l'istanza di ResourceManager memorizzata nella cache da questa classe.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("BlendTest.Resources.AppResources", typeof(AppResources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Esegue l'override della proprietà CurrentUICulture del thread corrente per tutto
        ///   tutte le ricerche di risorse che utilizzano questa classe di risorse fortemente tipizzata.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Cerca una stringa localizzata simile a LeftToRight.
        /// </summary>
        public static string ResourceFlowDirection
        {
            get
            {
                return ResourceManager.GetString("ResourceFlowDirection", resourceCulture);
            }
        }

        /// <summary>
        ///   Cerca una stringa localizzata simile a us-EN.
        /// </summary>
        public static string ResourceLanguage
        {
            get
            {
                return ResourceManager.GetString("ResourceLanguage", resourceCulture);
            }
        }

        /// <summary>
        ///   Cerca una stringa localizzata simile a APPLICAZIONE.
        /// </summary>
        public static string ApplicationTitle
        {
            get
            {
                return ResourceManager.GetString("ApplicationTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Cerca una stringa localizzata simile a pulsante.
        /// </summary>
        public static string AppBarButtonText
        {
            get
            {
                return ResourceManager.GetString("AppBarButtonText", resourceCulture);
            }
        }

        /// <summary>
        ///   Cerca una stringa localizzata simile alla voce di menu.
        /// </summary>
        public static string AppBarMenuItemText
        {
            get
            {
                return ResourceManager.GetString("AppBarMenuItemText", resourceCulture);
            }
        }
    }
}
