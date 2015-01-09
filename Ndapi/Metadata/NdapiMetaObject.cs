﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Ndapi.Metadata
{
    public class NdapiMetaObject
    {
        private static Dictionary<Type, NdapiMetaObject> _cache = new Dictionary<Type, NdapiMetaObject>();

        private readonly Type _type;
        private readonly Lazy<IEnumerable<NdapiMetaProperty>> _properties;

        public string ClassName => _type.Name;
        public IEnumerable<NdapiMetaProperty> AllProperties => _properties.Value;
        public IEnumerable<NdapiMetaProperty> StringProperties => AllProperties.Where(p => p.PropertyType == typeof(string));
        public IEnumerable<NdapiMetaProperty> BooleanProperties => AllProperties.Where(p => p.PropertyType == typeof(bool));
        public IEnumerable<NdapiMetaProperty> IntegerProperties => AllProperties.Where(p => p.PropertyType == typeof(int) || p.PropertyType.IsEnum);
        public IEnumerable<NdapiMetaProperty> ObjectProperties => AllProperties.Where(p => p.PropertyType.BaseType == typeof(NdapiObject));
        public IEnumerable<NdapiMetaProperty> ChildObjectProperties => AllProperties.Where(p => p.PropertyType.IsGenericType && p.PropertyType.GetGenericTypeDefinition() == typeof(IEnumerable<>));

        private NdapiMetaObject(Type type)
        {
            _type = type;
            _properties = new Lazy<IEnumerable<NdapiMetaProperty>>(LoadProperties);
        }

        private IEnumerable<NdapiMetaProperty> LoadProperties()
        {
            var properties = from property in _type.GetProperties()
                             from info in property.GetCustomAttributes(typeof(PropertyAttribute), false).Cast<PropertyAttribute>()
                             select NdapiMetaProperty.GetOrCreate(info.PropertyId, property.Name, property.CanRead, property.CanWrite, property.PropertyType);
            return properties.ToList();
        }

        public static NdapiMetaObject GetOrCreate(Type type)
        {
            NdapiMetaObject metaObject;
            if (_cache.TryGetValue(type, out metaObject))
            {
                return metaObject;
            }

            metaObject = new NdapiMetaObject(type);
            _cache.Add(type, metaObject);
            return metaObject;
        }
    }
}
