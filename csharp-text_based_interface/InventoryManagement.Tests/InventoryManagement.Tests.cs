using InventoryLibrary;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
	public class Tests
	{
		public static int id;
		public List<string> ListUsers = new List<string>() { "tinky", "winky", "dipsy", "La-la", "Poe", "teletubbies", "tubbycustard" };
		public List<string> ListItems = new List<string>() { "limestonecube", "orb", "cursedmirror", "hellcrystal", "staff", "tormentvortex", "spoon" };
		public string randomName { get { return getRandomName(); } set { } }
		public string randomItem { get { return getRandomItem(); } set { } }

		public string getRandomName()
		{
			int index = new Random().Next(0, ListUsers.Count);
			string randomName = ListUsers[index];

			ListUsers.Remove(randomName);
			return randomName;
		}

		public string getRandomItem()
		{
			int index = new Random().Next(0, ListItems.Count);
			string randomItem = ListItems[index];

			ListItems.Remove(randomItem);
			return randomItem;
		}

		public string test_id(BaseClass instance)
		{
			id++;
			return $"{instance.GetType().Name}_" + id;
		}

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void All_Class_instance_BaseClass()
		{
			User user = new User(randomName);
			user.id = test_id(user);
			user.date_created = new DateTime();
			user.date_updated = new DateTime();
			Assert.IsInstanceOf<BaseClass>(user);
			Item item = new Item(randomItem);
			Assert.IsInstanceOf<BaseClass>(item);
			Inventory inv = new Inventory(user, item, 5);
			Assert.IsInstanceOf<BaseClass>(user);
		}

		[Test]
		public void test_quantity()
		{
			User user = new User(randomName);
			Item item = new Item(randomItem);
			Inventory inv = new Inventory(user, item, 5);
			Assert.AreEqual(5, inv.quantity);

			Inventory inv1 = new Inventory(user, item);
			Assert.AreEqual(1, inv1.quantity);

			Inventory inv2 = new Inventory(user, item, -6);
			Assert.AreEqual(0, inv2.quantity);
		}

		[Test]
		public void test_price()
		{
			Item item = new Item(randomItem);
			item.price = 6.15424f;
			Assert.AreEqual(6.15f, item.price);
			Item item1 = new Item(randomItem);
			item1.price = 0;
			Assert.AreEqual(0.00, item1.price);
			Item item2 = new Item(randomItem);
			item2.price = 6.1f;
			Assert.AreEqual(6.10f, item2.price);
		}
	}
}