using Assignment_3_skeleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Assignment_3
{
    public class SerializationTests
    {
        private List<User> users;
        private readonly string testFileName = "test_users.bin";

        [SetUp]
        public void Setup()
        {
			users = new List<User>();
			users.Add(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
			users.Add(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
			users.Add(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
			users.Add(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
		}

        [TearDown]
        public void TearDown()
        {
            this.users.Clear();
        }

        //Tests the object was serialized.
        [Test]
        public void TestSerialization()
        {
            SerializationHelper.SerializeUsers(users, testFileName);
            Assert.IsTrue(File.Exists(testFileName));
        }

        [Test]
        public void TestDeSerialization()
        {
			Assert.IsNotNull(users, "The 'users' list is null.");
			SerializationHelper.SerializeUsers(users, testFileName);
            List<User> deserializedUsers = SerializationHelper.DeserializeUsers(testFileName);
            Assert.That(users.Count, Is.EqualTo(deserializedUsers.Count));
            for (int i = 0; i < users.Count; i++)
            {
                Assert.That(users[i].Id, Is.EqualTo(deserializedUsers[i].Id));
                Assert.That(users[i].Name, Is.EqualTo(deserializedUsers[i].Name));
				Assert.That(users[i].Email, Is.EqualTo(deserializedUsers[i].Email));
				Assert.That(users[i].Password, Is.EqualTo(deserializedUsers[i].Password));
			}
        }

    }
}
