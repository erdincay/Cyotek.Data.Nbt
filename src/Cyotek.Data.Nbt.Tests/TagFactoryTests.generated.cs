﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NUnit.Framework;

namespace Cyotek.Data.Nbt.Tests
{
  partial class TagFactoryTests
  {
    [Test]
    public void Create_with_type_creates_end()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.End;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagEnd>(actual);
    }

        [Test]
    public void Create_with_type_creates_byte()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Byte;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagByte>(actual);
    }

    [Test]
    public void Create_with_type_sets_byte_name()
    {
      // arrange
      Tag actual;
      string expected;
      byte value;
      TagType type;

      type = TagType.Byte;

      expected = "Alpha_TagByte";
      value = default(byte);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_byte_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Byte;

      expected = (byte)(byte.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_byte_type()
    {
      // arrange
      Tag actual;
      byte expected;

      expected = (byte)(byte.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagByte>(actual);
    }

    [Test]
    public void Create_with_value_sets_byte_value()
    {
      // arrange
      Tag actual;
      byte expected;

      expected = (byte)(byte.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_byte_name()
    {
      // arrange
      Tag actual;
      string expected;
      byte value;

      expected = "Alpha_TagByte";
      value = (byte)(byte.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_short()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Short;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagShort>(actual);
    }

    [Test]
    public void Create_with_type_sets_short_name()
    {
      // arrange
      Tag actual;
      string expected;
      short value;
      TagType type;

      type = TagType.Short;

      expected = "Alpha_TagShort";
      value = default(short);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_short_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Short;

      expected = (short)(short.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_short_type()
    {
      // arrange
      Tag actual;
      short expected;

      expected = (short)(short.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagShort>(actual);
    }

    [Test]
    public void Create_with_value_sets_short_value()
    {
      // arrange
      Tag actual;
      short expected;

      expected = (short)(short.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_short_name()
    {
      // arrange
      Tag actual;
      string expected;
      short value;

      expected = "Alpha_TagShort";
      value = (short)(short.MaxValue >> 1);

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_int()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Int;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagInt>(actual);
    }

    [Test]
    public void Create_with_type_sets_int_name()
    {
      // arrange
      Tag actual;
      string expected;
      int value;
      TagType type;

      type = TagType.Int;

      expected = "Alpha_TagInt";
      value = default(int);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_int_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Int;

      expected = 1073741823;

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_int_type()
    {
      // arrange
      Tag actual;
      int expected;

      expected = 1073741823;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagInt>(actual);
    }

    [Test]
    public void Create_with_value_sets_int_value()
    {
      // arrange
      Tag actual;
      int expected;

      expected = 1073741823;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_int_name()
    {
      // arrange
      Tag actual;
      string expected;
      int value;

      expected = "Alpha_TagInt";
      value = 1073741823;

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_long()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Long;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagLong>(actual);
    }

    [Test]
    public void Create_with_type_sets_long_name()
    {
      // arrange
      Tag actual;
      string expected;
      long value;
      TagType type;

      type = TagType.Long;

      expected = "Alpha_TagLong";
      value = default(long);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_long_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Long;

      expected = 4611686018427387903;

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_long_type()
    {
      // arrange
      Tag actual;
      long expected;

      expected = 4611686018427387903;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagLong>(actual);
    }

    [Test]
    public void Create_with_value_sets_long_value()
    {
      // arrange
      Tag actual;
      long expected;

      expected = 4611686018427387903;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_long_name()
    {
      // arrange
      Tag actual;
      string expected;
      long value;

      expected = "Alpha_TagLong";
      value = 4611686018427387903;

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_float()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Float;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagFloat>(actual);
    }

    [Test]
    public void Create_with_type_sets_float_name()
    {
      // arrange
      Tag actual;
      string expected;
      float value;
      TagType type;

      type = TagType.Float;

      expected = "Alpha_TagFloat";
      value = default(float);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_float_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Float;

      expected = 1.701412E+38F;

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_float_type()
    {
      // arrange
      Tag actual;
      float expected;

      expected = 1.701412E+38F;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagFloat>(actual);
    }

    [Test]
    public void Create_with_value_sets_float_value()
    {
      // arrange
      Tag actual;
      float expected;

      expected = 1.701412E+38F;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_float_name()
    {
      // arrange
      Tag actual;
      string expected;
      float value;

      expected = "Alpha_TagFloat";
      value = 1.701412E+38F;

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_double()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Double;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagDouble>(actual);
    }

    [Test]
    public void Create_with_type_sets_double_name()
    {
      // arrange
      Tag actual;
      string expected;
      double value;
      TagType type;

      type = TagType.Double;

      expected = "Alpha_TagDouble";
      value = default(double);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_double_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Double;

      expected = 8.98846567431158E+307;

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_double_type()
    {
      // arrange
      Tag actual;
      double expected;

      expected = 8.98846567431158E+307;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagDouble>(actual);
    }

    [Test]
    public void Create_with_value_sets_double_value()
    {
      // arrange
      Tag actual;
      double expected;

      expected = 8.98846567431158E+307;

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_double_name()
    {
      // arrange
      Tag actual;
      string expected;
      double value;

      expected = "Alpha_TagDouble";
      value = 8.98846567431158E+307;

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_bytearray()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.ByteArray;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagByteArray>(actual);
    }

    [Test]
    public void Create_with_type_sets_bytearray_name()
    {
      // arrange
      Tag actual;
      string expected;
      byte[] value;
      TagType type;

      type = TagType.ByteArray;

      expected = "Alpha_TagByteArray";
      value = default(byte[]);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_bytearray_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.ByteArray;

      expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_bytearray_type()
    {
      // arrange
      Tag actual;
      byte[] expected;

      expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagByteArray>(actual);
    }

    [Test]
    public void Create_with_value_sets_bytearray_value()
    {
      // arrange
      Tag actual;
      byte[] expected;

      expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_bytearray_name()
    {
      // arrange
      Tag actual;
      string expected;
      byte[] value;

      expected = "Alpha_TagByteArray";
      value = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_string()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.String;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagString>(actual);
    }

    [Test]
    public void Create_with_type_sets_string_name()
    {
      // arrange
      Tag actual;
      string expected;
      string value;
      TagType type;

      type = TagType.String;

      expected = "Alpha_TagString";
      value = default(string);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_string_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.String;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_string_type()
    {
      // arrange
      Tag actual;
      string expected;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagString>(actual);
    }

    [Test]
    public void Create_with_value_sets_string_value()
    {
      // arrange
      Tag actual;
      string expected;

      expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_string_name()
    {
      // arrange
      Tag actual;
      string expected;
      string value;

      expected = "Alpha_TagString";
      value = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_list()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.List;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagList>(actual);
    }

    [Test]
    public void Create_with_type_sets_list_name()
    {
      // arrange
      Tag actual;
      string expected;
      TagCollection value;
      TagType type;

      type = TagType.List;

      expected = "Alpha_TagList";
      value = default(TagCollection);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_list_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.List;

      expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_list_type()
    {
      // arrange
      Tag actual;
      TagCollection expected;

      expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagList>(actual);
    }

    [Test]
    public void Create_with_value_sets_list_value()
    {
      // arrange
      Tag actual;
      TagCollection expected;

      expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_list_name()
    {
      // arrange
      Tag actual;
      string expected;
      TagCollection value;

      expected = "Alpha_TagList";
      value = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_compound()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.Compound;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagCompound>(actual);
    }

    [Test]
    public void Create_with_type_sets_compound_name()
    {
      // arrange
      Tag actual;
      string expected;
      TagDictionary value;
      TagType type;

      type = TagType.Compound;

      expected = "Alpha_TagCompound";
      value = default(TagDictionary);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_compound_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.Compound;

      expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_compound_type()
    {
      // arrange
      Tag actual;
      TagDictionary expected;

      expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagCompound>(actual);
    }

    [Test]
    public void Create_with_value_sets_compound_value()
    {
      // arrange
      Tag actual;
      TagDictionary expected;

      expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_compound_name()
    {
      // arrange
      Tag actual;
      string expected;
      TagDictionary value;

      expected = "Alpha_TagCompound";
      value = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_creates_intarray()
    {
      // arrange
      Tag actual;
      TagType type;

      type = TagType.IntArray;

      // act
      actual = TagFactory.CreateTag(type);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagIntArray>(actual);
    }

    [Test]
    public void Create_with_type_sets_intarray_name()
    {
      // arrange
      Tag actual;
      string expected;
      int[] value;
      TagType type;

      type = TagType.IntArray;

      expected = "Alpha_TagIntArray";
      value = default(int[]);

      // act
      actual = TagFactory.CreateTag(expected, type, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

    [Test]
    public void Create_with_type_sets_intarray_value()
    {
      // arrange
      Tag actual;
      TagType type;
      object expected;

      type = TagType.IntArray;

      expected = new[] { 2190, 2994, 3248, 4294394 };

      // act
      actual = TagFactory.CreateTag(type, expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_creates_intarray_type()
    {
      // arrange
      Tag actual;
      int[] expected;

      expected = new[] { 2190, 2994, 3248, 4294394 };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.IsNotNull(actual);
      Assert.IsInstanceOf<TagIntArray>(actual);
    }

    [Test]
    public void Create_with_value_sets_intarray_value()
    {
      // arrange
      Tag actual;
      int[] expected;

      expected = new[] { 2190, 2994, 3248, 4294394 };

      // act
      actual = TagFactory.CreateTag(expected);

      // assert
      Assert.AreEqual(expected, actual.GetValue());
    }

    [Test]
    public void Create_with_value_sets_intarray_name()
    {
      // arrange
      Tag actual;
      string expected;
      int[] value;

      expected = "Alpha_TagIntArray";
      value = new[] { 2190, 2994, 3248, 4294394 };

      // act
      actual = TagFactory.CreateTag(expected, value);

      // assert
      Assert.AreEqual(expected, actual.Name);
    }

  }
}
