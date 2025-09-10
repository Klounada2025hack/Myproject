using System.Xml.Linq;

Console.WriteLine("Ты просыпаешься в темной-темной комнате и тут голос из угла комнаты спрашивает: Как тебя зовут? \nНазовись...");
string name = Console.ReadLine();
Console.WriteLine("Голос, который только что тебя спрашивал, заговорил вновь: \"Попробуй выберись! ХАХАХААХ...\"\nПривыкнув к темноте, ты замечаешь, что тут много мебели...");
bool game = false;
bool first_art = false;
bool second_art = false;
bool third_art = false;
bool chetverty = false;
bool chetverty_art = false;
bool check = false;
bool check2 = false;
int schetchik = 0;

while (game == false)
{
    if (first_art && second_art && third_art&&chetverty_art)
    {
        Console.WriteLine("Голос извне вновь появляется и говорит тебе снять шлем. Ты его послушно снимаешь и понимаешь, что ты был всего лишь тестером гиперреалистичной игрушки, которая вводит тебя в кому и транслирует тебе игру с помощью специальной установки, в которой ты лежал... это всё было игрой.\nСпасибо за прохождение!\nНад этой игрушкой старался ученик-студент группы 25ИС11Д, потратил 2.5 часа.");
        break;
    }

    Console.WriteLine("\nВыбери действие:\n 1. Посмотреть под всей мебелью и за ней\n 2. Пойти вздремнуть на кровати\n 3. Попробовать найти хоть что-то, что может дать свет\n 4. Посмотреть под кровать");
    string first = Console.ReadLine();

    switch (first)
    {
        case "1":
            Console.WriteLine($"Прошерстив каждый уголок за каждой тумбочкой, ты находишь пару вещичек:\n Странный карандаш \n Конверт с загадкой, которую ты сразу разгадываешь!\n{name}, в инвентарь добавлены: 'Конверт' и 'Странный карандаш'");
            check = false;

            while (check == false)
            {
                Console.WriteLine("Подумай \n 1. Попробовать нарисовать что-нибудь на стенах\n 2. Где то тут должна быть вентиляция!\n 3. Вернуться назад в своих размышлениях");
                string two = Console.ReadLine();

                second_art = true;

                switch (two)
                {
                    case "1":
                        Console.WriteLine($"Взяв карандаш, ты рисуешь и понимаешь, что он материализует всё, что ты нарисуешь. Ты рисуешь дверь и, открыв её, попадаешь в кладовку. Там ты находишь конверт.\n{name}, 'Конверт' добавлен в инвентарь");
                        first_art = true;
                        check = false;
                        break;

                    case "2":
                        Console.WriteLine("Ты решил осмотреться ещё раз и заметил вентиляцию. Попробуй открыть её.");
                        check2 = false;
                        schetchik = 0;
                        Random chislo = new Random();
                        int chislo2 = chislo.Next(1, 10);
                        while (check2 == false)
                        {
                            schetchik++;
                            int POPITka = first_art ? 4 : chislo2;

                            if (schetchik >= POPITka)
                            {
                                Console.WriteLine($"С {POPITka}-го раза ты открыл вентиляцию с помощью лома, за вентиляцией ты находишь полотенце.\n{name}, 'Полотенце' добавлено в инвентарь");
                                chetverty = true;
                                check2 = true;
                                check = false;
                            }
                            else
                            {
                                Console.WriteLine("Чет не получилось, мало каши ел. Попробуй ещё раз.");
                                Console.WriteLine("Нажми Enter, чтобы попробовать снова...");
                                Console.ReadLine();
                                check = false;
                            }
                        }
                        break;

                    case "3":
                        check = true;
                        break;

                    default:
                        Console.WriteLine("Отец не оценил твой выбор, попробуй ещё раз.");
                        break;
                }
            }
            break;

        case "2":
            Console.WriteLine("Решив поспать, тебе приснился странный сон. И вдруг ты просыпаешься в своей домашней кровати, смотришь в окно, а там мирное обычное утро. Кто знает, может, это всё был сон...\nПоздравляем! Ты выбрался из комнаты. Молодец!");
            game = true;
            break;

        case "3":
            Console.WriteLine("Ты находишь батарейки и фольгу. Хм, можно сделать зажигалку... не зря смотрел ютубчик. Чуть позже ты разжигаешь огонь и видишь провода, идущие к щитку.\n1. Попытаться открыть щиток\n2. Вернуться позже");
            string three = Console.ReadLine();

            switch (three)
            {
                case "1":
                    if (first_art)
                    {
                        Console.WriteLine($"Ты рисуешь отверстие в щитке карандашом. Пробравшись внутрь, включаешь электричество. Что-то движется. Осмотревшись, ты видишь, что на полу появилась метла. Подойдя к ней, ты подбираешь её.\n{name} положил 'Метлу' в инвентарь");
                        third_art = true;
                    }
                    else if (second_art)
                    {
                        Console.WriteLine($"Ты смог оторвать дверцу щитка. Включаешь электричество. Что-то движется. На полу появляется метла. Подбираешь её.\n{name} положил 'Метлу' в инвентарь");
                        third_art = true;
                    }
                    else
                    {
                        Console.WriteLine("К сожалению, ты не смог открыть щиток без подручных инструментов. Попробуй что-нибудь поискать.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Ты решил вернуться позже.");
                    break;

                default:
                    Console.WriteLine("Неверный выбор, попробуй ещё раз.");
                    break;
            }
            break;

        case "4":
            if (chetverty_art)
            {
                Console.WriteLine("Заглянув под кровать снова, ты видишь белоснежную улыбку Рикардо Милоса.");
            }
            else
            {
                Console.WriteLine($"Ты заглядываешь под кровать и находишь Лом.\n{name} В инвентарь добавлен 'Лом'");
                chetverty_art = true;
            }
            break;

        default:
            Console.WriteLine("Неверный выбор, попробуй ещё раз.");
            break;
    }
}