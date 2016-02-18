﻿using System;

namespace TNRD.Editor.Json {
    [AttributeUsage( AttributeTargets.Field | AttributeTargets.Property, Inherited = false, AllowMultiple = false )]
    sealed class JsonIgnoreAttribute : Attribute {

        public JsonIgnoreAttribute() { }
    }
}