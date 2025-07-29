// using System; // 📦 Brings in the System namespace for basic input/output and utilities

// /*
// 🔍 Exercise: RPG Battle Simulation using do-while loop

// 🧠 Objective:
// Simulate a turn-based battle between a Hero and a Monster using a `do-while` loop.
// Each character starts with 10 health points.
// Each attack does random damage between 1 and 10.
// The Hero attacks first, then the Monster (if still alive).
// The loop ends when either reaches 0 or below.

// 🎯 Outcome:
// Print damage dealt and remaining health after each attack.
// Announce the winner at the end.
// */

// class DoWhileBattleChallenge
// {
//   static void Main(string[] args)
//   {
//     // ✅ Step 1: Declare health values for each fighter
//     int heroHealth = 10;
//     int monsterHealth = 10;

//     // ✅ Step 2: Create a Random number generator
//     // Used for both hero and monster attacks
//     Random random = new Random();

//     // ✅ Step 3: Begin the do-while loop
//     do
//     {
//       // 🔁 Hero attacks first
//       // ✅ Damage is generated randomly (0 to 10 inclusive)
//       // ❗ Using random.Next(11) gives numbers from 0 to 10 — not 1 to 10
//       int heroAttack = random.Next(11);

//       // 🔁 Monster’s potential attack is also pre-generated
//       int monsterAttack = random.Next(11);

//       // ✅ Apply hero’s damage to monster
//       monsterHealth -= heroAttack;

//       // 🖨️ Print the result of hero’s attack
//       Console.WriteLine($"Monster has {monsterHealth} health after taking {heroAttack} damage");

//       // ✅ Check if monster is dead
//       if (monsterHealth <= 0)
//       {
//         // 🎉 Hero wins
//         Console.WriteLine("Monster has been slayed");
//         break; // 🚪 Exit the loop early — no need to continue
//       }
//       else
//       {
//         // 🔁 Monster attacks back
//         heroHealth -= monsterAttack;

//         // 🖨️ Show result of monster’s attack
//         Console.WriteLine($"Hero has {heroHealth} health after taking {monsterAttack} damage");
//       }

//       // ✅ Check if hero is dead after monster's attack
//       if (heroHealth <= 0)
//       {
//         // 💀 Monster wins
//         Console.WriteLine("Hero has been slain");
//         break; // 🚪 Exit the loop early — game over
//       }

//     }
//     // ✅ Condition allows loop to continue if either is still alive
//     // 💡 Clever use of OR (||) ensures loop continues while either fighter remains
//     while (heroHealth > 0 || monsterHealth > 0);
//   }
// }


