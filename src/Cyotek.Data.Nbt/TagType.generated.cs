﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cyotek.Data.Nbt
{
  /// <summary>
  /// Values that represent tag types.
  /// </summary>
  public enum TagType
  {
    /// <summary>
    /// Not set
    /// </summary>
    None = -1,

    /// <summary>
    /// Used to mark the end of a list
    /// </summary>
    End = 0,

    /// <summary>
    /// A single signed byte
    /// </summary>
    Byte = 1,

    /// <summary>
    /// A signed 16bit short
    /// </summary>
    Short = 2,

    /// <summary>
    /// A signed 32bit integer
    /// </summary>
    Int = 3,

    /// <summary>
    /// A signed 64bit long
    /// </summary>
    Long = 4,

    /// <summary>
    /// A 32bit floating point value
    /// </summary>
    Float = 5,

    /// <summary>
    /// A 64bit floating point value
    /// </summary>
    Double = 6,

    /// <summary>
    /// An array of bytes of unspecified format
    /// </summary>
    ByteArray = 7,

    /// <summary>
    /// An array of bytes defining a string in UTF-8 format
    /// </summary>
    String = 8,

    /// <summary>
    /// A sequential list of unnamed tags of a specific type
    /// </summary>
    List = 9,

    /// <summary>
    /// A sequential list of named tags of variable types
    /// </summary>
    Compound = 10,

    /// <summary>
    /// An array of integers of unspecified format
    /// </summary>
    IntArray = 11

  }
}
