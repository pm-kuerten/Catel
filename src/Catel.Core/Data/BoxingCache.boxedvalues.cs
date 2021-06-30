﻿
//------------------------------------------------------------------------------ 
// <auto-generated> 
// This code was generated by a tool. 
// 
// Changes to this file may cause incorrect behavior and will be lost if 
// the code is regenerated. 
// </auto-generated> 
//------------------------------------------------------------------------------

namespace Catel.Data
{
	using System;

	public static partial class BoxingCache
	{
        /// <summary>
        /// Converts the specified Boolean value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue<TValue>(TValue value)
        {
            return BoxingCache<TValue>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Boolean value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Boolean value)
        {
            return BoxingCache<Boolean>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Char value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Char value)
        {
            return BoxingCache<Char>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified SByte value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(SByte value)
        {
            return BoxingCache<SByte>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Byte value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Byte value)
        {
            return BoxingCache<Byte>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Int16 value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Int16 value)
        {
            return BoxingCache<Int16>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified UInt16 value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(UInt16 value)
        {
            return BoxingCache<UInt16>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Int32 value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Int32 value)
        {
            return BoxingCache<Int32>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified UInt32 value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(UInt32 value)
        {
            return BoxingCache<UInt32>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Int64 value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Int64 value)
        {
            return BoxingCache<Int64>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified UInt64 value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(UInt64 value)
        {
            return BoxingCache<UInt64>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Single value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Single value)
        {
            return BoxingCache<Single>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Double value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Double value)
        {
            return BoxingCache<Double>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified Decimal value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(Decimal value)
        {
            return BoxingCache<Decimal>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified DateTime value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(DateTime value)
        {
            return BoxingCache<DateTime>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified String value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(String value)
        {
            return BoxingCache<String>.Default.GetBoxedValue(value);
        }

        /// <summary>
        /// Converts the specified value into a cached boxed value in case of value type to decrease memory pressure after serialization.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>An object representing the value.</returns>
        public static object GetBoxedValue(object value)
        {
            object objectValue = value;

            if (value is not null)
            {
                var valueType = value.GetType();
                if (valueType.IsValueType)
                {
					if (false)
					{
						// Dummy code node
					}
                    else if (valueType == typeof(Boolean))
                    {
                        objectValue = BoxingCache<Boolean>.Default.GetBoxedValue((Boolean)value);
                    }
                    else if (valueType == typeof(Char))
                    {
                        objectValue = BoxingCache<Char>.Default.GetBoxedValue((Char)value);
                    }
                    else if (valueType == typeof(SByte))
                    {
                        objectValue = BoxingCache<SByte>.Default.GetBoxedValue((SByte)value);
                    }
                    else if (valueType == typeof(Byte))
                    {
                        objectValue = BoxingCache<Byte>.Default.GetBoxedValue((Byte)value);
                    }
                    else if (valueType == typeof(Int16))
                    {
                        objectValue = BoxingCache<Int16>.Default.GetBoxedValue((Int16)value);
                    }
                    else if (valueType == typeof(UInt16))
                    {
                        objectValue = BoxingCache<UInt16>.Default.GetBoxedValue((UInt16)value);
                    }
                    else if (valueType == typeof(Int32))
                    {
                        objectValue = BoxingCache<Int32>.Default.GetBoxedValue((Int32)value);
                    }
                    else if (valueType == typeof(UInt32))
                    {
                        objectValue = BoxingCache<UInt32>.Default.GetBoxedValue((UInt32)value);
                    }
                    else if (valueType == typeof(Int64))
                    {
                        objectValue = BoxingCache<Int64>.Default.GetBoxedValue((Int64)value);
                    }
                    else if (valueType == typeof(UInt64))
                    {
                        objectValue = BoxingCache<UInt64>.Default.GetBoxedValue((UInt64)value);
                    }
                    else if (valueType == typeof(Single))
                    {
                        objectValue = BoxingCache<Single>.Default.GetBoxedValue((Single)value);
                    }
                    else if (valueType == typeof(Double))
                    {
                        objectValue = BoxingCache<Double>.Default.GetBoxedValue((Double)value);
                    }
                    else if (valueType == typeof(Decimal))
                    {
                        objectValue = BoxingCache<Decimal>.Default.GetBoxedValue((Decimal)value);
                    }
                    else if (valueType == typeof(DateTime))
                    {
                        objectValue = BoxingCache<DateTime>.Default.GetBoxedValue((DateTime)value);
                    }
                    else if (valueType == typeof(String))
                    {
                        objectValue = BoxingCache<String>.Default.GetBoxedValue((String)value);
                    }
                }
            }

            return objectValue;
        }
	}
}