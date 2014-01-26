﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oxide {
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
    internal class LuaOxideSTL {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LuaOxideSTL() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Oxide.LuaOxideSTL", typeof(LuaOxideSTL).Assembly);
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
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- baseplugin.lua - All plugins inherit this one
        ///
        ///local BASE = {}
        ///local metaPlugin = {}
        ///metaPlugin.__index = BASE
        ///BasePlugin = BASE
        ///
        ///function BASE:BaseInit()
        ///	self.Commands = {}
        ///	self.ChatCommands = {}
        ///end
        ///function BASE:AddCommand( class, name, callback )
        ///	local data = {}
        ///	data.Class = class
        ///	data.Name = name
        ///	data.Callback = callback
        ///	self.Commands[ class .. &quot;.&quot; .. name ] = data
        ///end
        ///function BASE:AddChatCommand( cmd, callback )
        ///	self.ChatCommands[ cmd ] = [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string baseplugin {
            get {
                return ResourceManager.GetString("baseplugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- config.lua - Config library
        ///
        ///
        ///config = {}
        ///local configfiles = {}
        ///
        ///function config.Read( name )
        ///	local df = cs.getdatafile( &quot;cfg_&quot; .. name )
        ///	local txt = df:GetText()
        ///	if (txt ~= &quot;&quot;) then
        ///		local tbl = json.decode( txt )
        ///		if (tbl) then
        ///			configfiles[ name ] = tbl
        ///			return true, tbl
        ///		else
        ///			error( &quot;Corrupt config file &apos;&quot; .. name .. &quot;&apos;! Check that the json is valid.&quot; )
        ///			return false
        ///		end
        ///	end
        ///	local tbl = {}
        ///	configfiles[ name ] = tbl
        ///	return fal [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string config {
            get {
                return ResourceManager.GetString("config", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- csfunc.lua - c# &lt;-&gt; lua interop
        ///
        ///
        ///-- Cache globals for speed
        ///local table = table
        ///local oldcs = cs
        ///
        ///local unpack = table.unpack
        ///local rawget = rawget
        ///
        ///
        ///function print( ... )
        ///	local args = { ... }
        ///	local result = &quot;&quot;
        ///	for i=1, #args do
        ///		if (i &gt; 1) then result = result .. &quot; &quot; end
        ///		result = result .. tostring( args[i] )
        ///	end
        ///	oldcs.print( result )
        ///end
        ///
        ///function error( obj )
        ///	oldcs.error( tostring( obj ) )
        ///end
        ///
        ///function callunpacked( func, argtable )
        /// </summary>
        internal static string csfunc {
            get {
                return ResourceManager.GetString("csfunc", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     -- Module options:
        ///    local always_try_using_lpeg = false
        ///    local register_global_module_table = true
        ///    local global_module_name = &apos;json&apos;
        ///
        ///    --[==[
        ///
        ///David Kolf&apos;s JSON module for Lua 5.1/5.2
        ///========================================
        ///
        ///*Version 2.4*
        ///
        ///In the default configuration this module writes no global values, not even
        ///the module table. Import it using
        ///
        ///    json = require (&quot;dkjson&quot;)
        ///
        ///In environments where `require` or a similiar function are not available
        ///and you cannot receive [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string json {
            get {
                return ResourceManager.GetString("json", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- plugins.lua - Plugins and api system
        ///
        ///plugins = {}
        ///
        ///function plugins.Find( name )
        ///	return cs.findplugin( name )
        ///end
        ///function plugins.Call( name, ... )
        ///	local args = { ... }
        ///	return cs.callplugins( name, args, #args )
        ///end
        ///function plugins.Reload( name )
        ///	cs.reloadplugin( name )
        ///end
        ///
        ///api = {}
        ///local apibindings = {}
        ///function api.Bind( plugin, apiname )
        ///	if (apibindings[ apiname ]) then
        ///		error( &quot;Conflict: more than 1 plugin tried to bind to the same API! ( [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string plugins {
            get {
                return ResourceManager.GetString("plugins", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- rust.lua - Provides an interface for standard rust functions
        ///
        ///local KindType = cs.gettype( &quot;Inventory+Slot+Kind, Assembly-CSharp&quot; )
        ///local KindFlagsType = cs.gettype( &quot;Inventory+Slot+KindFlags, Assembly-CSharp&quot; )
        ///
        ///typesystem.LoadEnum( KindType, &quot;InventorySlotKind&quot; )
        ///typesystem.LoadEnum( KindFlagsType, &quot;InventorySlotKindFlags&quot; )
        ///
        ///--local RustNoticePopup = static( Rust.Rust.Notice, &quot;Popup&quot; )
        ///--local PlayerClientAll = static_property_get( RustFirstPass.PlayerClient,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string rust {
            get {
                return ResourceManager.GetString("rust", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- timer.lua - timer library
        ///
        ///
        ///timer = {}
        ///
        ///function timer.Once( delay, func )
        ///	return cs.newtimer( delay, 1, func )
        ///end
        ///function timer.NextFrame( func )
        ///	return timer.Once( 0, func )
        ///end
        ///function timer.Repeat( delay, arg1, arg2 )
        ///	if (arg2) then
        ///		return cs.newtimer( delay, arg1, arg2 )
        ///	else
        ///		return cs.newtimer( delay, 0, arg1 )
        ///	end
        ///end
        ///function timer.Chain( ... )
        ///	local args = { ... }
        ///	local start = 0
        ///	local timers = {}
        ///	for i=1, #args do
        ///		local a [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string timer {
            get {
                return ResourceManager.GetString("timer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- type.lua - Type system
        ///
        ///local rawget = rawget
        ///local rawset = rawset
        ///
        ///typesystem = {}
        ///
        ///local metaType = {}
        ///function metaType.__index( t, k )
        ///	-- This is the index metamethod for a namespace&apos;d type
        ///	-- eg: RustFirstPass.NetUser[ k ]
        ///	-- We should look for static methods, properties and fields
        ///	
        ///	-- Check if we have a property by this name
        ///	local props = rawget( t, &quot;_properties&quot; )
        ///	local property = props[ k ]
        ///	if (property) then return property:GetValue( nil, [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string type {
            get {
                return ResourceManager.GetString("type", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- util.lua - Util library
        ///
        ///
        ///util = {}
        ///
        ///function util.ArrayToTable( arr )
        ///	local tbl = {}
        ///	for i=0, arr.Length do
        ///		tbl[ i + 1 ] = arr[ i ]
        ///	end
        ///	return tbl
        ///end
        ///function util.ArrayFromTable( typ, tbl, sz )
        ///	local arr = newarray( typ, sz or #tbl )
        ///	for i=1, #tbl do
        ///		arr[i - 1] = tbl[i]
        ///	end
        ///	return arr
        ///end
        ///
        ///function util.GetStaticMethod( typ, name )
        ///	typ = typesystem.TypeFromMetatype( typ )
        ///	tmp = nil
        ///	if (type( typ ) == &quot;table&quot;) then
        ///		error( &quot;Tried  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string util {
            get {
                return ResourceManager.GetString("util", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to -- Oxide - Lua Standard Library
        ///-- webrequest.lua - webrequest library
        ///
        ///
        ///webrequest = {}
        ///
        ///function webrequest.Send( url, callback )
        ///	return cs.sendwebrequest( url, callback )
        ///end.
        /// </summary>
        internal static string webrequest {
            get {
                return ResourceManager.GetString("webrequest", resourceCulture);
            }
        }
    }
}