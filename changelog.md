# Cyotek.Data.Nbt Change Log

## 1.0.4.0
### Changes and new features
* Added tests for `Tag.ToValueString`
* `ICollectionTag` now explicitly inherits from `ITag` so you don't have to cast back to the former if you only have a reference to the latter.
* Added new `TagEventArgs` helper class

### Bug Fixes
* `TagIntArray.ToValueString` and `TagByteArray.ToValueString` now return appropriate values instead of the .NET type name for their respective arrays.

## 1.0.3.6
### Changes and new features
* `Tag.Value` is now virtual
* Added `AddRange` method to `TagDictionary`
* Added `AddRange` and `Add(bool)` methods to `TagCollection`
* Added tests for `TagDictionary`, `TagCollection` and `TagEnd`, and added some other tests for classes without full coverage [still more to go]
* Setting the value of the `TagEnd` class now has no effect, and retrieving the value always returns `null`
* Added new `NbtOptions.HeaderOnly` flag, allowing the name of a tag to be read without loading the full body

### Bug Fixes
* Calling `NbtDocument.GetDocumentName` no longer loads the entire NBT document to return a single string value
* `TagDictionary.Add(Guid)` and `TagCollection.Add(Guid)` now return `ITag` instead of `void`
* Removed `AddIfNotDefault` methods from `TagDictionary`
* `BinaryTagReader.Load` always passed in default options rather than whatever the caller had specified

## 1.0.3.5
### Bug Fixes
* Changed `TagEditor` attributes on tag classes to remove fixed version information

## 1.0.3.4
### Changes and new features
* Code refactoring according to Resharper suggestions

### Bug Fixes
* Fixed corrupt document tree and crash when loading XML document with self closing tags

## 1.0.3.3
### Changes and new features
* Added a number of `TagCollection.Add` overloads without the `name` parameter to make it somewhat easier to populate lists via code.
* Added a few more tests

### Bug Fixes
* Fixed problems trying to load invalid documents with the `NbtDocument` class and having them misidentified as "custom" documents.
* Fixed an infinite loop when loading an XML file containing a list tag with no children

## 1.0.3.2 and below
* Change history not available in this document