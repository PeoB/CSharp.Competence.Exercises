using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Linq;
using ExpressionTrees.Code;
using NUnit.Framework;

namespace ExpressionTrees.Tests
{
    public class NotifyingVMTests
    {
        private readonly NotifyingVM _vm=new NotifyingVM();
        private PropertyChangedEventArgs _ev;

        [TestFixtureSetUp]
        public void SetUp()
        {
            var subscriber = 
                Observable.FromEventPattern(_vm, "PropertyChanged").Select(p => p.EventArgs)
                .Cast<PropertyChangedEventArgs>()
                .Subscribe(args => _ev=args);
            _vm.Index=1;
        }

        [Test]
        public void It_should_have_the_name_set_to_index()
        {
            Assert.AreEqual("Index",_ev.PropertyName);
        }
    }
}