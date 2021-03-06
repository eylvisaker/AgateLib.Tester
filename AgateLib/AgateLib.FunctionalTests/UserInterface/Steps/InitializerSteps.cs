﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgateLib.FunctionalTests.UserInterface.Support;
using ManualTests.AgateLib.UserInterface.FF6;
using TechTalk.SpecFlow;

namespace AgateLib.FunctionalTests.UserInterface.Steps
{
    [Binding]
    public class InitializerSteps
    {
        private readonly UserInterfaceInitializer initializer;

        public InitializerSteps(UserInterfaceInitializer initializer)
        {
            this.initializer = initializer;
        }

        [Given(@"I have the (.*) menu")]
        public void GivenIHaveATitleMenu(string menu)
        {
            initializer.Initialize(menu);

            initializer.WaitForAnimations();
        }

        [Given(@"a party of")]
        public void GivenIHaveCharactersInMyParty(Table table)
        {
            initializer.SetParty(table.Rows);

            initializer.WaitForAnimations();
        }

        [Given(@"an inventory of")]
        public void GivenIHaveAnInventory(Table table)
        {
            initializer.SetInventory(
                table.Rows.Select(row =>
                    RowToItem(row)));
        }

        private static Item RowToItem(TableRow row)
        {
            var result = new Item { Name = row["Name"], ItemType = row["ItemType"] };

            var effect = row["Effect"];
            if (!string.IsNullOrWhiteSpace(effect))
            {
                var effectArgs = effect.Split(' ');

                result.Effect = effectArgs[0];
                result.EffectAmount = int.Parse(effectArgs[1]);
            }

            return result;
        }

        [Given(@"(.*) is equipped with (.*)")]
        public void GivenAPCIsEquipped(string pcName, string itemNameList)
        {
            var itemNames = itemNameList.Split(',').Select(x => x.Trim()).ToArray();

            initializer.EquipPC(pcName, itemNames);
        }

        [Given(@"the inventory is empty")]
        public void GivenTheInventoryIsEmpty()
        {
            initializer.EmptyInventory();
        }

    }
}
