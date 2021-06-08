using System;
using System.Linq;
using System.Collections.Generic;

namespace HW11
{
    public interface IHomework11
    {
        string GetReadWordOfNumber(int number);
    }
    class ReadWordNumber : IHomework11
    {
        public string GetReadWordOfNumber(int number)
        {
            string text;
            int len = Convert.ToString(number).Length;
            List<String> WordNumber = new List<string>();

            if (number >= 0)
            {
                ///Console.WriteLine(len );
                Console.WriteLine(" ");
                Console.WriteLine("The output : ");
                
                for (int i = 0; i < len; i++)
                {
                    text = Convert.ToString(number).Substring(i, 1);

                    if (len == 1)
                    {
                        string[] n = { "ศููนย์", "หนึ่ง", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                        WordNumber.Add(n[Convert.ToInt32(text)]);
                        break;
                    }

                    else if (len == 2)
                    {
                        if (i == 0)
                        {
                            string[] n = { "", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ" };
                            WordNumber.Add(n[Convert.ToInt32(text)]);
                        }
                        else if (i == 1)
                        {
                            string[] n1 = { "", "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                            WordNumber.Add(n1[Convert.ToInt32(text)]);
                            break;
                        }
                    }
                    else if (len == 3)
                    {
                        if (i == 0)
                        {
                            string[] n = { "", "หนึ่งร้อย", "สองร้อย", "สามร้อย", "สี่ร้อย", "ห้าร้อย", "หกร้อย", "เจ็ดร้อย", "แปดร้อย", "เก้าร้อย" };
                            WordNumber.Add(n[Convert.ToInt32(text)]);
                        }
                        else if (i == 1)
                        {
                            string[] n1 = { "", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ" };
                            WordNumber.Add(n1[Convert.ToInt32(text)]);
                        }
                        else if (i == 2)
                        {
                            string[] n2 = { "", "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                            WordNumber.Add(n2[Convert.ToInt32(text)]);
                            break;
                        }
                    }
                    else if (len == 4)
                    {
                        if (i == 0)
                        {
                            string[] n = { "", "หนึ่งพัน", "สองพัน", "สามพัน", "สี่พัน", "ห้าพัน", "หกพัน", "เจ็ดพัน", "แปดพัน", "เก้าพัน" };
                            WordNumber.Add(n[Convert.ToInt32(text)]);
                        }
                        else if (i == 1)
                        {
                            string[] n1 = { "", "หนึ่งร้อย", "สองร้อย", "สามร้อย", "สี่ร้อย", "ห้าร้อย", "หกร้อย", "เจ็ดร้อย", "แปดร้อย", "เก้าร้อย" };
                            WordNumber.Add(n1[Convert.ToInt32(text)]);
                        }
                        else if (i == 2)
                        {
                            string[] n2 = { "", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ" };
                            WordNumber.Add(n2[Convert.ToInt32(text)]);
                        }
                        else if (i == 3)
                        {
                            string[] n3 = { "", "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                            WordNumber.Add(n3[Convert.ToInt32(text)]);
                            break;
                        }

                    }
                    else if (len == 5)
                    {
                        if (i == 0)
                        {
                            string[] n = { "", "หนึ่งหมื่น", "สองหมื่น", "สามหมื่น", "สี่หมื่น", "ห้าหมื่น", "หกหมื่น", "เจ็ดหมื่น", "แปดหมื่น", "เก้าหมื่น" };
                            WordNumber.Add(n[Convert.ToInt32(text)]);
                        }
                        else if (i == 1)
                        {
                            string[] n1 = { "", "หนึ่งพัน", "สองพัน", "สามพัน", "สี่พัน", "ห้าพัน", "หกพัน", "เจ็ดพัน", "แปดพัน", "เก้าพัน" };
                            WordNumber.Add(n1[Convert.ToInt32(text)]);
                        }
                        else if (i == 2)
                        {
                            string[] n2 = { "", "หนึ่งร้อย", "สองร้อย", "สามร้อย", "สี่ร้อย", "ห้าร้อย", "หกร้อย", "เจ็ดร้อย", "แปดร้อย", "เก้าร้อย" };
                            WordNumber.Add(n2[Convert.ToInt32(text)]);
                        }
                        else if (i == 3)
                        {
                            string[] n3 = { "", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ" };
                            WordNumber.Add(n3[Convert.ToInt32(text)]);
                        }
                        else if (i == 4)
                        {
                            string[] n4 = { "", "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                            WordNumber.Add(n4[Convert.ToInt32(text)]);
                            break;
                        }
                    }
                    else if (len == 6)
                    {
                        if (i == 0)
                        {
                            string[] n = { "", "หนึ่งแสน", "สองแสน", "สามแสน", "สี่แสน", "ห้าแสน", "หกแสน", "เจ็ดแสน", "แปดแสน", "เก้าแสน" };
                            WordNumber.Add(n[Convert.ToInt32(text)]);
                        }
                        else if (i == 1)
                        {
                            string[] n1 = { "", "หนึ่งหมื่น", "สองหมื่น", "สามหมื่น", "สี่หมื่น", "ห้าหมื่น", "หกหมื่น", "เจ็ดหมื่น", "แปดหมื่น", "เก้าหมื่น" };
                            WordNumber.Add(n1[Convert.ToInt32(text)]);
                        }
                        else if (i == 2)
                        {
                            string[] n2 = { "", "หนึ่งพัน", "สองพัน", "สามพัน", "สี่พัน", "ห้าพัน", "หกพัน", "เจ็ดพัน", "แปดพัน", "เก้าพัน" };
                            WordNumber.Add(n2[Convert.ToInt32(text)]);
                        }
                        else if (i == 3)
                        {
                            string[] n3 = { "", "หนึ่งร้อย", "สองร้อย", "สามร้อย", "สี่ร้อย", "ห้าร้อย", "หกร้อย", "เจ็ดร้อย", "แปดร้อย", "เก้าร้อย" };
                            WordNumber.Add(n3[Convert.ToInt32(text)]);
                        }
                        else if (i == 4)
                        {
                            string[] n4 = { "", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ" };
                            WordNumber.Add(n4[Convert.ToInt32(text)]);
                        }
                        else if (i == 5)
                        {
                            string[] n5 = { "", "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                            WordNumber.Add(n5[Convert.ToInt32(text)]);
                            break;
                        }
                    }
                    else if (len == 7)
                    {
                        if (i == 0)
                        {
                            string[] n = { "", "หนึ่งล้าน", "สองล้าน", "สามล้าน", "สี่ล้าน", "ห้าล้าน", "หกล้าน", "เจ็ดล้าน", "แปดล้าน", "เก้าล้าน" };
                            WordNumber.Add(n[Convert.ToInt32(text)]);
                        }
                        else if (i == 1)
                        {
                            string[] n1 = { "", "หนึ่งแสน", "สองแสน", "สามแสน", "สี่แสน", "ห้าแสน", "หกแสน", "เจ็ดแสน", "แปดแสน", "เก้าแสน" };
                            WordNumber.Add(n1[Convert.ToInt32(text)]);
                        }
                        else if (i == 2)
                        {
                            string[] n2 = { "", "หนึ่งหมื่น", "สองหมื่น", "สามหมื่น", "สี่หมื่น", "ห้าหมื่น", "หกหมื่น", "เจ็ดหมื่น", "แปดหมื่น", "เก้าหมื่น" };
                            WordNumber.Add(n2[Convert.ToInt32(text)]);
                        }
                        else if (i == 3)
                        {
                            string[] n3 = { "", "หนึ่งพัน", "สองพัน", "สามพัน", "สี่พัน", "ห้าพัน", "หกพัน", "เจ็ดพัน", "แปดพัน", "เก้าพัน" };
                            WordNumber.Add(n3[Convert.ToInt32(text)]);
                        }
                        else if (i == 4)
                        {
                            string[] n4 = { "", "หนึ่งร้อย", "สองร้อย", "สามร้อย", "สี่ร้อย", "ห้าร้อย", "หกร้อย", "เจ็ดร้อย", "แปดร้อย", "เก้าร้อย" };
                            WordNumber.Add(n4[Convert.ToInt32(text)]);
                        }
                        else if (i == 5)
                        {
                            string[] n5 = { "", "สิบ", "ยี่สิบ", "สามสิบ", "สี่สิบ", "ห้าสิบ", "หกสิบ", "เจ็ดสิบ", "แปดสิบ", "เก้าสิบ" };
                            WordNumber.Add(n5[Convert.ToInt32(text)]);
                        }
                        else if (i == 6)
                        {
                            string[] n6 = { "", "เอ็ด", "สอง", "สาม", "สี่", "ห้า", "หก", "เจ็ด", "แปด", "เก้า" };
                            WordNumber.Add(n6[Convert.ToInt32(text)]);
                            break;
                        }
                    }
                }

                foreach (string i in WordNumber)
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine("");
            return null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            ReadWordNumber n = new ReadWordNumber();
            n.GetReadWordOfNumber(num);
        }
    }
}
