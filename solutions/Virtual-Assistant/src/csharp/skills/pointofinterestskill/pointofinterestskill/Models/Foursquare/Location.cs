﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PointOfInterestSkill.Models.Foursquare
{
    public class Location
    {
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        [JsonProperty(PropertyName = "lat")]
        public float Lat { get; set; }

        [JsonProperty(PropertyName = "lng")]
        public float Lng { get; set; }

        [JsonProperty(PropertyName = "labeledLatLngs")]
        public LabelLatLng[] LabeledLatLngs { get; set; }

        [JsonProperty(PropertyName = "distance")]
        public int Distance { get; set; }

        [JsonProperty(PropertyName = "postalCode")]
        public string OostalCode { get; set; }

        [JsonProperty(PropertyName = "cc")]
        public string Cc { get; set; }

        [JsonProperty(PropertyName = "lngcity")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "formattedAddress")]
        public string[] FormattedAddress { get; set; }

        [JsonProperty(PropertyName = "crossStreet")]
        public string CrossStreet { get; set; }

        [JsonProperty(PropertyName = "neighborhood")]
        public string Neighborhood { get; set; }

        public string FullFormattedAddress
        {
            get
            {
                return string.Join("\n", FormattedAddress);
            }

            set
            {
                FullFormattedAddress = value;
            }
        }
    }
}
