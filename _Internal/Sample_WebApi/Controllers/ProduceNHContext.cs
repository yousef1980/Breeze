﻿using Breeze.WebApi.NH;
using Models.Produce.NH;

namespace Sample_WebApi.Controllers {

  public class ProduceNHContext : NHContext {

        public ProduceNHContext() : base(ProduceNHConfig.OpenSession(), ProduceNHConfig.Configuration) { }

        public ProduceNHContext(NHContext sourceContext) : base(sourceContext) { }

        public ProduceNHContext Context
        {
            get { return this; }
        }
        public string GetHardcodedMetadata()
        {
      var metadata = @"{
  ""localQueryComparisonOptions"": ""caseInsensitiveSQL"",
  ""structuralTypes"": [
    {
      ""shortName"": ""ItemOfProduce"",
      ""namespace"": ""Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""ItemsOfProduce"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Id"",
          ""dataType"": ""Guid"",
          ""isNullable"": false,
          ""isPartOfKey"": true,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""name"": ""guid""
            }
          ]
        },
        {
          ""nameOnServer"": ""ItemNumber"",
          ""dataType"": ""String"",
          ""isNullable"": false,
          ""maxLength"": 8,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""maxLength"": ""8"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""UnitPrice"",
          ""dataType"": ""Decimal"",
          ""isNullable"": true,
          ""validators"": [
            {
              ""name"": ""number""
            }
          ]
        },
        {
          ""nameOnServer"": ""QuantityPerUnit"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 20,
          ""validators"": [
            {
              ""maxLength"": ""20"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""UnitsInStock"",
          ""dataType"": ""Int32"",
          ""isNullable"": true,
          ""validators"": [
            {
              ""name"": ""int32""
            }
          ]
        },
        {
          ""nameOnServer"": ""UnitsOnOrder"",
          ""dataType"": ""Int32"",
          ""isNullable"": false,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""name"": ""int32""
            }
          ]
        },
        {
          ""nameOnServer"": ""RowVersion"",
          ""dataType"": ""Int32"",
          ""isNullable"": true,
          ""validators"": [
            {
              ""name"": ""int32""
            }
          ]
        }
      ],
      ""navigationProperties"": []
    },
    {
      ""shortName"": ""Fruit"",
      ""namespace"": ""Models.Produce.NH"",
      ""baseTypeName"": ""ItemOfProduce:#Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""Fruits"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Name"",
          ""dataType"": ""String"",
          ""isNullable"": false,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""USDACategory"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        }
      ],
      ""navigationProperties"": []
    },
    {
      ""shortName"": ""Vegetable"",
      ""namespace"": ""Models.Produce.NH"",
      ""baseTypeName"": ""ItemOfProduce:#Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""Vegetables"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Name"",
          ""dataType"": ""String"",
          ""isNullable"": false,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""USDACategory"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""AboveGround"",
          ""dataType"": ""Boolean"",
          ""isNullable"": true,
          ""validators"": [
            {
              ""name"": ""bool""
            }
          ]
        }
      ],
      ""navigationProperties"": []
    },
    {
      ""shortName"": ""Apple"",
      ""namespace"": ""Models.Produce.NH"",
      ""baseTypeName"": ""Fruit:#Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""Apples"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Variety"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Description"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 250,
          ""validators"": [
            {
              ""maxLength"": ""250"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Photo"",
          ""dataType"": ""Binary"",
          ""isNullable"": true
        }
      ],
      ""navigationProperties"": []
    },
    {
      ""shortName"": ""Strawberry"",
      ""namespace"": ""Models.Produce.NH"",
      ""baseTypeName"": ""Fruit:#Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""Strawberries"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Variety"",
          ""dataType"": ""String"",
          ""isNullable"": false,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Description"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 200,
          ""validators"": [
            {
              ""maxLength"": ""200"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Photo"",
          ""dataType"": ""Binary"",
          ""isNullable"": true
        }
      ],
      ""navigationProperties"": []
    },
    {
      ""shortName"": ""Tomato"",
      ""namespace"": ""Models.Produce.NH"",
      ""baseTypeName"": ""Vegetable:#Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""Tomatos"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Variety"",
          ""dataType"": ""String"",
          ""isNullable"": false,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Description"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 100,
          ""validators"": [
            {
              ""maxLength"": ""100"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Determinate"",
          ""dataType"": ""Boolean"",
          ""isNullable"": true,
          ""validators"": [
            {
              ""name"": ""bool""
            }
          ]
        },
        {
          ""nameOnServer"": ""Photo"",
          ""dataType"": ""Binary"",
          ""isNullable"": true
        }
      ],
      ""navigationProperties"": []
    },
    {
      ""shortName"": ""WhitePotato"",
      ""namespace"": ""Models.Produce.NH"",
      ""baseTypeName"": ""Vegetable:#Models.Produce.NH"",
      ""autoGeneratedKeyType"": ""KeyGenerator"",
      ""defaultResourceName"": ""WhitePotatos"",
      ""dataProperties"": [
        {
          ""nameOnServer"": ""Variety"",
          ""dataType"": ""String"",
          ""isNullable"": false,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""name"": ""required""
            },
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""SkinColor"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 20,
          ""validators"": [
            {
              ""maxLength"": ""20"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Eyes"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 20,
          ""validators"": [
            {
              ""maxLength"": ""20"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""PrimaryUses"",
          ""dataType"": ""String"",
          ""isNullable"": true,
          ""maxLength"": 50,
          ""validators"": [
            {
              ""maxLength"": ""50"",
              ""name"": ""maxLength""
            }
          ]
        },
        {
          ""nameOnServer"": ""Photo"",
          ""dataType"": ""Binary"",
          ""isNullable"": true
        }
      ],
      ""navigationProperties"": []
    }
  ],
  ""resourceEntityTypeMap"": {
    ""Apples"": ""Apple:#Models.Produce.NH"",
    ""Strawberries"": ""Strawberry:#Models.Produce.NH"",
    ""Fruits"": ""Fruit:#Models.Produce.NH"",
    ""Tomatos"": ""Tomato:#Models.Produce.NH"",
    ""WhitePotatos"": ""WhitePotato:#Models.Produce.NH"",
    ""Vegetables"": ""Vegetable:#Models.Produce.NH"",
    ""ItemsOfProduce"": ""ItemOfProduce:#Models.Produce.NH""
  },
  ""fkMap"": {}
} ";
      return metadata;
            
        }

        public NhQueryableInclude<Apple> Apples
        {
            get { return GetQuery<Apple>(); }
        }
        public NhQueryableInclude<Fruit> Fruits
        {
            get { return GetQuery<Fruit>(); }
        }
        public NhQueryableInclude<ItemOfProduce> ItemsOfProduce
        {
            get { return GetQuery<ItemOfProduce>(); }
        }
        public NhQueryableInclude<Strawberry> Strawberries
        {
            get { return GetQuery<Strawberry>(); }
        }
        public NhQueryableInclude<Tomato> Tomatoes
        {
            get { return GetQuery<Tomato>(); }
        }
        public NhQueryableInclude<Vegetable> Vegetables
        {
            get { return GetQuery<Vegetable>(); }
        }
        public NhQueryableInclude<WhitePotato> WhitePotatoes
        {
            get { return GetQuery<WhitePotato>(); }
        }
  }
}