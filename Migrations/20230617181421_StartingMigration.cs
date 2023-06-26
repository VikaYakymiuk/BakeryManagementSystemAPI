using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class StartingMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries-table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries-table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers-table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Locations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers-table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers-table_Countries-table_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries-table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributors-table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors-table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Distributors-table_Countries-table_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries-table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries-table",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Isle of Man" },
                    { new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Tajikistan" },
                    { new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Japan" },
                    { new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "South Africa" },
                    { new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Qatar" },
                    { new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "China" },
                    { new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Saint Lucia" },
                    { new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Zambia" },
                    { new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Jamaica" },
                    { new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Turkey" }
                });

            migrationBuilder.InsertData(
                table: "Customers-table",
                columns: new[] { "Id", "CountriesId", "Email", "FirstName", "LastName", "Locations", "Mobile", "Password" },
                values: new object[,]
                {
                    { new Guid("00c219da-d2cf-496f-8d91-4c99ed56b65f"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Julian95@gmail.com", "Julian", "Hagenes", "381 Keeling Grove, Port Bernieton, Malta", "1-317-346-2805", "5fdvYWy8Pz" },
                    { new Guid("032e86af-7a26-40b1-965f-c96d0b7a01ef"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Kayla.Carroll@gmail.com", "Kayla", "Carroll", "448 Denesik Shoal, Colehaven, Chad", "561.518.1800 x07317", "RCDM6OggmQ" },
                    { new Guid("046c778e-8909-44b3-804a-c96e6314f19e"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Ken77@hotmail.com", "Ken", "Parisian", "498 Ankunding Terrace, Vonville, Croatia", "(986) 252-1175 x158", "IgtXUaaiHh" },
                    { new Guid("0645e869-47bf-40a3-b742-48cde8decbd3"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Guadalupe12@yahoo.com", "Guadalupe", "Jacobson", "6568 Treva Rapids, West Deanna, Monaco", "(260) 845-1692", "XSyyHkqtMI" },
                    { new Guid("07012cbb-1773-4aec-bb1d-3b2692984335"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Craig_Flatley@hotmail.com", "Craig", "Flatley", "8204 Mueller Forest, New Elvis, Papua New Guinea", "1-876-502-9903 x86406", "huGR_lP_ea" },
                    { new Guid("07351d8a-1899-44c7-b26d-701cb24a0d75"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Kim_Parker@hotmail.com", "Kim", "Parker", "528 Cruz Forks, East Robinside, Mayotte", "526.993.5591 x2219", "nrsQ0dWbLK" },
                    { new Guid("075241bc-67b4-43dd-95c7-974d13e08078"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Rex_Sanford77@yahoo.com", "Rex", "Sanford", "749 Botsford Rue, Daniellaborough, Togo", "425-825-3803 x955", "jwOyZ9GBMh" },
                    { new Guid("0c86cf84-bd94-4bf4-9517-818e34d83d56"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Evelyn57@gmail.com", "Evelyn", "McLaughlin", "7362 Stokes Land, Hermistonberg, Georgia", "(362) 881-0498 x609", "E3rhInhyud" },
                    { new Guid("0cec727d-095e-4c59-af5d-755eb43df7f8"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Valerie6@hotmail.com", "Valerie", "Renner", "729 Dalton Estates, South Reedmouth, Ecuador", "491.240.2428 x30517", "buwWc0XmCB" },
                    { new Guid("0dea1be2-a825-42df-8c9a-0de77e0bbb76"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Maxine.Smith34@yahoo.com", "Maxine", "Smith", "87530 Gillian Shoal, West Jayceeburgh, Mexico", "(517) 325-6019 x87666", "VJAkEllvqe" },
                    { new Guid("15b30bf7-1db0-4063-a425-56ac3ca3967a"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Erma_Lubowitz33@gmail.com", "Erma", "Lubowitz", "187 Murazik Freeway, Port Shad, Democratic People's Republic of Korea", "325.916.4938 x6624", "x9MECkkjub" },
                    { new Guid("1e91cff9-4aa7-4ee7-9566-6960a12f7f0f"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Grace.Lubowitz65@hotmail.com", "Grace", "Lubowitz", "32109 Valerie Village, South Savion, Faroe Islands", "320.745.7485 x928", "sHsrpjyR1n" },
                    { new Guid("1e9a7480-35b3-4b1d-b681-fb7529c5e669"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Suzanne_Roberts@yahoo.com", "Suzanne", "Roberts", "704 Deron Dam, Cruickshankport, Virgin Islands, British", "741-232-1583", "5UrvHgNfbk" },
                    { new Guid("23c1839e-f206-463d-94e5-bf650fee287b"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Marlene.Thompson@gmail.com", "Marlene", "Thompson", "1903 Marjory Heights, Michaelborough, Serbia", "1-942-652-7424", "fb9byTS18A" },
                    { new Guid("2410272b-3673-4911-b53d-cd399fd34d64"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Carl67@gmail.com", "Carl", "West", "88104 Cassie Mills, East Adela, Croatia", "(342) 368-4405 x348", "hfxAIH7BMD" },
                    { new Guid("25f6a2b8-0ec5-4df7-9e49-4b63cb652ed6"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Salvatore.Kris@hotmail.com", "Salvatore", "Kris", "7364 Hodkiewicz Lights, East Kyleigh, Bosnia and Herzegovina", "(642) 543-1979 x9708", "ZPv0bcW9Vv" },
                    { new Guid("26fd5456-2be6-4051-8b31-d0bf8e7923c6"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Hector53@yahoo.com", "Hector", "Windler", "86459 Ledner Plain, Clemmiestad, Solomon Islands", "276-261-9526 x296", "l73yVulEC4" },
                    { new Guid("27aa552e-c592-4169-a15c-6cc4e33368ab"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Ray34@yahoo.com", "Ray", "Bauch", "456 Hartmann Crossing, East Jedidiahbury, Saint Pierre and Miquelon", "439-903-3783", "p6L3dMDObP" },
                    { new Guid("289ad0b6-78c8-42ee-97ca-f6778658b38a"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Patrick96@yahoo.com", "Patrick", "Schneider", "8066 Isadore Mill, East Ewellburgh, Qatar", "552.488.6445", "ZeCf9txtpu" },
                    { new Guid("291ecf28-ccbb-4d61-9662-783c7cabaed6"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Barbara65@yahoo.com", "Barbara", "Mueller", "7383 Jordon Lodge, Rogerston, Saint Barthelemy", "(745) 220-8709 x4978", "bluuLEwx_9" },
                    { new Guid("2d1b3146-dd37-4e3e-8804-66823da691e8"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Cecil.Abbott68@hotmail.com", "Cecil", "Abbott", "7336 Carrie Ports, East Weldon, Tokelau", "888.935.8916 x792", "RHdFnpqCbm" },
                    { new Guid("2f95b83b-d95b-4e33-87c8-ece9d75a8110"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Josh_Mueller3@hotmail.com", "Josh", "Mueller", "8112 Trantow Ranch, North Yvette, Algeria", "902-742-8792", "G0b1I0vLp8" },
                    { new Guid("336fdadb-5ca9-4957-a1e6-d22b14fbfd52"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Anne.Ullrich98@hotmail.com", "Anne", "Ullrich", "9188 Twila Harbor, Myriamland, Lesotho", "247.261.6234", "qI_Guhg3D_" },
                    { new Guid("34a0b459-c07e-4c38-85d8-4e3d873a54d4"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Marta65@gmail.com", "Marta", "Bauch", "4658 Schmitt Turnpike, North Wilhelmchester, India", "1-622-862-0210", "GHKYzGjrGc" },
                    { new Guid("3550cf10-8660-4d4f-9109-3e93d3d47ee9"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Carmen_Klein@hotmail.com", "Carmen", "Klein", "4256 Watsica Ports, North Gustberg, Benin", "(999) 674-3148 x329", "NjETQz2JSc" },
                    { new Guid("374e931b-e88a-46e7-9718-dd7460e64e07"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Travis_DuBuque8@gmail.com", "Travis", "DuBuque", "1963 Altenwerth Stream, Hettingermouth, Barbados", "1-745-760-5661", "5e7LXbr4PH" },
                    { new Guid("378d74fe-7015-4ec0-a8cf-b27c4a1a77a0"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Alexis64@yahoo.com", "Alexis", "Rice", "1747 Tillman Port, Claudiaton, Seychelles", "(219) 299-1571", "h0zrcuDWYW" },
                    { new Guid("37b44599-ff50-4e5e-bd57-0e32e7c2fac6"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Vicki58@hotmail.com", "Vicki", "Spinka", "8308 Schultz Ferry, Thurmanfort, South Africa", "509.525.1691 x2903", "w6Re5mlm5u" },
                    { new Guid("3bf39133-b65b-44d1-8783-79e0fe17a617"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Nelson_Collins@hotmail.com", "Nelson", "Collins", "8168 Marks Alley, North Leta, Moldova", "578-848-3706", "tdD8K6HHNP" },
                    { new Guid("3c9b3bca-931d-4930-8c2e-7bb66f98e27c"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Sylvia.Stehr@gmail.com", "Sylvia", "Stehr", "7317 Buckridge Trail, East Odessaville, Svalbard & Jan Mayen Islands", "525-580-7456", "FmlxrbbBrr" },
                    { new Guid("3ccb0818-ba49-4849-beae-0bb998ad1c12"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Tammy.Murphy@gmail.com", "Tammy", "Murphy", "5424 Marks Circles, New Darrinstad, Guyana", "(932) 997-3526 x98233", "HgfHSbsphj" },
                    { new Guid("3dbf519b-5fd0-4a5f-8a62-26125b060940"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Simon_Greenholt56@hotmail.com", "Simon", "Greenholt", "77409 Beer Trafficway, East Viva, Thailand", "1-753-286-2386", "l_AN2lUQmg" },
                    { new Guid("4085cacf-c4ce-434f-8e84-0cfd4949fee8"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Eugene26@yahoo.com", "Eugene", "Walsh", "23733 Dare Overpass, East Rickie, Andorra", "(311) 323-9318", "uBdRPmGW2G" },
                    { new Guid("434a7ce4-429a-42d5-b34f-b40e1745bb91"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Ed87@hotmail.com", "Ed", "Johns", "19330 Dickinson Hills, Sanfordburgh, Uzbekistan", "1-950-687-3649 x88218", "vRtGGmATId" },
                    { new Guid("43755688-0f5d-4d11-a937-c6d210798f34"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Isabel84@gmail.com", "Isabel", "Stracke", "37541 Marshall Key, East Modesta, Papua New Guinea", "1-930-763-9995 x00954", "AF31dhzrQy" },
                    { new Guid("440272c6-8052-4373-b397-ba5ef9d084c1"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Muriel.Wunsch@yahoo.com", "Muriel", "Wunsch", "500 Jolie Terrace, East Elinore, Bahrain", "250-685-0730", "TwoQB4MasV" },
                    { new Guid("462f2a74-b101-42af-bee5-8e6591b85835"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Lindsay.Gutkowski45@yahoo.com", "Lindsay", "Gutkowski", "1235 Luz Radial, Elliottberg, Haiti", "312.837.6436", "f5TOorfwNV" },
                    { new Guid("47b77398-9667-4d66-bda6-342249321191"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Christie_Ruecker29@hotmail.com", "Christie", "Ruecker", "408 Hirthe Place, Port Emilianohaven, Georgia", "(734) 969-6385", "8rS2CMAet1" },
                    { new Guid("48c34d2b-9496-4587-9487-18fe4fe2f196"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Camille.Beer@yahoo.com", "Camille", "Beer", "82624 Cole Park, East Merlin, Cook Islands", "1-569-968-5325 x5183", "8vERWv2euE" },
                    { new Guid("4c22919c-a5a9-4735-bcbe-fe614d59d963"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Allen.Friesen@gmail.com", "Allen", "Friesen", "6035 Gregorio Islands, Schultzhaven, Romania", "613-446-4429 x86150", "wV64QKDipr" },
                    { new Guid("4cdab602-968a-43f6-bbba-d4b04c986f62"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Anita.Gleason12@gmail.com", "Anita", "Gleason", "8372 Emelia Circle, North Cole, Argentina", "318.237.3672", "H6MUEMLMHM" },
                    { new Guid("4e761bbf-adbe-4320-92db-eb6ac3a467fb"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Kari_Hackett76@yahoo.com", "Kari", "Hackett", "760 Lillie Crescent, South Rosanna, American Samoa", "1-723-662-2587", "5nQnRVAQol" },
                    { new Guid("4fc18c92-6888-4679-8a26-fcf43493abf4"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Barbara.Kessler@yahoo.com", "Barbara", "Kessler", "84344 Kulas Expressway, Ziemannview, Australia", "(610) 515-9067 x755", "TQ8f5vrSXU" },
                    { new Guid("50e11416-581a-43e4-9aaf-aa2203fee608"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Garrett12@hotmail.com", "Garrett", "Skiles", "7033 Gorczany Villages, Kodychester, Bulgaria", "895.796.3057 x27267", "ovvYTzVloo" },
                    { new Guid("513c9cf4-18f5-4350-98b0-13a7b0ecd302"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Wilfred49@yahoo.com", "Wilfred", "Rohan", "7345 Frami Plaza, Shawnabury, Guernsey", "1-365-426-5423", "vFg5MQGsjz" },
                    { new Guid("537f93ab-7a5c-4778-a380-62a8bb81ce56"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Gregg_Schneider@hotmail.com", "Gregg", "Schneider", "542 Bradtke Prairie, New Pearliehaven, Christmas Island", "1-429-719-1100 x287", "2XC0yZ78LK" },
                    { new Guid("5476c206-da99-4d4c-b61a-e475319e3ce1"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Jesus_Hauck@yahoo.com", "Jesus", "Hauck", "74514 Jayson Haven, Lake Casandramouth, Western Sahara", "944-686-6299 x18185", "qhYOxasQ58" },
                    { new Guid("55dc68e1-ab5f-4bfa-a8ab-d44e38c8b8e3"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Alexandra39@yahoo.com", "Alexandra", "Greenfelder", "75080 Adalberto Ports, Parisianstad, Christmas Island", "1-311-497-3897", "s3jsExWIk1" },
                    { new Guid("56bb608f-8545-4c0e-b689-ba082235dc5e"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Winston_Hodkiewicz70@yahoo.com", "Winston", "Hodkiewicz", "3823 Thiel Plains, Port Roxanemouth, British Indian Ocean Territory (Chagos Archipelago)", "334.657.2936 x5599", "Q6tws4hncw" },
                    { new Guid("57af9f2d-8650-433e-af34-c03e22d0dd4a"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Terry_Hansen50@hotmail.com", "Terry", "Hansen", "98328 Price Pike, Skilesport, Kenya", "1-333-880-9794", "DVVTZMc9GF" },
                    { new Guid("583eb6b7-c59d-41ec-b8cc-0d5fcde31e2f"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Gerard50@gmail.com", "Gerard", "Hermiston", "5353 Nolan Common, Torphyport, Bolivia", "(497) 851-8566 x810", "RX5gLC5PN_" },
                    { new Guid("586b406c-b8c3-45ed-992c-01cec72cac5c"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Cathy79@gmail.com", "Cathy", "Kutch", "396 Earlene Mountains, Ebertside, Kyrgyz Republic", "725.621.2524 x524", "WPZGKtmrTa" },
                    { new Guid("5f0e6e03-694d-4938-922c-e19ececcf76e"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Hector.Mosciski@yahoo.com", "Hector", "Mosciski", "67228 Jacobson Courts, Prohaskatown, Tonga", "1-802-288-4268 x43747", "R4baEyMX8Z" },
                    { new Guid("5f9de62e-1f4c-41f4-91cb-75a676749727"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Josefina_Stroman28@gmail.com", "Josefina", "Stroman", "58286 Sarina Drive, Guillermohaven, Burkina Faso", "(852) 356-7619 x0963", "dOxrPuQ5kk" },
                    { new Guid("5ff23ce9-bace-4866-a754-994b260812ac"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Olga_Davis96@yahoo.com", "Olga", "Davis", "791 Hegmann Greens, Nadiatown, Angola", "1-351-855-1791", "0hFL1rpJqc" },
                    { new Guid("6162b17c-4725-405a-b02e-e41552b2769c"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Virginia.Waters0@gmail.com", "Virginia", "Waters", "408 Lelah Burgs, Douglashaven, Hungary", "596.895.8106", "S6jd8G9dWP" },
                    { new Guid("6232335f-6daa-469b-a6c8-b10692cba144"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Andrew.Flatley@gmail.com", "Andrew", "Flatley", "284 Annabell Village, South Fermin, Lao People's Democratic Republic", "1-459-630-5935", "Ux2HNunPLS" },
                    { new Guid("66025ba2-5e1d-43a0-9f7c-4ab3866726e3"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Joey39@gmail.com", "Joey", "Dooley", "8041 Dicki Harbors, Narcisoport, Mongolia", "208.461.3247", "TONzpFDZNI" },
                    { new Guid("68f799fd-c4e0-4171-91b2-58ab775c3178"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Orlando_Kling@yahoo.com", "Orlando", "Kling", "763 Padberg Road, VonRuedenville, Tokelau", "1-703-508-8254 x50376", "AePdyMS7k_" },
                    { new Guid("6a4e1220-aa53-4c8c-9d12-0c88e4de7c00"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Vicky.Buckridge@hotmail.com", "Vicky", "Buckridge", "23466 Hans Island, South Greysontown, Niue", "(779) 282-3684", "pZYEI6MQlD" },
                    { new Guid("6af6c05a-e463-4351-a390-31fc044fe0aa"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Homer_Kuhic11@gmail.com", "Homer", "Kuhic", "320 Hermann Estate, South Myrticefort, Sierra Leone", "1-251-656-8883", "ADHgFvwiVC" },
                    { new Guid("6c4297f3-d4cb-4f50-846f-4b117ad7e025"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Alvin.Reynolds@yahoo.com", "Alvin", "Reynolds", "02744 Schmitt Dam, Zettastad, Philippines", "917.225.2743", "7Ab4ZM7_k8" },
                    { new Guid("6f9ce143-f9d3-4b0c-bf80-f18a27a3b0e0"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Ramiro.Skiles@yahoo.com", "Ramiro", "Skiles", "13230 Alfreda Turnpike, West Graysonmouth, Venezuela", "793-449-7217 x110", "7G_Uj7hg7Y" },
                    { new Guid("707df7bc-5a33-4c70-a631-8f987f70fac6"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Yvette.Welch71@hotmail.com", "Yvette", "Welch", "5639 Funk Flats, Rickyside, Iceland", "797.746.0425 x2145", "o0CunEW9li" },
                    { new Guid("7389f087-2a51-4083-addc-e6232900da90"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Ian.Yundt25@hotmail.com", "Ian", "Yundt", "70183 VonRueden Pike, East Karelleland, Tanzania", "701.781.8955 x0030", "wRzcRHUlLo" },
                    { new Guid("76624226-8fc7-4139-bf0f-50d8d90ef51e"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Marjorie18@gmail.com", "Marjorie", "Welch", "767 Keeley Bridge, North Jaquelin, Slovakia (Slovak Republic)", "1-484-380-5492 x50424", "rjoupW7PUF" },
                    { new Guid("7930f6fb-16f4-4a1e-b2e1-2dc9f69e161a"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Lloyd_Donnelly23@yahoo.com", "Lloyd", "Donnelly", "3671 Will Glen, Langmouth, Angola", "1-572-486-2588 x2727", "9dToJjn_Cp" },
                    { new Guid("7c1d7dd7-bd97-4f15-9076-09c9a820790c"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Samantha41@yahoo.com", "Samantha", "Russel", "59211 Barton Ridge, East Jessycashire, Macao", "(594) 639-3743 x308", "3O6DFcGbCb" },
                    { new Guid("7f8401d1-fadf-4177-a02b-0d7f2ae57e14"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Tamara41@yahoo.com", "Tamara", "Ziemann", "87518 Reva Prairie, Boscohaven, Canada", "(854) 578-0829", "bSBasL7xwa" },
                    { new Guid("803e2dcf-1974-4684-a6fe-a33d8e9f1882"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Ralph47@gmail.com", "Ralph", "Jast", "7481 Bins Plains, North Garretville, Botswana", "434-911-0619", "1qI7M4dOMx" },
                    { new Guid("803f42bd-db80-4e3c-afff-996b7fe40078"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "David.Mitchell@yahoo.com", "David", "Mitchell", "85142 Heller Branch, Gaylechester, Senegal", "1-285-313-9201 x63925", "WPe2osoBqx" },
                    { new Guid("88fb1dca-97fb-4f37-b467-725afb348cab"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Hilda1@hotmail.com", "Hilda", "Rogahn", "2721 Gislason Dale, Lourdesbury, Bhutan", "1-598-977-7723 x8749", "YFLSQLki9d" },
                    { new Guid("8b57eb47-d316-4e7b-9ae7-aa52d4b895a8"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Brad_Jenkins@gmail.com", "Brad", "Jenkins", "398 Gaylord Ridge, East Willyborough, Hungary", "(225) 571-7548 x4541", "PTndkrQpd2" },
                    { new Guid("8bff7413-3eca-4f5c-b49f-0cd9eed4d6ba"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Jose.Ondricka@gmail.com", "Jose", "Ondricka", "267 Rath Square, Lake Alda, Vanuatu", "202.560.6957", "s0P0H2Y43B" },
                    { new Guid("8e2d24a3-663f-4178-88cd-676135305c06"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Alicia5@yahoo.com", "Alicia", "Flatley", "4697 Balistreri Plain, West Rossie, Mozambique", "435-662-9192", "D8Tp7w2Wbj" },
                    { new Guid("8e61c79b-2dab-4787-8ad0-bf7cb391bf12"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Roberta63@gmail.com", "Roberta", "Waters", "88371 Bogan Mall, West Monique, Sao Tome and Principe", "556-250-5164 x293", "y6hvBsLtrK" },
                    { new Guid("8fae3d59-7b8f-44f6-91bf-a4c3e60309f4"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Paulette_Davis50@hotmail.com", "Paulette", "Davis", "68385 Zena Camp, Schoentown, Papua New Guinea", "(246) 407-2050", "T5ajrfw_fX" },
                    { new Guid("8fc4c12c-04b1-4268-93eb-c0830ad52cd6"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Jon_Kozey@hotmail.com", "Jon", "Kozey", "1340 Eloisa Ports, Collinsburgh, Oman", "785-536-3169 x388", "cpAE_cvhEU" },
                    { new Guid("9180e9ce-2642-40d2-9d7a-26fc7a7916fb"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Lori62@hotmail.com", "Lori", "Roob", "5101 Imani Highway, New Shanna, Eritrea", "717.396.5506 x05425", "wJVVk9_jFK" },
                    { new Guid("921e553d-1849-42c8-b9e9-77da0267865d"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Jimmie67@hotmail.com", "Jimmie", "Bogisich", "7462 Spencer Pines, North Mack, Tunisia", "868.388.0501 x872", "hjq3lMfulu" },
                    { new Guid("9243e212-6e20-4408-91f1-3067a721fc42"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Bernice99@gmail.com", "Bernice", "Marvin", "291 Jairo Pike, Breitenbergland, Denmark", "566-796-0197 x637", "_ZDAfU9rqC" },
                    { new Guid("932bb517-48be-48a0-b464-658dab3aa6f9"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Christine16@hotmail.com", "Christine", "Collier", "8821 Gutkowski Roads, North Nick, Norfolk Island", "399.358.7334", "eJiGEUOowe" },
                    { new Guid("93b885cd-41f6-4f7d-81b0-ac51dfe38e2f"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Candace89@yahoo.com", "Candace", "Murphy", "42215 Linda Manors, Harristown, Serbia", "1-879-825-5628", "3_nKeAo0xb" },
                    { new Guid("94ab4076-fcdd-4d72-885d-dfb2f60b9aa8"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Anna.OKon82@gmail.com", "Anna", "O'Kon", "9601 Kulas Burg, Lake Murphystad, United States of America", "391.930.7607 x135", "TD5BfgixIm" },
                    { new Guid("97019ad6-ba61-4d42-9488-e16f958aa2ab"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Lauren_Braun35@yahoo.com", "Lauren", "Braun", "72970 Buckridge Fall, Smithstad, Malawi", "947.903.3788", "cZy2KsGisM" },
                    { new Guid("9a189d5c-5efa-4678-b727-ceb6c3ab1c4c"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Bryant_McCullough15@hotmail.com", "Bryant", "McCullough", "554 Gerard Square, Johnsonhaven, Australia", "663.379.4718 x057", "Zes_WpZFq6" },
                    { new Guid("9ee6be16-6a72-4e2a-aee0-dc9312f93b30"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Jack_Franecki@hotmail.com", "Jack", "Franecki", "525 Rose Estate, West Ben, Germany", "339-372-0908", "DsjSTHnd9H" },
                    { new Guid("9f2b53d9-9f1e-4354-a772-840ca9d65603"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Garry52@yahoo.com", "Garry", "Kirlin", "379 Rowe Neck, Mayertport, Belgium", "749.329.7976 x9779", "6DzvvgbMAp" },
                    { new Guid("9f78286e-d7df-4142-ac80-38dd89f676bc"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Pablo.Kertzmann44@hotmail.com", "Pablo", "Kertzmann", "755 Smitham Track, South Orval, Cuba", "603.844.3809 x193", "jpJZHifTBK" },
                    { new Guid("a26d4d14-59df-45ec-8039-61eca222caf8"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Lance.Carroll@hotmail.com", "Lance", "Carroll", "2904 Carissa View, North Brady, Tuvalu", "1-926-295-2403 x7976", "QAcyF09aAR" },
                    { new Guid("a51b1bb8-9738-4d41-a4a8-302072dc87ed"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Douglas_Hammes@hotmail.com", "Douglas", "Hammes", "2129 Saige Tunnel, Reillyborough, Eritrea", "(597) 619-2767 x187", "JdRuQpzt6x" },
                    { new Guid("a5889484-2c88-4b70-940a-c94d71f5c8bc"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Robyn_Kirlin@yahoo.com", "Robyn", "Kirlin", "83236 Schowalter Road, Lunafort, Barbados", "848.444.1825 x261", "SakxFdW3tV" },
                    { new Guid("a5dd713f-1e4c-4969-a86d-e5f3e509ed77"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Ryan.Leffler@hotmail.com", "Ryan", "Leffler", "71717 Arnold Plaza, New Mathildemouth, Poland", "1-831-966-1338 x57644", "PzhdrofpPR" },
                    { new Guid("a9e72b06-dc1a-4f4b-933e-0a279ffb3217"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Ora9@hotmail.com", "Ora", "Hilpert", "53836 Leffler Mission, Lake Karianehaven, Martinique", "(805) 981-0779", "A9E3f7Aw8R" },
                    { new Guid("aa35d520-efba-4180-97d0-fa3a224969ca"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Matt_Schuppe52@hotmail.com", "Matt", "Schuppe", "4319 Julianne Path, Veumland, Micronesia", "(356) 346-1518", "Hr00e0xbWE" },
                    { new Guid("aa815804-2228-4886-ae88-9de51f31ec02"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Mario30@gmail.com", "Mario", "Rice", "434 Rempel Row, Lake Madysonberg, Antarctica (the territory South of 60 deg S)", "965-578-8991 x84052", "MQ4PIwWjYB" },
                    { new Guid("abd39d9c-de24-40b9-8bc5-d68acab4ad3f"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Jeff66@gmail.com", "Jeff", "Harber", "110 Abner Ways, Kaitlinside, Ireland", "(966) 719-4264", "1UMraqiEdz" },
                    { new Guid("ae676fae-9528-4b46-8ee7-de39c56d03a1"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Misty.Grant82@gmail.com", "Misty", "Grant", "1990 Roob Village, North Eulah, British Indian Ocean Territory (Chagos Archipelago)", "417-830-0622 x727", "4ojt8dTi4I" },
                    { new Guid("aea31779-a672-439b-b1d7-a492c5e0fa9d"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Kelly8@yahoo.com", "Kelly", "Hammes", "7301 Zemlak Wall, Port Einar, Turks and Caicos Islands", "(459) 976-8842 x33156", "SQr0DHJlD1" },
                    { new Guid("b108ffef-8062-4546-8382-3f549ff32753"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Isabel11@yahoo.com", "Isabel", "Schaefer", "371 Shanny Cove, Lake Liam, Venezuela", "852-625-8317 x5919", "4FNePt1oJD" },
                    { new Guid("b232758e-b155-48c4-aff8-8a30c2927278"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Derrick33@yahoo.com", "Derrick", "Davis", "747 Hyman Locks, West Edmundville, Cote d'Ivoire", "1-445-938-0451 x24552", "x_i2SGDfLy" },
                    { new Guid("b4660ddc-79fd-4295-b11c-4f433a6e86e7"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Tonya_Jenkins32@hotmail.com", "Tonya", "Jenkins", "18837 Iva Hill, Port Marlon, El Salvador", "797.432.8589 x639", "7oCdX8tDNI" },
                    { new Guid("b50abba8-b097-4ca0-9d89-33a86922f786"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Richard.Mohr@yahoo.com", "Richard", "Mohr", "35295 Jewel Causeway, Toybury, Togo", "508.490.6976 x7764", "jjLWFIFE45" },
                    { new Guid("b5135f8f-5515-4609-8e9e-80bbda32ce05"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Willie_Bartell3@gmail.com", "Willie", "Bartell", "629 Gus Hills, Port Kyleestad, Cape Verde", "672-276-3251 x696", "0W_IOc4Pmc" },
                    { new Guid("b55ee717-026c-4d31-ab0c-be780183b66c"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Pete.Okuneva88@yahoo.com", "Pete", "Okuneva", "2977 Pascale Course, New Adam, Turks and Caicos Islands", "454.887.5127", "K7b2Xtvqoj" },
                    { new Guid("b5cbf1ea-7aaf-4719-8f8d-3c7ceec47ffa"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Donna.Lesch86@yahoo.com", "Donna", "Lesch", "99367 Waters Plaza, East Enoch, Luxembourg", "1-873-389-1923", "MUAVyY8N8y" },
                    { new Guid("b5ee6f24-919e-490f-a2b7-ec8f75916aac"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Tracey_Huel96@hotmail.com", "Tracey", "Huel", "25212 Nader Fields, East Bennieside, Singapore", "1-300-832-0159 x2587", "nmgg_eGvo9" },
                    { new Guid("b66c059a-b958-42c4-97bc-f193ac9a9f1b"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Ronald85@hotmail.com", "Ronald", "Tillman", "595 Krajcik Fork, Mullerfort, China", "503.994.3365", "aSzkPpZjkK" },
                    { new Guid("b6b1a845-f510-4556-b5ab-6c2470a4dfc6"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Sherri_Macejkovic@yahoo.com", "Sherri", "Macejkovic", "7410 Ila Stravenue, New Paige, Bhutan", "915-744-0459 x281", "BFXmetkwRm" },
                    { new Guid("bf88ea30-999c-497c-ae47-152eb5815823"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Alma.Franecki@hotmail.com", "Alma", "Franecki", "261 Dorcas Forks, South Rodger, Gabon", "1-974-458-5634", "h0rz3ZqVLa" },
                    { new Guid("bfe2237a-6663-4a5e-8c2b-2f0097ed7d10"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Ronald.Labadie@gmail.com", "Ronald", "Labadie", "198 Mante Drive, Saulhaven, Peru", "294-707-5224 x794", "AgdnWOvk5x" },
                    { new Guid("c06f2470-44a2-46ad-8382-99d9086f8736"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Lois_Larkin@gmail.com", "Lois", "Larkin", "18464 Alana Junction, Flatleychester, Holy See (Vatican City State)", "719-272-0774", "E8tK7pLdR0" },
                    { new Guid("c2e3edf3-214d-4790-a7bf-031a1508d397"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Shannon_Borer@yahoo.com", "Shannon", "Borer", "653 Freida Islands, Ernestinefort, Montenegro", "(213) 623-1927 x50496", "H48El0c5HW" },
                    { new Guid("c376c652-e4ab-48c6-b50d-a387c4124336"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Phil_Schimmel@hotmail.com", "Phil", "Schimmel", "7933 Lizeth Tunnel, West Rettaburgh, Egypt", "(768) 442-3451 x8998", "2UKZrqtknF" },
                    { new Guid("c6215716-e6e7-4d50-bf8e-312aa965519e"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Keith.Brekke76@hotmail.com", "Keith", "Brekke", "197 Waters Valleys, Marvinstad, Bulgaria", "1-757-453-0512", "HMwXqLYode" },
                    { new Guid("c6848c66-e69c-4d6b-a8a2-d5a26cefa3fd"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Leonard.Balistreri8@gmail.com", "Leonard", "Balistreri", "4199 Durward Mountains, Lake Norbert, South Georgia and the South Sandwich Islands", "597.788.3865", "yrJGIUUO6H" },
                    { new Guid("c6d7024e-d874-4783-a648-80d2c59aa676"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Marsha.Gottlieb@yahoo.com", "Marsha", "Gottlieb", "488 Lincoln Manor, Rogahntown, Panama", "336.496.1634 x8109", "NVecM8pDh9" },
                    { new Guid("c76ec17f-285e-48ad-965a-fac02e92cffc"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Darren.Gutkowski@gmail.com", "Darren", "Gutkowski", "5992 Kirlin Springs, Keeleyborough, Samoa", "1-721-882-6870 x18345", "SJfF1Qdy90" },
                    { new Guid("c87acda4-6037-4bf9-a557-99793055da1f"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Ashley_Mueller@hotmail.com", "Ashley", "Mueller", "56412 Ella Field, Alexysville, Philippines", "(288) 615-4006 x146", "FwcuAeTzv0" },
                    { new Guid("c9b256d4-f79c-4595-b32b-2dd02a6252ce"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Barry80@yahoo.com", "Barry", "Heller", "0269 Aida Crossing, West Estrellafort, Antigua and Barbuda", "1-724-208-2931 x94470", "BueGczJYqv" },
                    { new Guid("cbddc286-db78-4740-bee9-d7f7b44dab5e"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Rachael97@gmail.com", "Rachael", "Marvin", "310 Frederic Gardens, Binsland, Equatorial Guinea", "492.747.4181 x440", "LsITK_QTzm" },
                    { new Guid("ccb81ce4-86b9-4ede-bb69-20ed9f6fd3a3"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Robyn.Muller@gmail.com", "Robyn", "Muller", "672 Schuster Meadow, Langmouth, Benin", "1-239-837-3736 x650", "Z2BTrLuLV5" },
                    { new Guid("cd190636-8add-4c62-8d0c-d3aefe641d24"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Estelle_Renner@gmail.com", "Estelle", "Renner", "38994 Hickle Streets, Lake Camron, Norway", "(775) 273-0323", "ip142vcjci" },
                    { new Guid("d12d3af8-1577-4ff0-9381-dc7c48a2acb3"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Michael96@gmail.com", "Michael", "Fritsch", "6122 Craig Ports, East Clifford, Cape Verde", "606-728-6142 x091", "T6pEGOsqhu" },
                    { new Guid("d17e92b8-d4f4-4448-b440-e0b1367874ce"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Kristie71@hotmail.com", "Kristie", "Kilback", "99651 Quinton Divide, Orinburgh, American Samoa", "1-793-761-4696 x524", "3v2508Vyev" },
                    { new Guid("d261f3a6-8745-4e6d-a12a-646079fbbc5f"), new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Julian.Kassulke60@hotmail.com", "Julian", "Kassulke", "6075 Jones Lock, Klockochester, San Marino", "254.683.9583", "vJvBOm5k2B" },
                    { new Guid("d5c4de07-5e62-490d-9617-aca0c24d1411"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Brent17@yahoo.com", "Brent", "Feest", "9291 Jakubowski Crescent, South June, Haiti", "(563) 806-5424", "J2nMTPZYdn" },
                    { new Guid("d666e161-6117-4444-9391-ee7ae23aa630"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Billy70@hotmail.com", "Billy", "Fahey", "400 Kay Valleys, Kohlerside, Andorra", "536-876-7962 x92971", "ELdBa66zpg" },
                    { new Guid("d7c16087-8957-49af-a0fd-a83707a0913d"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Mathew.Swaniawski@gmail.com", "Mathew", "Swaniawski", "1140 Noah Islands, Strackeview, Congo", "(357) 544-1756", "2vt6U1o8As" },
                    { new Guid("d7f30187-e8b5-4e21-b73f-f62ac2bf48f3"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Jeremy46@hotmail.com", "Jeremy", "Satterfield", "523 Oleta Bypass, Beattyborough, Jersey", "1-680-726-3031 x6987", "E17lSD0xZ_" },
                    { new Guid("d88a187e-0b1b-4828-8974-91e511eaa612"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Clyde87@yahoo.com", "Clyde", "Stark", "0286 Deckow Pike, Blickton, Australia", "(777) 717-5610 x7156", "9VbtP7ISkf" },
                    { new Guid("da1129dc-765a-4bb9-95f1-950f1f396407"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Karl_Howe0@yahoo.com", "Karl", "Howe", "2357 Spencer Rapids, South Geneside, Vanuatu", "(775) 673-3696", "4fPVyjDEAE" },
                    { new Guid("da87360d-355e-4e1f-a7ff-e1f7aa0e7067"), new Guid("cb0b747d-72e3-45be-a7b2-80e76ad2532d"), "Blake85@hotmail.com", "Blake", "Denesik", "423 Ortiz Plaza, Mayerbury, Cyprus", "(829) 501-2227 x853", "HgsJUuggYS" },
                    { new Guid("ddbba9cc-ce74-4d29-afd6-af285f373ca4"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Felipe29@hotmail.com", "Felipe", "Stanton", "01689 McGlynn Road, Lake Rebeca, United States Minor Outlying Islands", "1-649-778-3098", "rSHUARjkqY" },
                    { new Guid("ddbc07b9-47b0-470d-b4c7-2e82baf63637"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Daryl_Bernhard53@gmail.com", "Daryl", "Bernhard", "679 Mia Pine, East Robbie, Paraguay", "1-748-937-9284", "0hl_981XN3" },
                    { new Guid("de9a72d9-5628-42ba-af7a-7343d8b1f78b"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Janet37@hotmail.com", "Janet", "Monahan", "2833 Goldner Flat, Angusfort, Ghana", "547.332.7387 x0045", "mlVMMBaKKP" },
                    { new Guid("e0a23319-2076-4146-b135-97efe97d3822"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Elijah26@hotmail.com", "Elijah", "Beier", "388 Pagac Loop, Leslymouth, Tokelau", "(835) 638-7782 x26056", "31r0y5Fmh8" },
                    { new Guid("e4d2c142-b233-4f68-b8c6-e95ad515c02a"), new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Archie89@yahoo.com", "Archie", "Pfeffer", "0323 Dooley Village, Daphnemouth, Cambodia", "998.512.8886 x984", "DF7CJFcmek" },
                    { new Guid("e72438e7-57e8-4a73-a775-c52ebe02ab2a"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Perry.McKenzie30@hotmail.com", "Perry", "McKenzie", "01902 Golda Pine, East Dessie, Mayotte", "674.311.4678", "xMU5fLxzb7" },
                    { new Guid("ea094922-bcd2-4538-93ff-8fead6e4c6ed"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Leslie.Fahey@gmail.com", "Leslie", "Fahey", "872 Johnston Knoll, Amaliaview, Jamaica", "996.810.0532", "bzYeOir9uH" },
                    { new Guid("ec796d31-ed2f-4566-b379-7ae45962abb0"), new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Alexis75@yahoo.com", "Alexis", "Farrell", "663 Goyette Vista, Port Orrinfort, Serbia", "269-276-2435", "0TI9fdWntk" },
                    { new Guid("edf04808-ef41-48ee-8af2-77895bea0c02"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Colin_McGlynn@gmail.com", "Colin", "McGlynn", "7574 Jaylon Tunnel, Breitenbergburgh, Macedonia", "1-488-595-3607", "x4A_jhz1wz" },
                    { new Guid("f0675e95-444c-4467-8f13-f2dcbdbf563c"), new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Walter_Robel1@yahoo.com", "Walter", "Robel", "92620 Amparo Ridges, Emeraldhaven, Guinea", "929.715.4995 x82851", "pjdSRs8x2u" },
                    { new Guid("f1faf03d-b262-44b9-8421-fd9b2f4f7e51"), new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Victor9@yahoo.com", "Victor", "Mohr", "953 Janessa Isle, Denesikville, Poland", "(981) 244-4088 x36134", "Sj3hqr7Z1L" },
                    { new Guid("f3c4afe1-2f9b-49b8-9f52-7af4f1cf9c8a"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Adam_Stokes84@yahoo.com", "Adam", "Stokes", "29105 Feil Circles, North Beverlymouth, Malta", "660-711-2418", "o537v1OH0t" },
                    { new Guid("f3d20b6a-b3d2-4181-b027-bd8604717f39"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Jesse14@gmail.com", "Jesse", "Bins", "82095 Barton Hill, Joshmouth, Sri Lanka", "715.591.6414", "CgUo76DBdm" },
                    { new Guid("f6549bbc-3e1f-4da1-a512-4e55dfa3c219"), new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Theresa.Ward45@hotmail.com", "Theresa", "Ward", "029 Martina Avenue, Lake Raul, Falkland Islands (Malvinas)", "(987) 311-4225 x069", "gvub0xdLgW" },
                    { new Guid("f702b2c8-5ec5-4a7f-9cfa-5e737bc4e553"), new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Antonia_Robel43@gmail.com", "Antonia", "Robel", "55218 Larissa Fields, Blakeland, Thailand", "653.732.7753 x1426", "qSn6aWPQE0" },
                    { new Guid("f85c3a82-86d3-4348-9b37-0eb6f7dcb0d6"), new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Becky95@gmail.com", "Becky", "Nader", "36312 Myah Park, Bartshire, Estonia", "639.549.8995", "MuUqXChmrh" },
                    { new Guid("ff77d705-82e8-4672-b9fb-e356f3583d01"), new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Christy_Conn53@hotmail.com", "Christy", "Conn", "1500 Maggie Hills, Port Bellmouth, Sao Tome and Principe", "(407) 505-9265", "hM2utENB1N" }
                });

            migrationBuilder.InsertData(
                table: "Distributors-table",
                columns: new[] { "Id", "Address", "CountriesId", "Description", "Email", "Title" },
                values: new object[,]
                {
                    { new Guid("1239c559-8a8f-4a1b-9578-6b6d80c79c37"), "65712 Sasha Islands, New Adalineland, Tonga", new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Centralized transitional knowledge base", "GusikowskiGroup.Green9@yahoo.com", "Gusikowski Group" },
                    { new Guid("1526a9db-8ea3-4707-8ded-748dd9fdc05f"), "279 Solon Corners, Wilkinsonport, Pitcairn Islands", new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Multi-channelled exuding challenge", "CroninLLC33@hotmail.com", "Cronin LLC" },
                    { new Guid("1a3e4b92-e002-4e18-9318-104664eb404b"), "73504 Koch Common, Lake Aliyah, French Guiana", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Diverse actuating artificial intelligence", "GorczanyHermanandHermiston_Walter@gmail.com", "Gorczany, Herman and Hermiston" },
                    { new Guid("1bdcbe99-305c-419d-8749-58d3b715cc85"), "7950 Freeman Common, Runolfsdottirland, Philippines", new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Seamless zero administration array", "CummerataRunolfssonandHarber33@gmail.com", "Cummerata, Runolfsson and Harber" },
                    { new Guid("1f2c0a5c-8dab-4ee5-a5e8-86a6f9ba1d5a"), "326 Rahsaan Pines, Gretafort, Nicaragua", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Digitized motivating monitoring", "HermannInc_Boyer@yahoo.com", "Hermann Inc" },
                    { new Guid("21933bcd-605c-4943-bdc0-e77747e908e7"), "40589 Noemy Drive, Myrafort, Myanmar", new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Phased dedicated moderator", "WardandSons41@gmail.com", "Ward and Sons" },
                    { new Guid("234baea2-24f9-4b00-9305-cfaabe92292a"), "95045 Hahn Curve, Port Bethborough, Slovakia (Slovak Republic)", new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Virtual 24 hour model", "KuhlmanLLC_Ankunding@hotmail.com", "Kuhlman LLC" },
                    { new Guid("23934669-4717-4f0a-8d18-0b8eb3b5fb17"), "22143 Hudson Village, West Issac, Eritrea", new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Organized human-resource contingency", "Brown-Mayer14@yahoo.com", "Brown - Mayer" },
                    { new Guid("24c575d9-80ad-4922-b6d8-1b4cea521a71"), "7054 Cole Mountains, South Abdullah, Faroe Islands", new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Synergized next generation workforce", "LarkinGroup.Marquardt68@yahoo.com", "Larkin Group" },
                    { new Guid("28f20fcc-ce74-43dc-aab6-303d43fd3157"), "657 Russell Loop, Titomouth, Botswana", new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Multi-layered reciprocal access", "WymanCronaandKonopelski.Predovic@gmail.com", "Wyman, Crona and Konopelski" },
                    { new Guid("347b3f22-ff2f-44c6-a8c8-7129f6ec42ab"), "398 Bradly Estates, Eladioland, Kyrgyz Republic", new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Cloned radical interface", "MillerandSons.Paucek58@hotmail.com", "Miller and Sons" },
                    { new Guid("3d2b445e-d9f0-4d4b-8141-4dff289935af"), "84900 Runolfsdottir Plaza, Bernhardport, Saint Lucia", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Proactive analyzing projection", "Boehm-Rowe_Metz@gmail.com", "Boehm - Rowe" },
                    { new Guid("42af2626-7306-44f1-a318-34135472c6b3"), "378 Ernestina Harbors, Frankton, Macao", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Digitized optimizing conglomeration", "ShanahanInc50@gmail.com", "Shanahan Inc" },
                    { new Guid("475c9ce1-950b-4c91-9cc4-d8625c7cb6c9"), "108 Desiree Mountain, Destanyborough, Holy See (Vatican City State)", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Inverse asynchronous data-warehouse", "Larson-Will_Berge@yahoo.com", "Larson - Will" },
                    { new Guid("5b0c6d03-2241-4284-b615-13889fa7b61c"), "6999 Hayes Valley, Dibbertland, Vietnam", new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Open-architected impactful parallelism", "OrtizGrahamandWolf_Strosin18@gmail.com", "Ortiz, Graham and Wolf" },
                    { new Guid("5de5e535-40e8-4af5-977a-367a31d75fbd"), "3009 Yundt Haven, Roscoeland, Niger", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Multi-channelled hybrid throughput", "KundeGroup_Considine17@hotmail.com", "Kunde Group" },
                    { new Guid("5edf465d-646f-4fb5-a51d-bfb1c226d31d"), "757 Wisozk Cape, South Gianni, Czech Republic", new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Inverse 3rd generation application", "Weimann-Abbott.Tremblay28@hotmail.com", "Weimann - Abbott" },
                    { new Guid("60f23c46-a5dd-4c89-bd49-d7d3d5e16844"), "912 Gleason Orchard, Mitchellton, Israel", new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Total solution-oriented strategy", "OConner-Paucek81@hotmail.com", "O'Conner - Paucek" },
                    { new Guid("66c28f02-f224-47e3-8f4f-af589976b1d2"), "726 DuBuque Haven, Herzogbury, Malawi", new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Optional contextually-based artificial intelligence", "NikolausLLC.Klocko@hotmail.com", "Nikolaus LLC" },
                    { new Guid("73fb5cff-6822-4d65-b65a-71d04477f4dc"), "5814 Justice Parks, Abigailmouth, Suriname", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "De-engineered even-keeled utilisation", "StokesBeierandStokes17@hotmail.com", "Stokes, Beier and Stokes" },
                    { new Guid("7e3b1e4e-f4ed-4d75-b37a-e9b3511352ee"), "11945 Ashton Stream, West Myrticebury, Sao Tome and Principe", new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Operative directional hardware", "KundeRosenbaumandArmstrong25@hotmail.com", "Kunde, Rosenbaum and Armstrong" },
                    { new Guid("7fd3a976-f8dc-4212-8191-ceda65a49842"), "451 Harris Neck, Wilkinsonside, Slovenia", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Implemented neutral service-desk", "MedhurstInc52@hotmail.com", "Medhurst Inc" },
                    { new Guid("8197dbf3-9a08-4791-b25e-b3cd32aadc10"), "25859 Bashirian Squares, New Tierraburgh, Timor-Leste", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Exclusive asynchronous moratorium", "Wiza-Walker85@yahoo.com", "Wiza - Walker" },
                    { new Guid("84b17653-587f-4e78-b4b6-e6dd6db10f76"), "327 Beahan Squares, New Carolyn, Czech Republic", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Secured human-resource complexity", "BrownandSons_Carroll@yahoo.com", "Brown and Sons" },
                    { new Guid("87908248-3907-4a5c-8164-0dbdf700f602"), "5100 Myrl Parks, Bartellmouth, Lesotho", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Up-sized uniform hierarchy", "ZulaufSchroederandOrtiz83@gmail.com", "Zulauf, Schroeder and Ortiz" },
                    { new Guid("89be5d2f-0297-45cf-8791-3b2ac25d2599"), "24270 O'Kon Shoal, Abernathyborough, Christmas Island", new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Mandatory scalable paradigm", "Abshire-Ullrich21@gmail.com", "Abshire - Ullrich" },
                    { new Guid("8b996e88-bc84-452a-83ba-b1cc46690ce3"), "9904 Marlen Forge, Lake Tiara, Madagascar", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Multi-lateral foreground product", "CollinsGroup30@yahoo.com", "Collins Group" },
                    { new Guid("9593a401-6cde-443a-afed-455fd8cfa645"), "23661 Reichert Highway, New Judsonmouth, Palau", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Sharable client-driven adapter", "KonopelskiConsidineandReinger48@gmail.com", "Konopelski, Considine and Reinger" },
                    { new Guid("a00be5f5-f54f-47f9-8bb2-a7f65456dca7"), "5818 Beatty Square, West Elijahfort, Barbados", new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Multi-tiered stable attitude", "KochGaylordandBashirian52@yahoo.com", "Koch, Gaylord and Bashirian" },
                    { new Guid("a9eb2afc-8940-44fd-a308-33aa9f227860"), "43439 Kacey Cliffs, Osbaldomouth, Ukraine", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Total contextually-based flexibility", "DuBuqueConsidineandKling89@yahoo.com", "DuBuque, Considine and Kling" },
                    { new Guid("ad375252-8bf0-4c03-9cc1-eae67bcd407c"), "42946 Vandervort Inlet, Erlingtown, Eritrea", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Open-source asymmetric benchmark", "SipesBoehmandLubowitz.Brown@hotmail.com", "Sipes, Boehm and Lubowitz" },
                    { new Guid("adf10cf7-4322-4e42-8e35-b0b48462263c"), "0477 Osinski Points, Ferryview, Croatia", new Guid("67c6e08a-879e-4ee4-b7a9-46e40b740e2f"), "Re-engineered bi-directional budgetary management", "Kunde-Bartell.Legros91@yahoo.com", "Kunde - Bartell" },
                    { new Guid("b62b636d-ee02-483c-8e5b-c989fab52cef"), "8538 Kessler Drives, East Royal, French Southern Territories", new Guid("2ca99643-5564-466a-aea6-5384f8c8fd43"), "Multi-channelled systematic policy", "Hammes-Bashirian_Flatley73@gmail.com", "Hammes - Bashirian" },
                    { new Guid("bcc55425-5c68-4337-9c70-6869989eb8ef"), "975 Eileen Ville, East Hailie, Finland", new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Switchable empowering encryption", "PriceKonopelskiandPagac_Kassulke@yahoo.com", "Price, Konopelski and Pagac" },
                    { new Guid("bec86e3e-b958-4f50-af57-901aaa1cc115"), "57945 Williamson Light, North Bruceton, Afghanistan", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Total 3rd generation system engine", "SauerKautzerandSchumm.Lebsack@yahoo.com", "Sauer, Kautzer and Schumm" },
                    { new Guid("c1a6f047-7cad-46eb-b9ff-9d8af5217ee9"), "0576 Von Motorway, Juliehaven, Saint Lucia", new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Pre-emptive tertiary service-desk", "EmardHagenesandWillms_Jacobson86@yahoo.com", "Emard, Hagenes and Willms" },
                    { new Guid("c2c86c5c-7a75-499f-88aa-fcc412277d44"), "099 Block Springs, West Heber, Ukraine", new Guid("2f2e421e-4283-456e-90db-4782d1e7c7d4"), "Assimilated motivating conglomeration", "MrazGroup_Pollich29@hotmail.com", "Mraz Group" },
                    { new Guid("c4d7da1a-6305-4642-b435-be08b7d9a515"), "073 Lockman Square, Watsicaview, Solomon Islands", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Down-sized real-time frame", "GoyetteandSons_Keebler@hotmail.com", "Goyette and Sons" },
                    { new Guid("c68668d1-c90a-4b25-a35d-f934089ad3cf"), "2280 Mikayla Expressway, South Denisside, Belarus", new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Implemented logistical system engine", "Hagenes-Runolfsson.Crist@gmail.com", "Hagenes - Runolfsson" },
                    { new Guid("c77566b5-b68a-46cb-b3d6-1ba82267f7f5"), "83271 Haag Club, West Orlando, Timor-Leste", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Grass-roots dedicated access", "LubowitzMedhurstandStokes.Reilly@hotmail.com", "Lubowitz, Medhurst and Stokes" },
                    { new Guid("c8d51ccc-8724-4b6c-9118-3d401a1c59a3"), "806 Schowalter Lights, Clarissatown, Bolivia", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Enterprise-wide zero tolerance open architecture", "KassulkeKubandRobel.Deckow@hotmail.com", "Kassulke, Kub and Robel" },
                    { new Guid("d5119a36-cb81-43cc-9e90-b421bae7463d"), "42664 Mills Parks, Hanehaven, San Marino", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Fully-configurable holistic toolset", "HirtheGroup35@gmail.com", "Hirthe Group" },
                    { new Guid("d8527914-a68d-410c-bc7f-f0b8cf5f937b"), "3167 Maggio Prairie, Lake Adriennebury, Puerto Rico", new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Devolved content-based contingency", "GreenholtBauchandSmith.OReilly92@yahoo.com", "Greenholt, Bauch and Smith" },
                    { new Guid("e7dd837a-1310-4369-941d-ab61f8cc9cdb"), "23805 Kris Trail, Larsonhaven, Uganda", new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Public-key asynchronous analyzer", "Dicki-Keebler.Harvey@hotmail.com", "Dicki - Keebler" },
                    { new Guid("e99fc943-f443-4b04-b88b-c4e42f4ff236"), "9705 Nona Mill, West Bertram, Guam", new Guid("69d2663c-ab8c-4314-b43c-373e534f21ca"), "Self-enabling zero defect superstructure", "VolkmanGroup21@hotmail.com", "Volkman Group" },
                    { new Guid("f0ca2023-e1d5-4635-942c-3e64003ba014"), "59644 Hodkiewicz Plaza, Lake Clairland, Egypt", new Guid("d3090076-bcc0-4dd0-b2d6-ff344efcab69"), "Customizable interactive middleware", "BeahanWintheiserandPrice.Stroman@yahoo.com", "Beahan, Wintheiser and Price" },
                    { new Guid("f39c1b2c-ddd4-44db-9d55-90a06dc2395a"), "8082 Johnston Mountain, South Sheila, Iceland", new Guid("ca73549f-4059-4224-908a-fdc0d8396e7a"), "Ergonomic global strategy", "FadelWindlerandKutch.Watsica@hotmail.com", "Fadel, Windler and Kutch" },
                    { new Guid("f4769467-4e8f-4ae1-9cac-5af43f57fab2"), "30695 Lubowitz View, Isomview, United States Minor Outlying Islands", new Guid("6bfcf215-c95d-434e-9d60-2be03d29c72d"), "Grass-roots global orchestration", "Stark-Breitenberg35@yahoo.com", "Stark - Breitenberg" },
                    { new Guid("fa53fe94-8ea6-4558-ab1a-04218bdbdfdf"), "239 Jamil Extensions, Lake Ozellafort, South Africa", new Guid("9a1068d1-5642-4f4c-8385-312e4d712448"), "Synergized non-volatile encoding", "StiedemannMuellerandLesch_Osinski53@yahoo.com", "Stiedemann, Mueller and Lesch" },
                    { new Guid("ff472272-37a3-47f3-9d57-672d245d051e"), "7589 Harold Turnpike, South Gretchen, Slovakia (Slovak Republic)", new Guid("6f57c76d-efef-4ea9-b021-86d6b34be7b8"), "Virtual background adapter", "FarrellInc.Ferry98@yahoo.com", "Farrell Inc" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries-table_Title",
                table: "Countries-table",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers-table_CountriesId",
                table: "Customers-table",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributors-table_CountriesId",
                table: "Distributors-table",
                column: "CountriesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers-table");

            migrationBuilder.DropTable(
                name: "Distributors-table");

            migrationBuilder.DropTable(
                name: "Countries-table");
        }
    }
}
