﻿/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace Xml2CSharp
{
    [XmlRoot(ElementName = "Answer")]
    public class Answer
    {
        [XmlAttribute(AttributeName = "isRight")]
        public string IsRight { get; set; }
        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Answers")]
    public class Answers
    {
        [XmlElement(ElementName = "Answer")]
        public List<Answer> Answer { get; set; }
        [XmlAttribute(AttributeName = "Count")]
        public string Count { get; set; }
    }

    [XmlRoot(ElementName = "Test")]
    public class Test
    {
        [XmlElement(ElementName = "Description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "Answers")]
        public Answers Answers { get; set; }
        [XmlAttribute(AttributeName = "Difficulty")]
        public string Difficulty { get; set; }
        public override string ToString()
        {
            return Description;
        }
    }

    [XmlRoot(ElementName = "Tests")]
    public class Tests
    {
        [XmlElement(ElementName = "Test")]
        public List<Test> Test { get; set; }
        [XmlAttribute(AttributeName = "Author")]
        public string Author { get; set; }
        [XmlAttribute(AttributeName = "Subject")]
        public string Subject { get; set; }
        [XmlAttribute(AttributeName = "Date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "PassTime")]
        public string PassTime { get; set; }
    }

}
