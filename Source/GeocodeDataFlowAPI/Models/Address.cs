﻿/*
 * Copyright(c) 2017 Microsoft Corporation. All rights reserved. 
 * 
 * This code is licensed under the MIT License (MIT). 
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal 
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
 * of the Software, and to permit persons to whom the Software is furnished to do 
 * so, subject to the following conditions: 
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software. 
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE. 
*/

using System.Xml.Serialization;

namespace BingMapsSDSToolkit.GeocodeDataflowAPI
{
    public class Address
    {
        #region Public Properties

        /// <summary>
        /// A string specifying the street line of an address. The AddressLine property is the most precise, 
        /// official line for an address relative to the postal agency that services the area specified by the 
        /// Locality, PostalTown, or PostalCode properties.
        /// </summary>
        [XmlAttribute]
        public string AddressLine { get; set; }

        /// <summary>
        /// A string specifying the subdivision name within the country or region for an address. 
        /// This element is also commonly treated as the first order administrative subdivision; but in some cases, 
        /// it is the second, third, or fourth order subdivision within a country, a dependency, or a region.
        /// </summary>
        [XmlAttribute]
        public string AdminDistrict { get; set; }

        /// <summary>
        /// A string specifying the country or region name of an address.
        /// </summary>
        [XmlAttribute]
        public string CountryRegion { get; set; }

        /// <summary>
        /// A string specifying the higher level administrative subdivision used in some countries or regions.
        /// </summary>
        [XmlAttribute]
        public string AdminDistrict2 { get; set; }

        /// <summary>
        /// A string that contains a full formatted address.
        /// </summary>
        [XmlAttribute]
        public string FormattedAddress { get; set; }

        /// <summary>
        /// A string specifying the populated place for the address. This commonly refers to a city, but may refer 
        /// to a suburb or a neighborhood in certain countries.
        /// </summary>
        [XmlAttribute]
        public string Locality { get; set; }

        /// <summary>
        /// A string specifying the post code, postal code, or ZIP Code of an address.
        /// </summary>
        [XmlAttribute]
        public string PostalCode { get; set; }

        /// <summary>
        /// A string specifying the post town of an address.
        /// </summary>
        [XmlAttribute]
        public string PostalTown { get; set; }

        /// <summary>
        /// A string specifying a landmark associated with an address.
        /// </summary>
        [XmlAttribute]
        public string Landmark { get; set; }

        /// <summary>
        /// A string specifying the neighborhood for an address.
        /// </summary>
        [XmlAttribute]
        public string Neighborhood { get; set; }

        #endregion

        #region Public Methods

        public override int GetHashCode()
        {
            int hash = 0;

            if (!string.IsNullOrWhiteSpace(AddressLine))
            {
                hash ^= AddressLine.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(AdminDistrict))
            {
                hash ^= AdminDistrict.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(AdminDistrict2))
            {
                hash ^= AdminDistrict2.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(CountryRegion))
            {
                hash ^= CountryRegion.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(FormattedAddress))
            {
                hash ^= FormattedAddress.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(Locality))
            {
                hash ^= Locality.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(PostalCode))
            {
                hash ^= PostalCode.GetHashCode();
            }
            
            if (!string.IsNullOrWhiteSpace(PostalTown))
            {
                hash ^= PostalTown.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(Landmark))
            {
                hash ^= Landmark.GetHashCode();
            }

            if (!string.IsNullOrWhiteSpace(Neighborhood))
            {
                hash ^= Neighborhood.GetHashCode();
            }

            return hash;
        }

        public override bool Equals(object obj)
        {
            if (obj is GeocodeRequest)
            {
                return base.GetHashCode() == (obj as GeocodeRequest).GetHashCode();
            }

            return false;
        }

        public static bool operator ==(Address x, object y)
        {
            if (y != null)
            {
                return x.GetHashCode() == y.GetHashCode();
            }

            return false;
        }

        public static bool operator !=(Address x, object y)
        {
            return !(x == y);
        }

        #endregion
    }
}
