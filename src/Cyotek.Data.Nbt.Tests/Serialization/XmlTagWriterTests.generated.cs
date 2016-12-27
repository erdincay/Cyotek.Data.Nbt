﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



using System.IO;
using NUnit.Framework;
using Cyotek.Data.Nbt.Serialization;

namespace Cyotek.Data.Nbt.Tests.Serialization
{
  [TestFixture]
  public partial class XmlTagWriterTests : TestBase
  {
    [Test]
    public void Document_serialization_deserialization_test()
    {
      this.WriteDocumentTest(this.CreateWriter, this.CreateReader);
    }

    [Test]
    public void Serialization_deserialization_test()
    {
      this.WriteTest(this.CreateWriter, this.CreateReader);
    }


    [Test]
    public void WriteTag_writes_unnamed_byte_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        byte expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = 127;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_byte_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        byte expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltabyte";
        expectedValue = 127;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_short_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        short expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = 16383;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_short_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        short expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltashort";
        expectedValue = 16383;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_int_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        int expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = 1073741823;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_int_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        int expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltaint";
        expectedValue = 1073741823;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_long_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        long expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = 4611686018427387903;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_long_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        long expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltalong";
        expectedValue = 4611686018427387903;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_float_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        float expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = 1.701412E+38F;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_float_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        float expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltafloat";
        expectedValue = 1.701412E+38F;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_double_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        double expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = 8.98846567431158E+307;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_double_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        double expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltadouble";
        expectedValue = 8.98846567431158E+307;

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_bytearray_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        byte[] expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_bytearray_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        byte[] expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltabyte[]";
        expectedValue = new byte[] { 2, 4, 8, 16, 32, 64, 128 };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_string_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        string expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_string_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        string expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltastring";
        expectedValue = "HELLO WORLD THIS IS A TEST STRING ÅÄÖ!";

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_list_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        TagCollection expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_list_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        TagCollection expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltaTagCollection";
        expectedValue = new TagCollection(TagType.Int) { 2, 4, 8, 16, 32, 64, 128, 256 };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_compound_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        TagDictionary expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_compound_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        TagDictionary expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltaTagDictionary";
        expectedValue = new TagDictionary { new TagByte("A", 2), new TagShort("B", 4), new TagInt("C", 8) };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }


    [Test]
    public void WriteTag_writes_unnamed_intarray_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        int[] expected;
        Tag actual;

        target = this.CreateWriter(stream);

        expected = new[] { 2190, 2994, 3248, 4294394 };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expected);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expected, actual.GetValue());
      }
    }

    [Test]
    public void WriteTag_writes_named_intarray_tag()
    {
      using (MemoryStream stream = new MemoryStream())
      {
        // arrange
        TagWriter target;
        TagReader reader;
        int[] expectedValue;
        string expectedName;
        Tag actual;

        target = this.CreateWriter(stream);

        expectedName = "deltaint[]";
        expectedValue = new[] { 2190, 2994, 3248, 4294394 };

        target.WriteStartDocument();
        target.WriteStartTag(TagType.Compound);

        // act
        target.WriteTag(expectedName, expectedValue);

        // assert
        target.WriteEndTag();
        target.WriteEndDocument();
        stream.Position = 0;
        reader = this.CreateReader(stream);
        actual = ((TagCompound)reader.ReadTag())[0];
        Assert.AreEqual(expectedName, actual.Name);
        Assert.AreEqual(expectedValue, actual.GetValue());
      }
    }

  }
}

