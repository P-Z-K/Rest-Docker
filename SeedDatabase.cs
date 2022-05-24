using DDSpells.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace DDSpells
{
    public static class SeedDatabase
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<DataContext>();

                if (!context.CastingTimes.Any())
                {
                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "1 Reaction"
                    });

                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "1 Minute"
                    });

                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "10 Minutes"
                    });

                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "1 Hour"
                    });

                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "8 Hours"
                    });

                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "12 Hours"
                    });

                    context.CastingTimes.Add(new CastingTime
                    {
                        Name = "24 Hours"
                    });
                }

                if (!context.SpellSchools.Any())
                {
                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Abjuration"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Conjuration"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Divination"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Enchantment"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Evocation"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Illusion"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Necromancy"
                    });

                    context.SpellSchools.Add(new SpellSchool
                    {
                        Name = "Transmutation"
                    });
                }

                if (!context.Classes.Any())
                {
                    context.Classes.Add(new Class
                    {
                        Name = "Artificer"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Artificer"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Bard"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Cleric"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Druid"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Paladin"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Sorcerer"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Warlock"
                    });

                    context.Classes.Add(new Class
                    {
                        Name = "Wizard"
                    });
                }

                context.SaveChanges();
            }

            
        }
    }
}
