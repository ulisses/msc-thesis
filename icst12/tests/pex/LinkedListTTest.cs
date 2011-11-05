// <copyright file="LinkedListTTest.cs" company="Microsoft">Copyright © Microsoft 2011</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeacherApp.LinkedList_Simple;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework.Exceptions;

namespace LinkedList_Simple
{
    [TestClass]
    [PexClass(typeof(LinkedList<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class LinkedListTTest
    {
        [PexGenericArguments(typeof(int))]
        [PexMethod, PexAllowedException(typeof(AssertFailedException)), PexAllowedException(typeof(NullReferenceException))]
        public void Remove<T>([PexAssumeUnderTest]LinkedList<T> target, LinkedListElement<T> element)
        {
            // <pex>
            PexAssume.IsTrue(target.Find(element.Data) == null, "complex reason");
            PexAssume.IsNotNull((object)element, "element");
            // </pex>
            try
            {
                target.Remove(element);
            }
            catch (Exception)
            {
                if (element == null) Assert.IsTrue(true);
            }

            LinkedListElement<T> linkedListElement = target.Find(element.Data);
            Assert.IsTrue(linkedListElement == null);
        }
        [TestMethod]
        public void Remove353()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove45()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = s0;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove610()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove885()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Prev = s1;
            s0.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove398()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void RemoveThrowsException318()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, (LinkedListElement<int>)null);
        }
        [PexGenericArguments(typeof(int))]
        [PexMethod, PexAllowedException(typeof(Exception))]
        public LinkedListElement<T> Prev<T>([PexAssumeUnderTest]LinkedList<T> target, LinkedListElement<T> element)
        {
            LinkedListElement<T> result = target.Prev(element);

            Assert.IsTrue(result == element.Prev);

            return result;
            // TODO: add assertions to method LinkedListTTest.Prev(LinkedList`1<!!0>, LinkedListElement`1<!!0>)
        }
        [TestMethod]
        public void Prev155()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Prev<int>(linkedList, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void PrevThrowsException801()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Prev<int>(linkedList, (LinkedListElement<int>)null);
        }
        [PexGenericArguments(typeof(int))]
        [PexMethod, PexAllowedException(typeof(Exception))]
        public LinkedListElement<T> Next<T>([PexAssumeUnderTest]LinkedList<T> target, LinkedListElement<T> element)
        {
            LinkedListElement<T> result = target.Next(element);

            Assert.IsTrue(result == element.Next);
            return result;
            // TODO: add assertions to method LinkedListTTest.Next(LinkedList`1<!!0>, LinkedListElement`1<!!0>)
        }
        [TestMethod]
        public void Next155()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Next<int>(linkedList, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void NextThrowsException444()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Next<int>(linkedList, (LinkedListElement<int>)null);
        }
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public LinkedListElement<T> Find01<T>([PexAssumeUnderTest]LinkedList<T> target, T needle, LinkedListElement<T> start)
        {
            LinkedListElement<T> result = target.Find(needle, start);

            LinkedListElement<T> elem = start;
            bool assert = false;

            while (elem != null)
            {
                assert = assert || elem.Data.Equals(needle);
                elem = elem.Next;
            }
            if (assert && result != null || !assert && result == null)
                Assert.IsTrue(true);

            return result;
            // TODO: add assertions to method LinkedListTTest.Find01(LinkedList`1<!!0>, !!0, LinkedListElement`1<!!0>)
        }
        [TestMethod]
        public void Find01836()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 1, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find01953()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(1);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0149()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNull((object)(linkedListElement.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find01323()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement =
              this.Find01<int>(linkedList, 0, (LinkedListElement<int>)null);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public LinkedListElement<T> Find<T>([PexAssumeUnderTest]LinkedList<T> target, T needle)
        {
            LinkedListElement<T> result = target.Find(needle);
            return result;
            // TODO: add assertions to method LinkedListTTest.Find(LinkedList`1<!!0>, !!0)
        }
        [TestMethod]
        public void Find676()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 1);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNotNull((object)(linkedList.Head.Next));
            Assert.AreEqual<int>(0, linkedList.Head.Next.Data);
            Assert.IsNull((object)(linkedList.Head.Next.Prev));
            Assert.IsNull((object)(linkedList.Head.Next.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find331()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 1);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find726()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNull((object)(linkedListElement.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.IsTrue(
                         object.ReferenceEquals((object)(linkedList.Head), (object)linkedListElement)
                         );
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find647()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public LinkedList<T> Constructor<T>()
        {
            LinkedList<T> target = new LinkedList<T>();
            return target;
            // TODO: add assertions to method LinkedListTTest.Constructor()
        }
        [TestMethod]
        public void Constructor930()
        {
            LinkedList<int> linkedList;
            linkedList = this.Constructor<int>();
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [PexGenericArguments(typeof(int))]
        [PexMethod(MaxRunsWithoutNewTests = 200), PexAllowedException(typeof(TraceAssertionException)), PexAllowedException(typeof(NullReferenceException))]
        public void Add<T>([PexAssumeUnderTest]LinkedList<T> target, T element)
        {
            // <pex>
            PexAssume.IsNotNull((object)(target.Find(element)), "target.Find(element)");
            // </pex>
            target.Add(element);

            var e = target.Find(element);

            Assert.IsTrue(e != null);

            // TODO: add assertions to method LinkedListTTest.Add(LinkedList`1<!!0>, !!0)
        }
        [TestMethod]
        public void Add261()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s1;
            this.Add<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.AreEqual<int>(0, linkedList.Tail.Data);
            Assert.IsNotNull((object)(linkedList.Tail.Prev));
            Assert.AreEqual<int>(0, linkedList.Tail.Prev.Data);
            Assert.IsNull((object)(linkedList.Tail.Prev.Prev));
            Assert.IsNotNull((object)(linkedList.Tail.Prev.Next));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Tail.Prev.Next), (object)(linkedList.Tail)));
            Assert.IsNull((object)(linkedList.Tail.Next));
        }
        [TestMethod]
        public void Add149()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = s0;
            this.Add<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.IsTrue(
                         object.ReferenceEquals((object)(linkedList.Tail), (object)(linkedList.Head))
                         );
        }
        [TestMethod]
        public void AddThrowsTraceAssertionException847()
        {
            using (PexTraceListenerContext.Create())
            {
                LinkedList<int> linkedList;
                linkedList = new LinkedList<int>();
                linkedList.Head = (LinkedListElement<int>)null;
                linkedList.Tail = (LinkedListElement<int>)null;
                this.Add<int>(linkedList, 0);
            }
        }
        [TestMethod]
        public void Find67601()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 1);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNotNull((object)(linkedList.Head.Next));
            Assert.AreEqual<int>(0, linkedList.Head.Next.Data);
            Assert.IsNull((object)(linkedList.Head.Next.Prev));
            Assert.IsNull((object)(linkedList.Head.Next.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find33101()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 1);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find72601()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNull((object)(linkedListElement.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.IsTrue(
                         object.ReferenceEquals((object)(linkedList.Head), (object)linkedListElement)
                         );
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find64701()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Find<int>(linkedList, 0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0183601()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 1, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0122()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s2 = new LinkedListElement<int>(0);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            s1.Next = s2;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNotNull((object)(linkedListElement.Next));
            Assert.AreEqual<int>(0, linkedListElement.Next.Data);
            Assert.IsNull((object)(linkedListElement.Next.Prev));
            Assert.IsNotNull((object)(linkedListElement.Next.Next));
            Assert.AreEqual<int>(0, linkedListElement.Next.Next.Data);
            Assert.IsNull((object)(linkedListElement.Next.Next.Prev));
            Assert.IsNull((object)(linkedListElement.Next.Next.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0195301()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(1);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0110()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNotNull((object)(linkedListElement.Next));
            Assert.AreEqual<int>(0, linkedListElement.Next.Data);
            Assert.IsNull((object)(linkedListElement.Next.Prev));
            Assert.IsNull((object)(linkedListElement.Next.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find014901()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNull((object)(linkedListElement.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0132301()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement =
              this.Find01<int>(linkedList, 0, (LinkedListElement<int>)null);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove504()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(1);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = s0;
            LinkedListElement<int> s2 = new LinkedListElement<int>(1);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            s1.Next = s2;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s1;
            this.Remove<int>(linkedList, s1);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(1, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNotNull((object)(linkedList.Head.Next));
            Assert.AreEqual<int>(1, linkedList.Head.Next.Data);
            Assert.IsNotNull((object)(linkedList.Head.Next.Prev));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Head.Next.Prev), (object)(linkedList.Head)));
            Assert.IsNull((object)(linkedList.Head.Next.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.IsTrue(
                         object.ReferenceEquals((object)(linkedList.Tail), (object)(linkedList.Head))
                         );
        }
        [TestMethod]
        public void RemoveThrowsAssertFailedException674()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(1);
            s1.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s2 = new LinkedListElement<int>(0);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            s1.Next = s2;
            s0.Next = s1;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s0;
            this.Remove<int>(linkedList, s0);
        }
        [TestMethod]
        public void Remove4501()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = s0;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove678()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(1);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s1);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove35301()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove88501()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Prev = s1;
            s0.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void RemoveThrowsAssertFailedException569()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s1);
        }
        [TestMethod]
        public void Remove61001()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove39801()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void RemoveThrowsNullReferenceException346()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, (LinkedListElement<int>)null);
        }
        [TestMethod]
        public void Prev15501()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Prev<int>(linkedList, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void PrevThrowsException423()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Prev<int>(linkedList, (LinkedListElement<int>)null);
        }
        [TestMethod]
        public void Next15501()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Next<int>(linkedList, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void NextThrowsException772()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            linkedListElement = this.Next<int>(linkedList, (LinkedListElement<int>)null);
        }
        [TestMethod]
        public void AddThrowsAssertFailedException312()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            LinkedListElement<int> s2 = new LinkedListElement<int>(0);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s2;
            this.Add<int>(linkedList, 1);
        }
        [TestMethod]
        public void Add461()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s0;
            this.Add<int>(linkedList, 1);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNotNull((object)(linkedList.Head.Next));
            Assert.AreEqual<int>(1, linkedList.Head.Next.Data);
            Assert.IsNotNull((object)(linkedList.Head.Next.Prev));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Head.Next.Prev), (object)(linkedList.Head)));
            Assert.IsNull((object)(linkedList.Head.Next.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Tail), (object)(linkedList.Head.Next)));
        }
        [TestMethod]
        public void AddThrowsAssertFailedException51()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s1;
            this.Add<int>(linkedList, 1);
        }
        [TestMethod]
        public void Add26101()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = s1;
            this.Add<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.AreEqual<int>(0, linkedList.Tail.Data);
            Assert.IsNotNull((object)(linkedList.Tail.Prev));
            Assert.AreEqual<int>(0, linkedList.Tail.Prev.Data);
            Assert.IsNull((object)(linkedList.Tail.Prev.Prev));
            Assert.IsNotNull((object)(linkedList.Tail.Prev.Next));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Tail.Prev.Next), (object)(linkedList.Tail)));
            Assert.IsNull((object)(linkedList.Tail.Next));
        }
        [TestMethod]
        public void AddThrowsNullReferenceException464()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = new LinkedList<int>();
            linkedList.Head = s0;
            linkedList.Tail = (LinkedListElement<int>)null;
            this.Add<int>(linkedList, 0);
        }
        [TestMethod]
        public void Add401()
        {
            LinkedList<int> linkedList;
            linkedList = new LinkedList<int>();
            linkedList.Head = (LinkedListElement<int>)null;
            linkedList.Tail = (LinkedListElement<int>)null;
            this.Add<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.IsTrue(
                         object.ReferenceEquals((object)(linkedList.Tail), (object)(linkedList.Head))
                         );
        }
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void RemoveThrowsAssertFailedException565()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(1);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = s0;
            LinkedListElement<int> s2 = new LinkedListElement<int>(0);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            s1.Next = s2;
            linkedList = LinkedListFactory.Create(s0, s1);
            this.Remove<int>(linkedList, s1);
        }
        [TestMethod]
        public void Remove67801()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create(s0, (LinkedListElement<int>)null);
            LinkedListElement<int> s1 = new LinkedListElement<int>(1);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s1);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove4502()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create((LinkedListElement<int>)null, s0);
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove61002()
        {
            LinkedList<int> linkedList;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove88502()
        {
            LinkedList<int> linkedList;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Prev = s1;
            s0.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Remove39802()
        {
            LinkedList<int> linkedList;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            this.Remove<int>(linkedList, s0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveThrowsNullReferenceException529()
        {
            LinkedList<int> linkedList;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            this.Remove<int>(linkedList, (LinkedListElement<int>)null);
        }
        [TestMethod]
        public void Prev15502()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Prev<int>(linkedList, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void PrevThrowsException765()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            linkedListElement = this.Prev<int>(linkedList, (LinkedListElement<int>)null);
        }
        [TestMethod]
        public void Next15502()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Next<int>(linkedList, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NextThrowsException333()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            linkedListElement = this.Next<int>(linkedList, (LinkedListElement<int>)null);
        }
        [TestMethod]
        public void Find0183602()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 1, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find012201()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s2 = new LinkedListElement<int>(0);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            s1.Next = s2;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNotNull((object)(linkedListElement.Next));
            Assert.AreEqual<int>(0, linkedListElement.Next.Data);
            Assert.IsNull((object)(linkedListElement.Next.Prev));
            Assert.IsNotNull((object)(linkedListElement.Next.Next));
            Assert.AreEqual<int>(0, linkedListElement.Next.Next.Data);
            Assert.IsNull((object)(linkedListElement.Next.Next.Prev));
            Assert.IsNull((object)(linkedListElement.Next.Next.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0195302()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(1);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find011001()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNotNull((object)(linkedListElement.Next));
            Assert.AreEqual<int>(0, linkedListElement.Next.Data);
            Assert.IsNull((object)(linkedListElement.Next.Prev));
            Assert.IsNull((object)(linkedListElement.Next.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find014902()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedListElement = this.Find01<int>(linkedList, 0, s0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNull((object)(linkedListElement.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find0132302()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            linkedListElement =
              this.Find01<int>(linkedList, 0, (LinkedListElement<int>)null);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find67602()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedList = LinkedListFactory.Create(s0, (LinkedListElement<int>)null);
            linkedListElement = this.Find<int>(linkedList, 1);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNotNull((object)(linkedList.Head.Next));
            Assert.AreEqual<int>(0, linkedList.Head.Next.Data);
            Assert.IsNull((object)(linkedList.Head.Next.Prev));
            Assert.IsNull((object)(linkedList.Head.Next.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find33102()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create(s0, (LinkedListElement<int>)null);
            linkedListElement = this.Find<int>(linkedList, 1);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find72602()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create(s0, (LinkedListElement<int>)null);
            linkedListElement = this.Find<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedListElement);
            Assert.AreEqual<int>(0, linkedListElement.Data);
            Assert.IsNull((object)(linkedListElement.Prev));
            Assert.IsNull((object)(linkedListElement.Next));
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.IsTrue(
                         object.ReferenceEquals((object)(linkedList.Head), (object)linkedListElement)
                         );
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Find64702()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> linkedListElement;
            linkedList = LinkedListFactory.Create
                             ((LinkedListElement<int>)null, (LinkedListElement<int>)null);
            linkedListElement = this.Find<int>(linkedList, 0);
            Assert.IsNull((object)linkedListElement);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNull((object)(linkedList.Head));
            Assert.IsNull((object)(linkedList.Tail));
        }
        [TestMethod]
        public void Add26103()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(1);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            LinkedListElement<int> s2 = new LinkedListElement<int>(0);
            s2.Prev = (LinkedListElement<int>)null;
            s2.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create(s0, s2);
            this.Add<int>(linkedList, 1);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNotNull((object)(linkedList.Head.Next));
            Assert.AreEqual<int>(1, linkedList.Head.Next.Data);
            Assert.IsNull((object)(linkedList.Head.Next.Prev));
            Assert.IsNull((object)(linkedList.Head.Next.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.AreEqual<int>(1, linkedList.Tail.Data);
            Assert.IsNotNull((object)(linkedList.Tail.Prev));
            Assert.AreEqual<int>(0, linkedList.Tail.Prev.Data);
            Assert.IsNull((object)(linkedList.Tail.Prev.Prev));
            Assert.IsNotNull((object)(linkedList.Tail.Prev.Next));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Tail.Prev.Next), (object)(linkedList.Tail)));
            Assert.IsNull((object)(linkedList.Tail.Next));
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddThrowsNullReferenceException880()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(1);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            s0.Next = s1;
            linkedList = LinkedListFactory.Create(s0, (LinkedListElement<int>)null);
            this.Add<int>(linkedList, 1);
        }
        [TestMethod]
        public void Add26102()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            LinkedListElement<int> s1 = new LinkedListElement<int>(0);
            s1.Prev = (LinkedListElement<int>)null;
            s1.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create(s0, s1);
            this.Add<int>(linkedList, 0);
            Assert.IsNotNull((object)linkedList);
            Assert.IsNotNull((object)(linkedList.Head));
            Assert.AreEqual<int>(0, linkedList.Head.Data);
            Assert.IsNull((object)(linkedList.Head.Prev));
            Assert.IsNull((object)(linkedList.Head.Next));
            Assert.IsNotNull((object)(linkedList.Tail));
            Assert.AreEqual<int>(0, linkedList.Tail.Data);
            Assert.IsNotNull((object)(linkedList.Tail.Prev));
            Assert.AreEqual<int>(0, linkedList.Tail.Prev.Data);
            Assert.IsNull((object)(linkedList.Tail.Prev.Prev));
            Assert.IsNotNull((object)(linkedList.Tail.Prev.Next));
            Assert.IsTrue(object.ReferenceEquals
                              ((object)(linkedList.Tail.Prev.Next), (object)(linkedList.Tail)));
            Assert.IsNull((object)(linkedList.Tail.Next));
        }
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddThrowsNullReferenceException794()
        {
            LinkedList<int> linkedList;
            LinkedListElement<int> s0 = new LinkedListElement<int>(0);
            s0.Prev = (LinkedListElement<int>)null;
            s0.Next = (LinkedListElement<int>)null;
            linkedList = LinkedListFactory.Create(s0, (LinkedListElement<int>)null);
            this.Add<int>(linkedList, 0);
        }
    }
}
