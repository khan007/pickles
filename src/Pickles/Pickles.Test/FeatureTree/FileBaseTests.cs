﻿using System;
using System.IO.Abstractions;
using NUnit.Framework;
using PicklesDoc.Pickles.FeatureTree;
using Should;
using FileBase = PicklesDoc.Pickles.FeatureTree.FileBase;

namespace PicklesDoc.Pickles.Test.FeatureTree
{
    [TestFixture]
    public class FileBaseTests : BaseFixture
    {
        private static readonly Folder parentFolder = Helpers.CreateSimpleFolder();

        private class TestableFileBase : FileBase
        {
            public TestableFileBase(string fileName, Folder folder, IFileSystem filesSystem)
                : base(fileName, folder, filesSystem)
            {
            }
        }

        [Test]
        public void Constructor_EmptyFileNameAndExtension_ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new TestableFileBase("    .ext", parentFolder, RealFileSystem));

            exception.ParamName.ShouldEqual("fileName");
        }

        [Test]
        public void Constructor_EmptyFileName_ThrowsArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new TestableFileBase(" ", parentFolder, RealFileSystem));

            exception.ParamName.ShouldEqual("fileName");
        }

        [Test]
        public void Constructor_EmptyFolder_ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new TestableFileBase("feature", null, RealFileSystem));

            exception.ParamName.ShouldEqual("folder");
        }

        [Test]
        public void Constructor_ExtensionOnly_ThrowsArgumentException()
        {
            var exception = Assert.Throws<ArgumentException>(() => new TestableFileBase(".ext", parentFolder, RealFileSystem));

            exception.ParamName.ShouldEqual("fileName");
        }

        [Test]
        public void Constructor_FileNameWithExtension_RemovesExtension()
        {
            var featureFile = new TestableFileBase("Feature.ext", parentFolder, RealFileSystem);

            featureFile.Name.ShouldEqual("Feature");
        }

        [Test]
        public void Constructor_NullFileName_ThrowsArgumentNullException()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => new TestableFileBase(null, parentFolder, RealFileSystem));

            exception.ParamName.ShouldEqual("fileName");
        }

        [Test]
        public void Constructor_ValidFileName_SetsNameProperty()
        {
            var featureFile = new TestableFileBase("Feature", parentFolder, RealFileSystem);

            featureFile.Name.ShouldEqual("Feature");
        }

        [Test]
        public void Constructor_WithFeature_SetsFolderProperty()
        {
            var featureFile = new TestableFileBase("filename.ext", parentFolder, RealFileSystem);

            featureFile.Folder.ShouldEqual(parentFolder);
        }

        [Test]
        public void FindCommonAncestor_ItsOwnParent_ReturnsParent()
        {
            var file = new TestableFileBase("filename.ext", parentFolder, RealFileSystem);

            ITreeItem commonAncestor = file.FindCommonAncestor(parentFolder);

            commonAncestor.ShouldEqual(parentFolder);
        }

        [Test]
        public void FindCommonAncestor_NullArgument_ThrowsArgumentNullException()
        {
            var file = new TestableFileBase("filename.ext", parentFolder, RealFileSystem);

            Assert.Throws<ArgumentNullException>(() => file.FindCommonAncestor(null));
        }
    }
}