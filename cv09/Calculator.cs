﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cv09
{
    public class Calculator
    {
        private enum Stav
        {
            PrvniCislo,
            Operace,
            DruheCislo,
            Vysledek
        };

        private Stav _stav;

        public string Display { get; private set; }
        public string Pamet { get; private set; }

        private double _prvniCislo;
        private double _druheCislo;
        private string _operace ="";
        private string _buffer; 

        private CultureInfo _cultureInfo; 

        public Calculator()
        {
            _stav = Stav.PrvniCislo;
            Display = "0";
            Pamet = "";
            _buffer = "";
            _cultureInfo = new CultureInfo("cs-CZ"); 
        }

        public void Tlacitko(string vstup)
        {
            if (double.TryParse(vstup, NumberStyles.Any, _cultureInfo, out double cislo)) 
            {
                if (_buffer == "0" && vstup != ",")
                {
                    _buffer = vstup;
                }
                else if (_buffer == "-0" && vstup != ",")
                {
                    _buffer = "-" + vstup;
                }
                else
                {
                    _buffer += vstup;
                }

                Display = _buffer;
            }
            else
            {
                switch (vstup)
                {
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        if (_stav == Stav.PrvniCislo && _buffer != "")
                        {
                            _prvniCislo = double.Parse(_buffer, _cultureInfo); 
                            _buffer = "";
                            _operace = vstup;
                            _stav = Stav.Operace;
                        }
                        else if (_stav == Stav.Vysledek)
                        {
                            _prvniCislo = double.Parse(Display, _cultureInfo); 
                            _operace = vstup;
                            _stav = Stav.Operace;
                        }
                        break;

                    case "=":
                        if (_stav == Stav.Operace)
                        {
                            _stav = Stav.DruheCislo;
                            _druheCislo = double.Parse(_buffer, _cultureInfo); 
                            _buffer = "";
                            Vypocitej();
                            _stav = Stav.Vysledek;
                        }
                        else if (_stav == Stav.DruheCislo && _buffer != "")
                        {
                            _druheCislo = double.Parse(_buffer, _cultureInfo); 
                            _buffer = "";
                            Vypocitej();
                            _stav = Stav.Vysledek;
                        }
                        break;

                    case "C":
                        // Clear
                        _stav = Stav.PrvniCislo;
                        _buffer = "";
                        _prvniCislo = 0;
                        _druheCislo = 0;
                        _operace = " ";
                        Display = "0";
                        Pamet = "";
                        break;
                    case "+/-":
                        if (_stav == Stav.PrvniCislo || _stav == Stav.Operace)
                        {
                            if (_buffer == "")
                            {
                                _buffer = "0";
                            }

                            if (_buffer[0] == '-')
                            {
                                _buffer = _buffer.Substring(1); 
                            }
                            else if (_buffer != "0")
                            {
                                _buffer = "-" + _buffer; 
                            }

                            Display = _buffer;
                        }
                        else if (_stav == Stav.Vysledek)
                        {
                            double vysledek = double.Parse(Display, _cultureInfo);
                            vysledek *= -1;
                            Display = vysledek.ToString(_cultureInfo); 
                            _buffer = Display;
                            _stav = Stav.PrvniCislo;
                        }
                        break;
                    case ",":
                        if (_stav == Stav.Vysledek)
                        {
                            _buffer = Display; 
                            _stav = Stav.PrvniCislo;
                        }

                        if (!_buffer.Contains(","))
                        {
                            if (_buffer == "")
                            {
                                _buffer = "0,";
                            }
                            else
                            {
                                _buffer += ",";
                            }
                            Display = _buffer;
                        }
                        break;
                    case "CE":
                        if (_stav == Stav.Vysledek)
                        {
                            
                            _buffer = "";
                            _prvniCislo = 0;
                            _operace = "";
                            _stav = Stav.PrvniCislo;
                        }
                        else
                        {
                            
                            _buffer = "";
                        }
                        Display = "0";
                        break;
                    case "←":
                        if (_buffer.Length > 1)
                        {
                            _buffer = _buffer.Substring(0, _buffer.Length - 1); 
                        }
                        else
                        {
                            _buffer = ""; 
                        }

                        Display = _buffer.Length > 0 ? _buffer : "0";
                        break;
                }
            }
        }

        private void Vypocitej()
        {
            double vysledek = 0;
            switch (_operace)
            {
                case "+":
                    vysledek = _prvniCislo + _druheCislo;
                    break;
                case "-":
                    vysledek = _prvniCislo - _druheCislo;
                    break;
                case "*":
                    vysledek = _prvniCislo * _druheCislo;
                    break;
                case "/":
                    vysledek = (_druheCislo != 0) ? _prvniCislo / _druheCislo : 0;
                    break;
            }

            Display = vysledek.ToString(_cultureInfo);
            Pamet = "M";
        }
    }
}
