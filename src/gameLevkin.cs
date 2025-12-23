using System;
using System.Xml.Linq;

Console.WriteLine("Ты просыпаешься в темной-темной комнате и тут голос из угла комнаты спрашивает: Как тебя зовут? \nНазовись...");
string name = Console.ReadLine();
if (!string.IsNullOrEmpty(name))
{
    name = char.ToUpper(name[0]) + name.Substring(1);
}
Console.WriteLine("------------------------------");
Console.WriteLine("Голос, который только что тебя спрашивал, заговорил вновь: \"Попробуй выберись! ХАХАХААХ...\"\nПривыкнув к темноте, ты замечаешь, что тут много мебели...");
Console.WriteLine("------------------------------");

bool game = false;

bool konvert = false;
bool karandash = false;
bool metla = false;
bool polotentse = false;
bool lom = false;
bool shitokVkluchen = false;
bool lighterSdelan = false;
bool folgaIBatareykiNaydeny = false;

bool check = false;
bool check2 = false;
int schetchik = 0;
bool narisoval = false;
bool ventilyatsiyaOtkryta = false;

while (!game)
{
    if (konvert && karandash && metla && lom)
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Голос извне вновь появляется и говорит тебе снять шлем. Ты его послушно снимаешь и понимаешь, что ты был всего лишь тестером гиперреалистичной игрушки, которая вводит тебя в кому и транслирует тебе игру с помощью специальной установки, в которой ты лежал... это всё было игрой.\nСпасибо за прохождение!\nНад этой игрушкой старался ученик-студент группы 25ИС11Д, потратил 2.5 часа.");
        break;
    }

    Console.WriteLine("\nВыбери действие:");
    Console.WriteLine("1. Посмотреть под всей мебелью и за ней");
    Console.WriteLine("2. Пойти вздремнуть на кровати");
    Console.WriteLine("3. Попробовать найти хоть что-то, что может дать свет / Посмотреть щиток");
    Console.WriteLine("4. Посмотреть под кровать");

    string first = Console.ReadLine();
    Console.WriteLine("------------------------------");

    switch (first)
    {
        case "1":
            Console.WriteLine($"Прошерстив каждый уголок за каждой тумбочкой, ты находишь пару вещичек:\n Странный карандаш \n Конверт с загадкой, которую ты сразу разгадываешь!\n{name}, Конверт и Странный карандаш добавлены в инвентарь");
            karandash = true;
            check = false;
            Console.WriteLine("------------------------------");

            while (!check)
            {
                Console.WriteLine("Подумай:");
                int variant = 1;
                int drawVariant = -1;
                int ventVariant = -1;
                int backVariant = -1;

                if (!narisoval)
                {
                    drawVariant = variant;
                    Console.WriteLine($"{variant}. Попробовать нарисовать что-нибудь на стенах");
                    variant++;
                }

                ventVariant = variant;
                Console.WriteLine($"{variant}. Где то тут должна быть вентиляция!");
                variant++;

                backVariant = variant;
                Console.WriteLine($"{variant}. Вернуться назад в своих размышлениях");

                string two = Console.ReadLine();
                Console.WriteLine("------------------------------");

                if (drawVariant != -1 && two == drawVariant.ToString() && !narisoval)
                {
                    Console.WriteLine($"Взяв карандаш, ты рисуешь и понимаешь, что он материализует всё, что ты нарисуешь. Ты рисуешь дверь и, открыв её, попадаешь в кладовку. Там ты находишь конверт.\n{name}, Конверт добавлен в инвентарь");
                    konvert = true;
                    narisoval = true;
                }
                else if (two == ventVariant.ToString())
                {
                    if (ventilyatsiyaOtkryta)
                    {
                        Console.WriteLine("Ты снова заглядываешь в вентиляцию, и видишь следующее:");
                        Console.WriteLine("Здесь больше ничего нет, Только пыль и звук улицы");
                        Console.WriteLine("------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Ты решил осмотреться и заметил вентиляцию. Попробуй открыть её.");
                        check2 = false;
                        schetchik = 1;
                        Random chislo = new Random();
                        int maxTry = chislo.Next(5, 10);

                        while (!check2)
                        {
                            int limit = lom ? 3 : maxTry;

                            if (schetchik >= limit)
                            {
                                string chemOtkryl = lom ? "лома" : "пустых рук";
                                Console.WriteLine($"С {schetchik}-го раза ты открыл вентиляцию с помощью {chemOtkryl}, за вентиляцией ты находишь полотенце.\n{name}, Полотенце добавлено в инвентарь");
                                polotentse = true;
                                ventilyatsiyaOtkryta = true;
                                check2 = true;
                                Console.WriteLine("------------------------------");
                            }
                            else
                            {
                                Console.WriteLine("Чет не получилось, мало каши ел. Попробуй ещё раз.");
                                Console.WriteLine("Нажми Enter, чтобы попробовать снова...");
                                Console.ReadLine();
                                schetchik++;
                                Console.WriteLine("------------------------------");
                            }
                        }
                    }
                }
                else if (two == backVariant.ToString())
                {
                    check = true;
                }
                else
                {
                    Console.WriteLine("Отец не оценил твой выбор, попробуй ещё раз.");
                    Console.WriteLine("------------------------------");
                }
            }
            break;

        case "2":
            Console.WriteLine("Решив поспать, тебе приснился странный сон. И вдруг ты просыпаешься в своей домашней кровати, смотришь в окно, а там мирное обычное утро. Кто знает, может, это всё был сон...\nПоздравляем! Ты выбрался из комнаты. Молодец!");
            game = true;
            Console.WriteLine("------------------------------");
            break;

        case "3":
            if (!folgaIBatareykiNaydeny && !shitokVkluchen)
            {
                Console.WriteLine($"Ты находишь батарейки и фольгу.\n{name}, Фольга и батарейки добавлены в инвентарь");
                folgaIBatareykiNaydeny = true;

                Console.WriteLine("Что делать дальше?");
                int variantLight = 1;
                int makeLighter = variantLight;
                Console.WriteLine($"{variantLight}. Сделать зажигалку");
                variantLight++;
                int returnLater = variantLight;
                Console.WriteLine($"{variantLight}. Вернуться позже");

                string lightChoice = Console.ReadLine();
                Console.WriteLine("------------------------------");

                if (lightChoice == makeLighter.ToString() && !lighterSdelan)
                {
                    Console.WriteLine($"Вспоминая лайфхаки для выживания, ты берешь зажигалку, прикрепляешь фольгу к обоим концам батарейки и берёшь из подушки на кровати пух, поджигаешь его и видишь провода вокруг идущие к щитку...");
                    lighterSdelan = true;
                }
                else
                {
                    Console.WriteLine("Ты решил вернуться позже.");
                    Console.WriteLine("------------------------------");
                }
            }

            if (lighterSdelan || shitokVkluchen)
            {
                Console.WriteLine("Что делать дальше?");
                int variantShitok = 1;
                int checkShitok = variantShitok;
                Console.WriteLine($"{variantShitok}. Осмотреть щиток");
                variantShitok++;
                int returnMain = variantShitok;
                Console.WriteLine($"{variantShitok}. Вернуться в основное меню");

                string choiceShitok = Console.ReadLine();
                Console.WriteLine("------------------------------");

                switch (choiceShitok)
                {
                    case var v when v == checkShitok.ToString():
                        if (!shitokVkluchen)
                        {
                            if (konvert || karandash || lom)
                            {
                                Console.WriteLine($"Ты используешь инструмент и включаешь щиток. Свет загорается, осматриваясь, ты видишь, что на полу появилась метла. Подойдя к ней, ты подбираешь её.\n{name}, Метла добавлена в инвентарь");
                                metla = true;
                                shitokVkluchen = true;
                            }
                            else
                            {
                                Console.WriteLine("К сожалению, ты не смог открыть щиток без инструментов.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Все выглядит также, как и в прошлый раз. Свет включен");
                        }
                        Console.WriteLine("------------------------------");
                        break;

                    case var v when v == returnMain.ToString():
                        break;

                    default:
                        Console.WriteLine("Неверный выбор, попробуй ещё раз.");
                        Console.WriteLine("------------------------------");
                        break;
                }
            }

            break;

        case "4":
            if (!lom)
            {
                Console.WriteLine($"Ты заглядываешь под кровать и находишь Лом.\n{name}, Лом добавлен в инвентарь");
                lom = true;
            }
            else
            {
                Console.WriteLine("Заглянув под кровать снова, ты видишь белоснежную улыбку Рикардо Милоса.");
            }
            Console.WriteLine("------------------------------");
            break;

        default:
            Console.WriteLine("Неверный выбор, попробуй ещё раз.");
            Console.WriteLine("------------------------------");
            break;
    }
}
