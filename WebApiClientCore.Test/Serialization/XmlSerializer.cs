﻿using System.Text;
using Xunit;

namespace WebApiClientCore.Test.Serialization
{
    public class XmlSerializer
    {
        [Fact]
        public void ReadWriteTest()
        {
            var obj1 = new FormatModel { Age = 18, Name = "老九" };
            var formatter = new WebApiClientCore.Serialization.XmlSerializer();
            var xml = formatter.Serialize(obj1,null );
            var obj2 = formatter.Deserialize(xml, typeof(FormatModel),null);
            Assert.True(obj1.Equals(obj2));
        }

    }
}
