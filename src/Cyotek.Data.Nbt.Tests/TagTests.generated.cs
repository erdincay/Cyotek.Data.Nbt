﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using NUnit.Framework;

namespace Cyotek.Data.Nbt.Tests
{
  partial class TagTests
  {
    [Test]
    public void SetValue_updates_byte_value()
    {
      // arrange
      Tag target;
      byte expected;
      byte actual;

      target = new TagByte();

      expected = 126;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagByte)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_byte_value()
    {
      // arrange
      Tag target;
      byte expected;
      object actual;

      expected = 126;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_short_value()
    {
      // arrange
      Tag target;
      short expected;
      short actual;

      target = new TagShort();

      expected = (short)4343;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagShort)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_short_value()
    {
      // arrange
      Tag target;
      short expected;
      object actual;

      expected = (short)4343;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_int_value()
    {
      // arrange
      Tag target;
      int expected;
      int actual;

      target = new TagInt();

      expected = 48943848;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagInt)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_int_value()
    {
      // arrange
      Tag target;
      int expected;
      object actual;

      expected = 48943848;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_long_value()
    {
      // arrange
      Tag target;
      long expected;
      long actual;

      target = new TagLong();

      expected = 49308638948329;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagLong)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_long_value()
    {
      // arrange
      Tag target;
      long expected;
      object actual;

      expected = 49308638948329;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_float_value()
    {
      // arrange
      Tag target;
      float expected;
      float actual;

      target = new TagFloat();

      expected = 12.4535F;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagFloat)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_float_value()
    {
      // arrange
      Tag target;
      float expected;
      object actual;

      expected = 12.4535F;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_double_value()
    {
      // arrange
      Tag target;
      double expected;
      double actual;

      target = new TagDouble();

      expected = 290.495494D;

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagDouble)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_double_value()
    {
      // arrange
      Tag target;
      double expected;
      object actual;

      expected = 290.495494D;

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_bytearray_value()
    {
      // arrange
      Tag target;
      byte[] expected;
      byte[] actual;

      target = new TagByteArray();

      expected = new byte[] {2,4,8};

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagByteArray)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_bytearray_value()
    {
      // arrange
      Tag target;
      byte[] expected;
      object actual;

      expected = new byte[] {2,4,8};

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_string_value()
    {
      // arrange
      Tag target;
      string expected;
      string actual;

      target = new TagString();

      expected = "Alpha";

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagString)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_string_value()
    {
      // arrange
      Tag target;
      string expected;
      object actual;

      expected = "Alpha";

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_list_value()
    {
      // arrange
      Tag target;
      TagCollection expected;
      TagCollection actual;

      target = new TagList();

      expected = new TagCollection();

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagList)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_list_value()
    {
      // arrange
      Tag target;
      TagCollection expected;
      object actual;

      expected = new TagCollection();

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_compound_value()
    {
      // arrange
      Tag target;
      TagDictionary expected;
      TagDictionary actual;

      target = new TagCompound();

      expected = new TagDictionary();

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagCompound)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_compound_value()
    {
      // arrange
      Tag target;
      TagDictionary expected;
      object actual;

      expected = new TagDictionary();

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void SetValue_updates_intarray_value()
    {
      // arrange
      Tag target;
      int[] expected;
      int[] actual;

      target = new TagIntArray();

      expected = new int[] {16,32,64};

      // act
      target.SetValue(expected);

      // assert
      actual = ((TagIntArray)target).Value;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    public void GetValue_retrieves_intarray_value()
    {
      // arrange
      Tag target;
      int[] expected;
      object actual;

      expected = new int[] {16,32,64};

      target = TagFactory.CreateTag(expected);

      // act
      actual = target.GetValue();

      // assert
      Assert.AreEqual(expected, actual);
    }

  }
}
