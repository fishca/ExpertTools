﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExpertTools.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ExpertTools.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
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
        ///   Ищет локализованную строку, похожую на USE [DATABASE_NAME];
        ///BULK INSERT [TABLE_NAME]
        ///FROM &apos;[BULK_FILE_PATH]&apos;
        ///WITH (FIRSTROW = 2, CODEPAGE = &apos;1251&apos;, FIELDTERMINATOR = &apos;[FIELD_SEPARATOR]&apos;, ROWTERMINATOR = &apos;[ROW_SEPARATOR]&apos;).
        /// </summary>
        internal static string bulk_insert {
            get {
                return ResourceManager.GetString("bulk_insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на --База данных
        ///CREATE DATABASE [DATABASE_NAME];.
        /// </summary>
        internal static string create_database {
            get {
                return ResourceManager.GetString("create_database", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на USE [DATABASE_NAME];
        ///
        ///--Таблицы базы данных
        ///
        ///CREATE TABLE Tldbmssql
        ///(
        ///	id INT IDENTITY NOT NULL,
        ///	sql NVARCHAR(MAX) NOT NULL,
        ///	normalized_sql NVARCHAR(MAX) NOT NULL,
        ///	_user NVARCHAR(200) NOT NULL,
        ///	context_first_line NVARCHAR(MAX) NOT NULL,
        ///	context_last_line NVARCHAR(MAX) NOT NULL,
        ///	_hash NVARCHAR(32) NOT NULL,
        ///	CONSTRAINT PK_Tldbmssql PRIMARY KEY(id)
        ///);
        ///
        ///CREATE TABLE Sqlqueries
        ///(
        ///	id INT IDENTITY(1,1) NOT NULL,
        ///	sql NVARCHAR(MAX) NOT NULL,
        ///	normalized_sql NVARCHAR(MAX) NOT NULL,
        ///	dura [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string create_database_structure {
            get {
                return ResourceManager.GetString("create_database_structure", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CREATE EVENT SESSION [SESSION_NAME] ON SERVER
        ///ADD EVENT sqlserver.rpc_completed,
        ///ADD EVENT sqlserver.sql_batch_completed
        ///ADD TARGET package0.event_file(SET filename = N&apos;[EVENT_FILE_PATH]&apos;,max_file_size=(10240))
        ///WITH (MAX_DISPATCH_LATENCY=4 SECONDS).
        /// </summary>
        internal static string create_session_for_join {
            get {
                return ResourceManager.GetString("create_session_for_join", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CREATE EVENT SESSION [SESSION_NAME] ON SERVER
        ///ADD EVENT sqlserver.rpc_completed(
        ///	WHERE([sqlserver.database_name]=N&apos;[DATABASE_NAME_FILTER]&apos;)),
        ///ADD EVENT sqlserver.sql_batch_completed(
        ///	WHERE([sqlserver.database_name]=N&apos;[DATABASE_NAME_FILTER]&apos;))
        ///ADD TARGET package0.event_file(SET filename = N&apos;[EVENT_FILE_PATH]&apos;,max_file_size=(10240))
        ///WITH (MAX_DISPATCH_LATENCY=4 SECONDS).
        /// </summary>
        internal static string create_session_for_join_filter {
            get {
                return ResourceManager.GetString("create_session_for_join_filter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT * FROM sys.databases WHERE name = &apos;[DATABASE_NAME]&apos;;.
        /// </summary>
        internal static string database_exists {
            get {
                return ResourceManager.GetString("database_exists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на IF EXISTS(SELECT * FROM sys.server_event_sessions WHERE name = &apos;[SESSION_NAME]&apos;)
        ///	DROP EVENT session [SESSION_NAME] ON SERVER;.
        /// </summary>
        internal static string delete_session {
            get {
                return ResourceManager.GetString("delete_session", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на --Удаление базы данных
        ///DROP DATABASE IF EXISTS [DATABASE_NAME];.
        /// </summary>
        internal static string drop_database {
            get {
                return ResourceManager.GetString("drop_database", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT event_data FROM sys.fn_xe_file_target_read_file(&apos;[SESSION_FILES_PATH]&apos;, null, null, null).
        /// </summary>
        internal static string get_session_events {
            get {
                return ResourceManager.GetString("get_session_events", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на --Удаление базы данных
        ///ALTER DATABASE [DATABASE_NAME]
        ///SET OFFLINE WITH ROLLBACK IMMEDIATE.
        /// </summary>
        internal static string kill_connections {
            get {
                return ResourceManager.GetString("kill_connections", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ALTER EVENT SESSION [SESSION_NAME] ON SERVER
        ///STATE = start;.
        /// </summary>
        internal static string start_session {
            get {
                return ResourceManager.GetString("start_session", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на ALTER EVENT SESSION [SESSION_NAME] ON SERVER
        ///STATE = stop;.
        /// </summary>
        internal static string stop_session {
            get {
                return ResourceManager.GetString("stop_session", resourceCulture);
            }
        }
    }
}
