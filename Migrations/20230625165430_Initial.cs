using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("00afe744-458c-4eba-8d64-caad6772f50e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("00caf0a4-8012-4b60-97d9-2980c8854381"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0249c6fa-af09-4f9a-ba67-03b57c195dbd"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("043df866-51a0-42e1-8427-14a5ea69cfaa"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0b661bb9-ef64-4856-b39d-742660d36497"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0c7e0e03-47b1-47f8-912d-fa6f13c85e8c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1146f334-1956-4be4-a5b7-542b911b68a1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("147fef06-4efe-4ae3-bd0a-0fc232d81dd9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1d730f4e-70b3-4938-b9b8-ad8eba50f069"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1f9a2067-b3f0-4521-8454-282af11c2193"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("21f2f1ee-cee8-444d-95cd-c5721ce5bda1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("24f4e729-2e2a-4687-aa1e-770feb474760"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("263e6521-0e0d-4314-89b4-7a301b2139a6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("299573d6-a13f-47a3-859d-95545559a160"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2f8438fe-8db2-42db-b999-b41b0e3a2952"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("31786c5a-c79d-4037-b8b8-c318a7a50819"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("35d49030-52ea-4d94-95b0-45dbbb3a67f9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3651b3be-cb8a-4cd5-89c6-825da693769c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("387c0c53-ea3a-4724-8a0f-543895fcdeb3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("427ca2b9-ed72-4f63-8df5-44653308fea8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4cb71a8b-c2fa-44eb-8855-44751f563056"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("52bade64-2d79-4967-a666-3a425d2c6a97"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("564a24fa-a42d-4993-9d69-c3b01a183be9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5d618fc4-0fa9-4b82-8745-1a7b52ed9702"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5d87e023-578f-4b42-8cd6-7a96589bdbe0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5f2d4af3-c279-4069-8cb8-11aba5d70f5e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("62b29526-0262-4603-a695-574e736d0630"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("63532fd5-59cf-429a-8c5f-fb6fe8fe284d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6528b57e-6dd8-4b35-93dc-9ea6f16c785c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("696d3f24-c5c9-4363-a15e-9f1a12607e0d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7646e7c3-a14b-48f6-9fca-e962ab343207"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7a2d1846-a29f-4a52-9017-a5013097d15e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7b1c577c-b049-424f-a4a6-5c1b8757e8db"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7c2c0001-3dc2-4a97-ab5a-2baf98bbc83d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7d17c73c-dc9f-4c43-88f6-ed397aa564c7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("82275817-cbf1-4b38-a37e-332a6a7ef772"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("858612bd-20f4-4c42-a88a-ab4f705f31a8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("891c63f0-c0e9-44f6-96ed-01c8494aa27b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8c1de5bb-b047-4089-87e2-3a3633078333"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8d88f3ba-1533-4875-a882-5dfe3dddbe48"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("914e2a87-e2d9-4de9-aa9c-14b032c12b83"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9d1d01a4-b396-47c1-aa13-be2deddee168"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9e409e88-4831-4244-9081-f8863f49966e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a1f48068-ee56-4305-9f7c-7d59cb68e829"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a60f234d-2079-416c-9fcd-2ce1f8447116"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a6ebfea8-801a-443b-b8bd-763414b370f7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a7426aaf-7b25-431e-b488-9d54e5e7ed85"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a7f16c93-c67d-4ea8-9f2f-2fe32c851622"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("aed732b1-e34a-4a03-ac59-d09e09d061ad"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b40b123e-bea6-4d84-ae9d-2e2a8b595d08"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b70bbec4-02f0-401f-a39e-adeb5483b2ea"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bd394875-37fd-426e-80b9-f084f9db95da"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bed3ff7d-8a6c-4ae4-9931-ffa71c59c60e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c62df072-9f4a-43e5-bfe2-99f1f77605ea"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c96bb2ea-aab2-4def-8b4d-66834ac6b80c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c9a348d9-b5cf-473f-bcbd-6e4de8744ad3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ca7fc90c-d334-4471-855e-5e594e72ecb7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ce539ec8-f04a-43f1-a38b-03a3c7ff612a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cf73ad9a-73e6-4bb8-b1ee-7cad4d10655c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d13cff65-0fce-4f3b-b3e6-6147ef5870e3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d6a3012c-3fb2-409a-a0d2-9d5e6bd6ce38"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d9b41fd6-cfa7-4479-a964-eb44928ed038"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("dde14029-8183-4af8-bf20-f3c93eb9a592"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("de199f94-39e7-4e57-b9b7-a912925d7c44"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("df8454fe-b559-4f5c-88a2-8017e9568b2c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e2bd7495-4465-454a-adca-2994804c4566"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e7e13e4a-0bdc-46eb-b9e1-53607f524340"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e819bb87-f985-4e62-ba92-0f531cd77ddf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("eb90abef-1747-443c-82d1-2e2403b229a4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("eed2952b-a95b-47df-a45a-40419a6ee9de"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("eedf3a46-58b5-48bd-b939-ce27302f2896"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f2ebc54f-cc45-4c14-92e9-83b74ff68ac3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f6b16114-341e-4f44-bf69-51ea35b549e4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f8a66a17-1f0b-40bd-b1db-102dcf37275e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fb200add-93d1-4bed-b893-7a97789c2408"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fbb5139f-7431-4096-aa6f-000de968ed1d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("21b368d8-5d81-4187-8db4-ae9d757fe0f0"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3b92affc-555d-4d61-9816-9d941a0fc283"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3c17b418-53c4-458e-9a05-acbbd6a30b1b"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a59122a9-b48c-47f3-b154-94762edcad63"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("00d0324b-9380-4c28-8ebe-56a8a80d0e28"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("00ff5e0f-66e4-4d6a-9a17-922fd7ecf0f9"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("017dba00-6b20-4ffc-abe3-e92ed749ba18"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("01fee026-6cab-42ad-babf-e9580e1acd98"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("0340fb46-1d20-4df0-aa6c-6ac8aa52dbb7"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("049de238-2e50-4281-b314-b62b6970f103"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("08b99d17-52ea-4500-ba73-cae2cd6ea999"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("0a9456a8-5a16-43af-8dfe-0b4685c18cfa"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("0c65effc-881a-41dc-9e60-d607d3b6e2c0"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("10cef452-43c7-4c80-b510-51501dec2747"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("11835a41-ae96-4ed9-baeb-f83f68ceff15"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("11f4ad0c-dc38-4bd4-ba15-90d78be96a25"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("12cc4362-8da8-4135-a4d1-70d8267b3a48"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("155c6144-e37c-49b1-879f-08572890bf5f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("1bfc708e-6f7d-4a1d-a3a6-7609106c9be5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("1f8d1305-f037-4ab7-910e-596c72cb340d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("1fbbf324-4038-45ea-9e7a-b12fd588d6c1"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("27513822-e2b5-47cd-b89e-e7ad3ba9ec9f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("2cf94436-e83a-4c72-b357-edcd07df1ad3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("2ebebf57-8155-4cfe-8eac-79ec77f5162e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("32e35b91-b9e0-4a87-b245-1fe5e07bcaf6"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("33de3a14-994e-47b7-a2f3-596716d2900e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3457ca21-3b25-4370-9267-4643bb1e6379"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("355c55b5-7a63-4468-be16-ab40051577b7"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("380eb32f-de6a-4e5d-9bed-3d7166590fac"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3a4f03ac-d02e-4b50-aa5d-4dccf984798a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3afd80a6-2b85-4744-951d-84cf2cf98de9"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3b95aed6-50ea-49b8-ab54-c84cecf60f29"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3cb8ef58-a82d-4ca4-b256-90a89593c1df"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3e971b8b-2156-4ec7-8222-2299ee5b877d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3ed5d4f7-c91d-4a38-988f-780f26e2c022"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3edfddc2-5045-4a82-b164-1564b1293dcf"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("4418e218-6b41-4545-80ae-32dcd5db98e3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("47597535-7466-43e0-a9a2-c8b0ea859998"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("4c554212-9c88-48ba-b644-288090ac8dd0"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("522117eb-d7fc-4748-af95-8bcaeb872a05"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("522433de-d283-49c3-ac38-785c2dee2a3c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("548575ef-b532-4369-a9d4-d98fca5f72ce"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("54999c18-8496-45be-8bff-ac09446bad54"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("55d7853b-e470-4ee8-8749-187b3e9debf9"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("575a054d-9a36-45cc-ac92-9456750347ec"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("5bfefb98-0954-4615-8d9c-148b67b67c1a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("5c0ddfe5-5b89-4228-a3f1-ac4f6ccaf5a9"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("5c476589-b3b8-4f85-bd7f-b0ec1aba53d2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("5c73638c-3449-4a27-a364-bfb8081c61a3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("60f255fd-c754-4fcb-84ba-cc0816c4ce99"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("611e020b-6e2c-457f-b71c-24dcb1752b93"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("639ca831-7fc2-41fd-aecc-152e99321fc5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("704be42b-b5b7-425d-9a0c-d8f62b143320"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("71953bbd-f7cd-4b95-b304-846e32c32ab5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("74e4d85d-7ef5-4512-a14d-6883f46cf76d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("77bd2f6a-9d91-4458-a251-ca4bf739138e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("79eac3fd-ba7a-47d7-a88b-c0b667875f8e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7a3fa11a-b906-41c3-a8f2-a41e06407052"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7aab12d8-3ecf-4403-8aeb-0db913a94ee9"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7be57a17-b619-4c0c-8d47-f833aa795ad7"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7c8d8807-8bee-4825-90fe-47292292522a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7f41f47d-dc2b-437d-be95-e009e3405f62"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("802948e2-5448-462d-9ba4-b32ffd1f6e4e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("8581b22c-356c-4085-aea7-41cc0b150492"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("86d24e32-bab0-4801-a533-e85815ea9b5a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("8d7959ad-f24b-4238-b1e2-f88200206578"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("8fd5804e-831a-4fca-bd88-85284aef0cba"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("94b97ff0-23b7-4330-b3d9-67d302663e33"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9616b6d9-17ea-4ab2-ab87-18c33805af45"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("98ec4d0f-5f72-40ac-a92c-af842c5e2593"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9bf237e2-9390-4ce1-b434-896806ca4973"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9c274edc-7b8c-4ee3-973e-c7ea1aab500e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9cc64ddc-ea09-476f-aa44-1c7d0f813e28"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9d7feed2-cb9a-4dca-a355-2ed8cb4e86fe"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("a367b4ef-f9ff-4380-927e-dec8bfe75bba"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("a652ec16-8967-4ba3-9f07-728581d8950d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("af0c14b0-58c2-437e-bc75-d51fc1bb4cc4"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b1846a28-aa89-4728-a48d-df844a0f50d7"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b240b4c3-f6f0-4b74-a7ea-01798561989e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("bd43990f-5098-4350-9a58-9b1ccf4ae41b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("be16ee13-eb5a-43a3-a542-342a1f5a3481"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("bf04fabd-7a13-4411-906e-eaf3755c31df"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("bf65d04d-5608-4d20-8b8f-6961f25c1564"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("c767f10b-b69e-4a4a-8559-0fd08087038b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("cd879833-34be-4c12-ba0e-b489da46e9f2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d0b386f6-9ce7-4a04-bf93-ffc4190e2f2b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d27f3122-6bb6-49ff-b290-c467fceace84"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d3b4b2f1-906c-4cdf-bd16-cf47aff33125"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d3b57ba6-eb9c-4c64-b157-bb2116669a0f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d5638eac-301b-4d00-8a40-5c459ae334ec"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e06fb0e6-bfd4-4d01-a33d-036d79357215"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e184b81f-32cc-4062-9ca5-dc484f824ffd"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e2be4275-82fc-4f52-aea6-8d35dd28125e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e51462d1-1a10-4ebf-8e72-500b4ce62208"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e57fcc93-54f0-4ff5-b05a-4e7e0b7c4980"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("eabe1219-121b-4e92-9c38-3fa305ea1944"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("ed83175b-71c2-4678-bfe3-b370948a5b7e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("eeb14daf-4d19-4ac3-9d0c-abfe114eb2eb"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f2849a10-8d83-4a67-b95c-de41e4a312c4"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f6d3397f-7150-4714-bc09-b43152e9ec8a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f77c760b-03c6-4655-b131-3efbffb1cea0"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f863feed-dde7-494e-87d7-f3007fcf2250"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("fab1daab-d14b-472d-bbbe-5f1a21fde7ab"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("fb6257ae-4507-4f64-9711-44c50b32c467"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("0573d452-ad3f-4560-a570-943db74e05c8"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("0cf2573e-2ec9-4e9b-adf0-05a563be87ac"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1758b5f1-b9d0-40a5-bab8-fcf8ef7744ba"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("19572408-81c2-4c4f-949e-b3229b01ad69"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1980abbe-de67-47b4-9388-5124468bf770"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2a4049be-81c4-4880-ba9a-a02b7a83e9ae"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2e48a9e0-52ca-4e3f-92fe-b934e0dff950"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2f08c3ce-9027-47a9-a8c9-acb1022587e6"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2f635021-a2a9-4aa8-bb43-9eb086d9220c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("37353970-be3a-4d04-a899-b2f0c38785be"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("4d927529-1a47-4841-84ed-f99bdb13fc62"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("53ecda36-7c77-4ecb-8e36-77b2b95c4ede"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("7c592de5-1db0-4646-9bbb-567089c076f2"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("8092d9cf-232f-4f45-bf16-6a4bc7ec3222"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("955f1f5c-aa26-4100-85d8-9c85ea0133bc"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ac4e2ca8-0a2a-4716-b380-7d21c8d0c1c1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("bc45d69e-9afa-420e-92fb-d358177ee9a7"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c2400c3d-971c-434e-9c6d-6d478f801fbc"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c37a7bd1-de55-46e6-bb94-d46523ef0be7"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c4eab92a-1506-481a-a041-4ff0f6fbc5fe"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cc05aa98-2949-440f-88f1-5b74f40db9c2"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ccd8816a-872d-4f3f-b4b5-2ef813c1e4bd"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f0c9b2a6-ae8d-4e50-8c7d-6fcd2c735189"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f93623c2-5a9c-4136-b312-f140361d6165"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("011e24f2-3058-439f-b4f7-70a5918cb381"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("025747d0-8287-4d45-b442-7e4841a4bbf3"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("03b3c7c3-9e23-4ed6-9a48-8304b670e492"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("04f5b332-7f20-4436-952a-efc8c6d97284"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("078f99d3-63c6-44d9-87b5-55b463c59fdb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("09e7ed36-703c-4336-bceb-3d211d02f134"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0a4ff2b7-19fe-4291-b2b1-6c067f518f9e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0b19eec1-dda5-496e-bc78-bf7c1436eeb0"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0bb24393-0049-41e2-9fad-94655421be65"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0da687e9-2286-4f7f-8115-263fd4fdf186"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0eb55b9e-b53a-4ca2-93e2-ee41f0bc132d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0ee0a950-1d00-4069-9541-b5f306fe5d33"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0efaa2e4-a037-4939-93ab-f2b640a6ea20"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("10d53100-7187-4054-8d4a-b67410e40ec1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("113abef4-b418-40b5-ba58-968f3e553304"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("115a4361-118d-489c-974e-1afca5b62ea4"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("1b3a26b0-3bb4-49bd-bb9d-6b00072de41e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("201f66c2-8067-444c-8e3f-5fe2a2b85e94"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("203307a2-28ba-46e2-8dbc-ca7a0b4038a7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("231adb08-0cc1-4a68-a724-6e04a581f796"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2325450a-c626-4cd9-ba9c-e7e506c635a9"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("23efe030-4891-407b-9eb4-b09869cb7241"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2a4311c6-2954-426f-b6b2-d8245300f927"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2b72c616-fd48-4a6c-a9e8-1541688f7e2b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2c97a11e-d775-4966-8a67-92ca5a711033"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("30b768e2-efbf-4646-ad87-bc8d2b38ea80"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("35612296-def8-40b6-bf27-db025674945a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("381ff876-e48b-4b3f-9757-6b9b23c6a14d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3ac04c1e-aa6d-4f13-bafa-f516faab16a9"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3b3b1dea-7cd5-4f89-94ea-65c330e2935e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3d472569-5bfa-4e89-9d9e-20456788521b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3d95c322-742a-4b2b-8251-5fca6d806afb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3da2c62b-2d53-4261-8d9b-6441f57bf0d8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3e649e7b-e80f-4765-9668-6849067982a3"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3e774fbb-3384-4e55-bcd0-46cfce833247"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("41a628cc-d08e-4604-847a-584f5698c7b6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("44ac82aa-d0ba-44d5-8ed5-606ece7c9777"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("466ecdba-3d44-4268-a8fc-96c8cc9294ea"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("472e7d7c-aecf-48c1-9659-1a875ae89990"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("489009ed-53bc-4e31-aa96-77829a117d6a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("48aaf975-b044-4b13-9b86-d08409ae222d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5084894f-7835-4324-b245-f53859967db7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5119c26f-5e1d-47e1-8d56-81368a7506b0"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("523edd63-5fa1-48e2-989a-59b5df882264"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("53097637-8ee2-4d17-8634-bc8e326e119b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5406db09-c9e8-4c2a-9ed4-c7aed039e281"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("56f0a709-e278-4146-b95e-c3c0f03a55ff"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("589aa02c-6c0f-45a9-921e-c14a18bb9e01"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("59833ad6-5afd-4258-ae1e-18562dbc0df2"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5a3b875f-108f-4675-91d0-7c9edd8c5747"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5b84e6fe-1d62-45f4-877e-90e4c0f67594"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5c890d25-e7ed-4362-a3ca-a3daa26c9a1e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5e3b4dab-1251-4c83-abcf-ff066eea5402"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5ec49f0b-46a8-49a1-8e2a-d6fc3cbd8c1c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6018dc83-24f7-4b9a-903a-fd576d727feb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("64138782-47d3-48f1-83b3-db74905c4204"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("645f9357-83d6-49ef-ac7e-cd4fa9f1f137"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("64e75723-05d4-4d29-a797-743861d642ed"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("655c7137-8955-4e05-9d58-9289e1c33aa6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6569ea8f-ae60-4831-be0c-f8ea3691d062"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("68a87363-5814-4f4d-92df-be776b641d40"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("698ee203-f72d-48c8-be3a-d8ff0d0ce931"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6f4a3b7e-ecbf-4d86-aa6d-7a441cdfb121"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("70869ef6-e771-4039-8cfc-c65d44125e6f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("71efdcc1-0627-411d-b064-3dac242a20f8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7422d535-9b77-4fb5-9df9-691a213edde6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("77c985b9-01f3-4057-9f26-d95be8b229c6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("787a58b6-4001-41c1-97b6-8f7d180abb21"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7c913521-ef7e-479b-8d76-876f44b8ea74"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7d6aa886-61af-4a9d-ae7d-5c8ec344fe9f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7dd0a06b-d5fa-45f5-9a0b-cc381fe909f5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("882ed3f8-ecb5-4cda-8637-7c6a496aae52"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("89edb9b8-a5f7-43d6-89d3-c6e77fab375f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8af436f7-99c1-4140-bf12-9a74f8efcf18"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8cc94f03-e648-438f-b89e-5dd666cdb94a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8cf022c7-7dcf-49ac-bf49-723c9c9dd4f1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8f72c289-ef13-4d8d-b8e4-89bd8e1769e0"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8fb2102b-52e9-40b6-a368-ac6698d66b28"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("911316e9-0952-4a44-9e8f-551f1572304a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("94cc263e-1218-43ad-a87e-54c4d2ad9910"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("959b5573-82fa-4195-8e29-4f717c7b212c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("98424df2-a140-44b2-a25d-efbec814d74e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9bca6e61-eaea-4231-b1cb-c533c235fa28"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9c0d62cd-8694-4edb-ae96-4405dd4df113"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9e6e450a-0044-4126-9416-dadceb1b9654"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a2c6a6ff-5613-4ade-b35e-2a866697e24b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a60a383b-0c9d-4a25-95b4-817f3c304cb6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a71c3ad8-8ff9-44ca-9ade-e9a8b87c4afd"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a8bce10a-94b4-481f-967e-96560adea24f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a9c2052b-8f70-48a4-a1b7-2911ed331895"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("aa2d7f75-b468-42f8-b6fe-9d45bb811b10"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ae3765dd-2c6b-49d9-b4d0-4a738ff596d8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ae3d48e1-26a9-4edd-bbab-40c751cd0a52"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b1e1f7d2-994e-4dec-8962-95022ac027aa"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b1e62464-1f4c-4608-9a91-86f3d15814ea"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b520bad0-483a-4291-a896-d579abcc1292"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b66c35fb-295f-4a24-9b5f-5c50f4cc4a3c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b8b1d4f8-d8e7-44fe-ab80-d6224d9159b3"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("bd12a949-ca14-4bf0-8977-99cd05b8ac6e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("be0962a1-3dc5-457b-92cd-cc92eef2d3bb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("bf046f6e-bb7a-471a-a8f2-fd19b8f8d3fc"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c03daeac-333a-4538-a1e5-7997e4830eda"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c0ab37e0-fbdf-4290-b951-dcc23d15e2ab"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c352e9d7-21ab-410e-9680-ce78fbbfb320"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c445ce73-5fe5-452f-a681-9c02cfcdd92c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c52a5cc3-c567-4242-bc90-a4e7e970c1f1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c59f429d-2d83-4f7f-9511-d18d1fb53e95"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c6ad1f11-bc50-439a-beff-59f43629fb38"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c82717a3-881c-483a-98d9-44f695053395"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c82aa705-6918-4803-a5d7-310b5be0a54c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c844d53d-8146-4bc0-ab62-6978837ed480"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ca67107b-295d-4464-8348-0daf92ffbbe1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("cdd8ca45-cbe7-42f7-b518-ca7e26f9e655"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ce83d41a-b085-494c-b5cf-c93225033b19"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("cf22217b-e2c0-42b3-bf43-d381da260c4a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d2db96d5-49d9-485b-891f-557ac41b7c99"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d588b3ba-5cd9-463b-8bb4-faadc9cb89d5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d6c6a2ad-624d-4c88-aaaa-02be330972d8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d6f37c6a-f6d4-40dc-b355-0c4725b6c599"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d87310ff-4106-4052-bc75-40c473e0494d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d95ec1a9-c6d5-49f7-952d-bafe2286eda7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("da1f4bfd-3771-4a64-8485-c2148582e5d5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("dcb090b6-e188-4c97-b76f-c9fa8e96cc02"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("dda66805-6081-4f22-8c7f-f7452db20b22"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("de021198-2931-4726-9891-ad179efe0440"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("df66a8f9-6957-41d3-b9bd-0d14d9f301b2"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e0884e60-0677-4602-a6b3-6d36a28fc3f2"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e0cdbba3-e4a5-40a0-9e4d-226aa7ceec2f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e1890ad1-5411-4611-b326-e85c9c21fbf6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e18c6cfe-eba5-44b4-9ab7-418e85d8e15d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e27fdeea-a46a-4302-a83a-de373a79a8cf"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e2987795-efab-469c-a965-27e2009e9b9a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e6358d22-db2f-435b-9b33-36a81d6befa0"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e74914e1-2cc3-41e5-8ad0-2a3053f11acd"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e787e06d-dd56-45bc-b259-39787a21779d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e7e5c36f-ef17-497a-9d27-01cc07bd5a74"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e99c673d-08d3-43df-b127-643c819841c8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ea239104-9815-4ee2-8850-4e1b2a0d64fc"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("eae5559a-8558-42b4-8c52-8ae76eb133c5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("eb21fa3d-eb02-427d-ae6b-6b218482a815"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ebddd949-5585-4d53-9b27-df82d6ae4e4b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f0b6683d-aaa0-4199-92da-4d0f0c08946b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f5d59eb8-39bf-431b-8b94-3a2c9ae035ac"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f60765e0-ea59-4b59-9454-db080a7c22cd"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f8c9a304-ca98-460f-ba12-7414b7bcd54f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f94fbed3-718b-415f-9008-250f081f2308"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("fa435b9c-23ab-486d-b956-6a8e98549490"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("facd9efa-b434-4fb1-ae64-68e8c64e03e7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("fdba5093-f9ae-428c-bb0a-e202cb695f4f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("fdfaad4a-d454-494d-a4f5-49e6150cd0d5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("035f593d-eb78-4a43-a406-422e51fe284f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("17c89867-ed3a-40bd-aff0-8bc6085b0ee3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("36cf0e6a-a3f7-4284-9470-049c95e1a625"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a09a513b-cf49-41aa-843f-318aedab497a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b58906ae-aca7-4e79-9bfa-8b9fad43e555"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c0b3b1fa-4d7b-456b-a923-7ade7f99326f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e4b1dab0-0c3c-444d-b314-7f6f53d68516"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("01606516-fa32-46a7-b561-06a6f65f92b2"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("07bb97cd-a5bb-4b92-ae2d-3d579e646cd6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("085c9cd0-665b-4bbe-96a7-6f4ebfde37f5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0ed754ad-2c6a-4c74-9aac-1ab065f239f0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1087765e-6906-45f0-bb5b-6cb7b20b5bca"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("116c74c5-2362-47f9-a575-6a9c9d3bf2e5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("17a33985-357c-4698-b820-484f1e70cfd7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("182c27e0-53c2-441e-a462-3c1ec3bb848f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("18bfaa32-d8b4-4365-a901-bb8ba529a413"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1a2c4cf1-d146-462a-9c65-18557dfb88e2"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("22f4ed27-c370-4152-a1cb-f006125f1022"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2fb274aa-2957-4b67-9449-e7cd568f3348"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("30c19ca0-6608-4b58-8f4b-30bdcd6f4d25"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3187855d-deea-4786-8ad8-fed8b6d03306"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("33613afd-3879-4eec-a940-0134de6556d1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("344deb2d-d004-4398-b98f-03ac2c95831b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("373c10a4-7033-44a3-a7f1-53d29c301266"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("397980a4-17c5-49e7-854d-908397640c8d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3c2b0e85-8ec4-4c44-a9fa-108915ff6e95"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3c82604e-35c8-48cb-9cf5-3adf95688758"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3e1697cd-49a6-4971-8e04-8c8fb2202683"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3eb4da70-d071-4a2b-b28a-ec81b5b5a7e9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("443dc73f-e1e0-41a6-abe3-e30bf214f25f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("48b8dc58-8c6b-4aa9-b42e-13cd2bb73725"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("49648a9c-aa6a-468e-afd6-0342b3e5d79b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4cf7d799-3ddb-40cf-9926-3f424fa33e78"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4f10a319-197d-4c9a-afe1-f01ae00771c9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("51a8a7b9-b52c-491c-b275-0131e9608b21"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5405c00e-657d-4835-a212-bbb4694fe48e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("54e25f24-5567-4613-882e-9c5f910737d1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("59f0d7c8-2a80-4cd3-bcf3-039d8b3effa7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("69d1df30-2daa-4985-b1fc-572c86baa7a3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6a4fcac1-5e26-4539-8573-fadc92d4419a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6a94fd40-e06d-435d-88f3-f9fc40c18ae0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6b8466dd-54d5-48fe-af16-1fa754cdd577"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6f47b2af-3ec7-4d33-9297-7c0dc0d8e48a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("759ccbda-1a53-4755-96a3-8cfdc2fd2380"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("81eb56c6-bcb0-4354-bf8a-47436f5a6893"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("84ab81c0-33d3-4f02-87e1-6ddc3fcdf9a5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("87762cf8-9b80-4283-a96e-44af311f4f36"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("87d3af4d-a14d-42fc-89ad-2af927fb7562"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a5c0132-d369-423a-85f9-438acbc9a4f9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8f4f1164-56e2-48a7-b79b-268442935922"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("904fc829-65d4-4499-a1d4-a03739435b61"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("98a8f3c2-9aa1-4ae6-b053-a0a3267a96c6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9bd365ed-64a8-4519-9c6a-e27de9654514"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a0fc5659-b7f6-4377-a700-cb096a23ca11"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a2886eb8-852a-47f0-b761-921d70b9d3d0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a6c8d078-69a7-48c3-9b54-0a120f990662"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("aa27053a-da7f-4bff-a961-27497885bdce"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ab29ae4a-2453-44d4-9930-8910cd6dd7eb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("abe702d0-9fc5-4d0c-8bed-fc33ea76483f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("add0bcdc-3727-4c61-b8be-d63a9b2a3818"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b20b5673-5236-471d-be3d-2e9e76f6503b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b5084287-98ad-4aef-8260-45fa0d1ed221"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("be2c4a7b-f639-45d7-ac48-1088a3078d5a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c208c68e-ca89-4ab5-b546-4a25ea6fae1b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c232ab4d-4964-4769-9761-8ef78c42020b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c871d1a9-5dbe-4d70-82fb-79696afd83f5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c91d6fe3-4a6a-45a9-a4bc-1e14f6788312"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ce6e1dc0-1efc-49b4-ad83-403128657b82"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cea1730d-813b-427c-90b5-b3e03e7b34a9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cf3e2b89-c20c-434e-b1fb-17441009bea5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d1b92413-9e4b-44bf-88de-a6917f689345"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d1e1a35a-6eea-4754-99cd-9a647fbd8f21"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d5040d0e-9864-420e-8a81-098040fc24ae"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d6bd267f-53db-4693-b4d7-78d550a86983"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d82c958a-0837-4e66-a4d3-08e2650de5f7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e82ebe83-bb4b-471d-b59e-a179ba0da57a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ee724103-5afe-4b4e-b4d1-d8839911930b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f03faec8-4357-4479-a362-d51c61285db5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f718c74c-b662-4627-85bc-fa7d0e051bcc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f7a00963-1a2f-4811-978b-876e3ac20a86"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fe245078-fc6b-4d8b-b90c-1b443725c6bc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("357b8a3e-d7aa-4a32-970b-2077b47d378a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8817b259-3ee6-492f-9f9f-b5195582e103"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a3738c1d-2606-42f9-adc3-1170db35949c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("c79f1e95-7683-48aa-954b-9eae9eca0ab9"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("e3727897-7c0f-410f-b8da-3d1aba40ae41"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("035682a6-0dcc-4331-b93a-20a68ffa09e1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("06a0a4b1-6bd8-487b-9455-2124fc0fa42d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("10c0c660-e80e-4f78-8d01-5b2941ec348d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("15598e0b-b21e-4976-bbe8-d29d1146bf6a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("191765a5-6e5d-419d-9ac2-13951c1877a3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("19a49740-4c70-4146-b9a1-657a7659351c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1d7e54dc-66bd-4825-a14d-1cd1e9b481a8"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1d9904ee-bfc8-4e00-a5e2-382f0accca10"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1df83556-926c-43c6-ae3c-ee6f9ac4c3b5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("25ffa090-a87a-4cff-817c-dd1f45d6ee93"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("27b7b537-4a24-4d27-9396-582e9eabdede"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2da7049a-5ff8-4340-88d8-9e7e4cfa22f4"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("397a2e54-8e95-4482-81e4-f77ec229c573"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("406a7634-ed23-4648-b39e-0fd8fb84a4b4"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("40bf1e2b-2f15-416d-8cbf-972ff2e37000"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("429ea034-a367-4840-80a3-2184932df7db"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("4b70a0e5-fb60-4467-82e4-b7695341d9e7"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("5325a35a-d28e-4933-a653-1b4b642adce6"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("55e434b2-7e58-499c-865f-361bed170ad4"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("56717064-ca25-488a-9dba-1dde380132d3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("56e44a81-a4c6-407f-895a-b72a7049e8ac"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("5705464e-3f97-4b2e-81c5-641e421059fd"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("591dcaeb-485a-45d2-8cfe-1162b19c08fa"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("5b4eab27-2f73-485b-afc7-34103c8c4f0d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("5f3a66c0-9111-4fe0-a6f3-d5b6f4ec53dc"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("670f4ff9-29c9-496c-b1e6-564538927c0e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6879eb45-11d3-48ac-8507-352d2121e5b5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("68b6dd9d-ce02-4b54-9a45-224a9f6ccb9f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6b6036d0-c336-4751-a7bc-601732dd3ace"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6d5074aa-cd26-426d-a070-5c6e1f8d932f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("713667b9-1bc5-4777-b724-b671ce9545f5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("71ba9e3c-a266-41ad-b86f-7e8c4f6d38a3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("731ffd1f-cf9f-4259-b621-cd60a0cee24b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("79f107c5-1cfd-42e0-aec2-efb1bb186d72"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("7d0ef04a-276f-4ea4-8131-b9c8ba204e23"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("7e5f294c-b038-41a7-9d50-b1fc93c9b34c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("7f32b498-3e54-4cad-a0ff-591d88470d13"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("854e5f2b-2d7f-49ed-a7fc-204bebcbf737"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("856f05c9-b30c-4c8b-8106-a7dbcbc1b5ad"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("8742bff1-bade-4e36-8808-32fc11273a88"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9223f2bd-68f1-45df-b2ab-72cde9d8831c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9310ad84-f875-48e0-bb88-b2230cf54eac"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("93b3ea87-95d8-471b-8659-c181b688a47d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("975b329e-45c3-4004-a049-490cd08199a2"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9965e4ac-157e-43ef-8ac2-fa156c22e44f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9bcf1b9e-f005-4b15-867f-cf98cc05eef4"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9d522f5d-ce0f-471a-8cba-3fe0b13077f9"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a555bc0f-85c5-4ee3-b388-bfd5538a4e9b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a9ec2377-8ff8-4289-8d3b-0641757dfb03"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("aaaf96da-53c4-455d-ad1f-50a6fc8ba2e5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ac4b2c6e-6e7f-4208-a3e4-08bec67157b2"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b2647073-a963-436b-ba74-bfecda238ef9"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b87451b6-87b2-4b4e-a687-922a477d2688"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b8f28185-1a1b-495d-a1ee-98d8aa575f48"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("bbbffe12-c160-4e73-a05f-947d8c2a9126"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c1d011b6-3dcd-46ff-8753-a91df742844e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c333f336-9fe9-4e41-8772-6e710c9054e4"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cb5b9bc7-5e86-447f-9ebc-9417f361e96f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cc71fdd9-c538-41bd-9aa6-e42d31aa6569"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cca0e233-36ba-4d83-8173-f41e83dbddd7"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d0d5479f-16f2-4436-a712-7916957ad382"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d545a73b-b113-4e8d-94d1-ce5d71c29ce2"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d66a1e6d-9696-40f0-8992-50e3ef13065c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d8387270-5685-4259-8f6e-931c4e044607"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d99c5bf2-f30e-4f61-bf96-1f5729123298"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e08fb3da-798b-4e05-acc7-87a1ba06088c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e255ae26-d072-4d6d-a32f-4fcdbea9c0f1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e7f63bc3-41dc-42bd-9cc4-9976a2cddbf8"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e9416994-0a57-4a54-a499-84eac735bea1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ecfeb743-ee84-4203-88d1-446408040849"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f12f1dd7-3d69-45ea-8656-1750c5d5a4a0"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f4f6a022-7cf1-4380-9d37-00ef71bf27f1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f59ac6fd-8420-467b-86f1-c4f2b2c2c2c1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f6c04ca3-8007-4c8a-9cee-cddaa76d8912"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("03fd0d33-6852-40f9-9529-53edfeb980eb"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("045969eb-e9bd-48c9-92a3-f0e50ca96e67"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("052ce2b6-f4f9-45fc-a36b-fd871997cf47"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0b217f79-749b-4bed-b984-eae29e896ab6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0d424444-b16e-4095-a462-5e0df2b830b6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0e94a252-bebc-4b90-a08c-71bd06bfe83a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0f3b1af9-cff3-4958-8d91-973db903e663"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0f4a9350-b921-4249-af70-22d73dffb2ba"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1641484a-2411-4e80-a25b-a8f82d4414e3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1bfdf0b1-cf83-4442-9f59-8f398227ea3d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1dcac742-c73a-469a-b8ea-7f16de87126e"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1f4720be-f37b-4941-ac7f-2785f1fa82e3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("238fc4d2-7dae-46e8-a6a1-10348319d2c7"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2657dae5-6e31-4bc3-8d93-1665e676d327"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("283a9319-1c2a-4220-b31b-62f5b79aec26"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("29c110dd-5908-4da3-84ab-364d5d59a414"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2bc9534b-c854-4b54-b2ea-386a42447750"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2dcf78b0-b441-4445-a916-538bd1de8ee0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("30253c1d-d45b-475e-9e4c-78d23f2fb8dc"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("31010288-224c-4304-914d-6380bad1b4d7"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("335ac5e5-0e96-409a-90a2-0b2bd42e0b31"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("384bc094-7a1a-4388-8a4a-ed4f90363745"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("397e4333-672a-4908-ae48-5bfbbe70da30"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("3ad91fe1-7c02-49a4-a908-7eba00a54c51"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("44bc5f98-1215-4619-8bb7-67c0793eb04a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4566aa98-606b-45c2-809d-dc96adbc3f29"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("46bfe5e4-89e8-42b7-9b9e-2c8197e34f4f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4a245771-f443-4a92-8bb2-deb048473599"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4aac426e-97f0-4edf-8c5b-d9af506c8beb"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4ff9988b-8d64-413a-902f-b04c14710b30"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("500f60be-f942-4ad4-8109-2d28050bbfed"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("568726fd-9699-4cd2-ad82-a09d68e35bfa"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("56a5a710-0a47-42c3-ac66-54730524330d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5cde69d9-400d-465e-86ab-6476bad46875"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5d61416b-363d-456a-9251-907fab5d8a14"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5d83ec35-d21e-4e1d-9d81-8e6a2052f162"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5fb21ed7-d4b7-45d5-9ecd-7ee6177537fe"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("66e8ca49-e237-4521-99ab-e6845e9125b5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6f34af44-c1bb-41f8-b5ef-a4c85d8df5b5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("72003795-ec9a-4b02-98f5-ea1cc3e259e3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7249ea5c-ab2e-4f3f-a661-e78bcf0832b2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("75111d6d-06c0-4a4e-8c98-fc483eabef98"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7ad10cbc-6e7f-4c62-88d0-7844449ff012"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7c0abed5-11c6-4b13-b8d6-006e7e657532"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7d2a2196-2c6e-4b0d-a190-fa766238b28c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7d4f838e-8531-4ffb-9951-5272da37f109"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7dd3612b-1beb-453f-bbd4-4c9922bfe55c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7de88853-b8d3-44c2-9eb6-039c95d2e5a1"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8d5476fc-d7a5-4f03-af2f-daa8b5b33188"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8ec348e4-39d7-41f0-b130-26ea13df4cb5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("91ca4a95-aec9-4498-9f10-ad2825e2cdb5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("925b1758-4588-4f53-a7d0-6f30808f8585"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("9590b338-faa6-497d-b86a-032436291832"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("99ac08d3-d873-4e45-aa85-df08f33a0db0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("9f11a0cc-f2d1-4aa3-9f25-a945122e053b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a8500346-4973-4a38-a803-5f544e093f75"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("ae2f87cd-8883-42dd-94c4-6c12b1515840"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("ae4df5c1-b4c5-4e29-bf37-62799c0923b1"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b16c1208-20a5-41b1-9a4b-4dc1adea2036"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b18dce57-6361-43fd-af9c-c0353017140c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b35e2a5b-c070-45e3-9554-e42d66f9823d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b720a29d-da68-4da7-8fa4-751f879a186a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b7e33c6c-1a5f-46ab-9e82-7cdfc74ac037"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bb893e9f-024b-4b0d-8af3-8eb0aad9154f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bfacd1cd-4524-4a7a-88d8-5ccfa95b9c43"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c29da83d-8034-4293-81ab-35d5750bf4bb"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c601d2b9-9a0d-4eef-af09-77f025fcbfe1"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c82e9144-ee18-48e3-bec5-feca8a654e40"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cbaaed48-abad-449d-8cdf-cc2cf7098d3f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cbd81ac2-af19-4668-a5fd-eeeabf4fe71b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cd9f6b17-67db-4a67-a837-addb6be95bfa"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d2bf338a-1bd2-41c8-b154-adc567aaebfa"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d6f9b017-4069-4e9d-9f70-7f2bbcf400a9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d717e21d-2f19-41f7-b7c6-4d94bc2b6f95"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("da25e087-14e2-4ede-84b1-6054195818b6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("dbf7a227-ad3c-41c6-a925-e1d99b3ebc92"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("de545f40-b45f-432a-8aa9-b3832dd38122"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e0edd8b6-a94e-48ca-b0ad-f68fdd80260c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e11404fa-ae62-452d-ad2d-bda60893e803"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e5764c37-03d5-4cb4-aaf8-c4458a0cbf55"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e59bd4bf-bc3b-4cf4-a57c-1c74fd30350c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e721335a-5a69-483c-abef-e6a8f7b327d3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f3c79597-d21d-4162-a023-aebae482889d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f44972c6-8fd5-49b4-8682-9fa87e1010fe"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f65f4440-6f5f-4b63-9bf9-bfbb954e7f60"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f6e05e7d-51ff-465d-9b2d-29c3ff977562"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f829e3a8-a969-4368-9891-785763f3bf67"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fe79abf3-02a3-4a6b-8034-7f4b0886b10c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("13119bc1-131d-4f03-9512-4003df8ad638"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("16072186-e44c-4667-901d-7576ec5a2d09"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("1b79d868-9abd-49ed-a58c-20079af2882d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("1cd06203-7731-415d-8373-fd185e2fb847"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("274cafc9-5fbc-4360-9f27-2d27a8036f5d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("30395bf4-c7fc-4eb3-b3e2-78024218939e"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("37edb6e2-019c-452c-887b-7b7eff41fea6"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("391d302d-0521-48c3-a2d1-38c8f34ab56a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3b0cf59c-4e1b-41fc-b1aa-23efbe9b7a1c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3d4bb385-e809-4f17-a98e-561ba9be9a59"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("44aea045-c624-4a88-8a4c-16bf9a1f3a4d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("4d3e0d22-1a4b-47d9-8696-938e0352ffa6"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("5d6db18a-423b-4fbf-a9db-1bb3c185b276"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("5f6c182f-c84e-4cf3-a22b-60b0cdc2567b"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("655041ce-81e0-41c7-9986-3c5ce109b346"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("6c28dccd-39fc-46b3-8a74-5e5852d89906"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("6e7e13a1-7d46-47c9-ab61-858b5b4ee889"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("7f4e5c63-8c3f-418d-9ddd-393e12c514bd"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("88e04095-f893-4fec-aea7-da1ba130ffa1"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8a410c18-846d-4a7f-9ce0-4fc3ed092608"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8f448b41-1d1d-426b-80a5-4976c14e8b9f"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8f71efd7-49c2-4995-b2da-dadc35659897"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8fa0db5e-a4e2-4372-b657-f7320d21fe1c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("912f55ed-4196-40d0-8c18-93dedb0c6bdc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("9ab5f718-7d39-43b2-bc67-885e64773645"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("9bc069ba-55f3-4f42-b4ec-4b8dfd14834b"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("9bd828f7-a49c-46a5-87ee-65509e25c4e2"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("9e9c0e97-797b-4dcf-977a-dfb3e8c282fa"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("ab1c0568-769f-4735-ade7-6ced8f2320e1"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("ac1e56a0-9c3b-4cbb-a2c1-b05dbb40ddf7"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("be862533-0dea-443a-9085-adc96203f798"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("befa0905-8419-4339-a5db-be1ab6ef8df4"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("c0f28aee-1ac3-4087-9372-4a4a6b30cdbd"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d2ebbce2-9d37-4693-b5d2-1460bcf6c405"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d4aba8e2-50f4-4060-bb57-7de145d66883"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d78d7e2f-d9f3-4067-86ab-782ac54591c4"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("e485d3a9-db16-4da7-a7f3-2b760024bc92"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("f132e076-e52d-493c-ac2c-1f443eada908"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("f6a7bd26-f682-44dc-bf9a-bb7588f8e73e"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("fba0ab8e-b1ff-409f-b0e9-cef18fc5c290"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("fcc68519-b992-41a4-92f6-7c8b2ebf519b"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("340d3762-4079-46be-a77b-81dba01107b6"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"));

            migrationBuilder.InsertData(
                table: "Countries-table",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Suriname" },
                    { new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "French Guiana" },
                    { new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Benin" },
                    { new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Mexico" },
                    { new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "British Indian Ocean Territory (Chagos Archipelago)" },
                    { new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Montenegro" },
                    { new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "American Samoa" },
                    { new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Dominica" },
                    { new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Equatorial Guinea" },
                    { new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Dominica" }
                });

            migrationBuilder.InsertData(
                table: "Products-table",
                columns: new[] { "Id", "Description", "Price", "Recipe", "Title" },
                values: new object[,]
                {
                    { new Guid("04b0c317-5a93-4f3d-b6b9-1c476ec07e5a"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 261.25m, "Rubber", "Salad" },
                    { new Guid("051f3ea3-f299-4880-81ed-c91c97ada90a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 61.76m, "Wooden", "Pizza" },
                    { new Guid("069783c8-3edd-4578-b982-6bd05c025e82"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 175.11m, "Fresh", "Pants" },
                    { new Guid("09b0f883-b9dd-47b0-a36c-007dc71cb139"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 314.30m, "Wooden", "Bike" },
                    { new Guid("102af34b-9a44-4933-a28f-a699efa8200d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 679.07m, "Soft", "Shirt" },
                    { new Guid("1204127d-07e0-48b3-8e63-8e2efc297924"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 318.58m, "Cotton", "Bacon" },
                    { new Guid("14155de7-aa41-48b3-b3d2-7e563508ab86"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 786.17m, "Granite", "Chips" },
                    { new Guid("15e9a113-3c52-45d2-abb2-69a984f91650"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 131.31m, "Metal", "Sausages" },
                    { new Guid("1696fa95-5d72-4832-af77-abf902fb6233"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 980.97m, "Cotton", "Chips" },
                    { new Guid("1cd63b53-947b-4e59-8455-dfa8f0a983fd"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 757.89m, "Granite", "Tuna" },
                    { new Guid("1d2612be-1a6f-4939-a7b1-ee2d1cf75bd4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 668.07m, "Fresh", "Pizza" },
                    { new Guid("1fdefd13-f245-42db-a1f3-08ff1e4dd30c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 220.51m, "Fresh", "Salad" },
                    { new Guid("203d7894-13b0-4436-8e92-3408bc347c26"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 258.91m, "Steel", "Car" },
                    { new Guid("20e2a7ad-80e7-44f2-af4d-4f2cc59f497c"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 285.64m, "Plastic", "Keyboard" },
                    { new Guid("210f8839-2f6f-4de2-9e29-469c83476018"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 721.49m, "Plastic", "Hat" },
                    { new Guid("27338712-f315-4b2d-a89c-9bbc68c5d96b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 469.19m, "Wooden", "Gloves" },
                    { new Guid("287e9929-6582-4698-a920-0458a4fd3404"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 422.45m, "Steel", "Gloves" },
                    { new Guid("2d54dc3f-9bdc-401c-974c-57115e354aa5"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 988.37m, "Steel", "Fish" },
                    { new Guid("2de3dc7d-7a34-4b86-a48a-ab13b61ad379"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 483.66m, "Rubber", "Car" },
                    { new Guid("2f07ec68-a27b-4012-8e8d-6c58095922b6"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 982.91m, "Wooden", "Shirt" },
                    { new Guid("3081c486-dabc-4d3e-99ba-802bab9f46fe"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 761.63m, "Plastic", "Sausages" },
                    { new Guid("3314db03-e390-406e-ae87-9bf5a511c2a4"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 202.49m, "Frozen", "Keyboard" },
                    { new Guid("363b8af6-9ead-43dc-b306-c1e77a057a5b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 249.86m, "Granite", "Sausages" },
                    { new Guid("37e89ea1-4595-42bc-93cb-31765744c9d7"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 260.89m, "Plastic", "Tuna" },
                    { new Guid("3891c2e2-260e-4e72-9631-7688af2df839"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 912.01m, "Soft", "Chicken" },
                    { new Guid("400a1eb4-95cf-4c20-a843-b96cb4c14f33"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 626.18m, "Wooden", "Chicken" },
                    { new Guid("41036d54-d5ae-47a9-b9fc-b7b9dfd1663a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 840.90m, "Wooden", "Soap" },
                    { new Guid("466f5007-75ee-4c02-8301-b866eebfc0bf"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 973.50m, "Cotton", "Soap" },
                    { new Guid("4850690d-c87b-43c3-8a6f-ce4f12b41006"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 876.75m, "Plastic", "Ball" },
                    { new Guid("48ab48b0-cba7-479a-bf98-62f135413e18"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 955.38m, "Cotton", "Shoes" },
                    { new Guid("4d274729-0ca2-447c-9b7a-1f8d688428a3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 461.64m, "Soft", "Shirt" },
                    { new Guid("50bebfdb-4443-4ffa-9519-40f35b8bc451"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 799.26m, "Wooden", "Chicken" },
                    { new Guid("5274d061-1608-4402-b580-5fad93996548"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 913.88m, "Plastic", "Pants" },
                    { new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 615.70m, "Concrete", "Ball" },
                    { new Guid("5b8206c8-977a-4829-be0f-b8758a161634"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 37.10m, "Plastic", "Chips" },
                    { new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 851.88m, "Frozen", "Table" },
                    { new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 557.88m, "Frozen", "Chicken" },
                    { new Guid("6a605faf-9399-41cd-971a-ed0d4cda2e33"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 596.00m, "Steel", "Shoes" },
                    { new Guid("6dd266ce-83e6-4cb6-bc41-65b88c412fda"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 367.42m, "Concrete", "Shirt" },
                    { new Guid("6e8d8a5d-6f2d-4f71-b6de-171329e79391"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 585.45m, "Frozen", "Pants" },
                    { new Guid("7118351c-8397-40ee-a11f-b73bfe4e1eb0"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 996.75m, "Soft", "Computer" },
                    { new Guid("72a4fac6-0a24-4734-93da-6ff6c436c955"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 928.48m, "Rubber", "Bacon" },
                    { new Guid("74d25c20-69e8-45a4-8d96-380ac6564bfc"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 437.44m, "Soft", "Shoes" },
                    { new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f"), "The Football Is Good For Training And Recreational Purposes", 219.59m, "Metal", "Fish" },
                    { new Guid("77f6623b-08d2-481e-bf85-5040a7eb135a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 859.46m, "Granite", "Chicken" },
                    { new Guid("7b0c42dd-636e-4e50-8ef0-7ab314f20864"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 682.44m, "Concrete", "Bacon" },
                    { new Guid("7b52545c-9d53-4b90-bb3c-3e0d772359db"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 812.45m, "Concrete", "Chicken" },
                    { new Guid("7c9f6f5e-89e0-4234-b2c4-ab58a1c808fe"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 521.84m, "Granite", "Towels" },
                    { new Guid("82b676b6-59db-4ddf-9121-f9b621cd455c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 848.71m, "Plastic", "Car" },
                    { new Guid("855117f2-2ae4-474a-8d5c-198a7e133fe4"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 562.86m, "Frozen", "Computer" },
                    { new Guid("873ad122-3bc8-4978-bf2a-218e412c49c0"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 58.87m, "Plastic", "Towels" },
                    { new Guid("88e21e38-3658-4c01-97a4-6b6423d656f6"), "The Football Is Good For Training And Recreational Purposes", 951.29m, "Fresh", "Pants" },
                    { new Guid("894b9207-8de7-4308-b07e-b6a6ab7c8720"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 0.99m, "Concrete", "Tuna" },
                    { new Guid("8a9834c6-df40-4227-92bd-d705192b564e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 595.37m, "Plastic", "Bike" },
                    { new Guid("8b92030f-7005-4f57-96ce-54efe8bf7ccb"), "The Football Is Good For Training And Recreational Purposes", 932.54m, "Metal", "Hat" },
                    { new Guid("8b9b2789-f88d-4b0a-8dd2-72b51d69af38"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 554.30m, "Granite", "Soap" },
                    { new Guid("8da60164-a6b7-4434-8368-50d4f3fda0ed"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 201.62m, "Steel", "Chips" },
                    { new Guid("926bf620-114b-410d-bc50-de5213741cae"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 12.94m, "Rubber", "Pizza" },
                    { new Guid("94da780f-3505-422e-813b-3f27641ed828"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 165.60m, "Rubber", "Soap" },
                    { new Guid("95027e1d-c3ad-4496-b4a4-e5875409fbe1"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 38.67m, "Fresh", "Chips" },
                    { new Guid("a0292c52-a952-497e-a3cf-c9e7ae54d851"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 267.89m, "Concrete", "Computer" },
                    { new Guid("a84cebab-0d83-49a7-b7d0-1a4cdb725c43"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 685.53m, "Frozen", "Salad" },
                    { new Guid("acc706fb-3a3c-4576-a3f3-116dd4c7ec4b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 579.27m, "Plastic", "Salad" },
                    { new Guid("accc9197-e896-4a94-ae9a-8fa089d834e8"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 849.17m, "Steel", "Hat" },
                    { new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 334.18m, "Frozen", "Ball" },
                    { new Guid("b06781f6-9082-4052-aba2-5e09e0e3a21c"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 137.25m, "Granite", "Soap" },
                    { new Guid("b11dc087-ac7e-4d93-b32d-bcab337caa3c"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 138.97m, "Frozen", "Pizza" },
                    { new Guid("b7ba6b7b-ac79-4891-b894-d4611e27eb6c"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 627.72m, "Soft", "Table" },
                    { new Guid("bc426f66-2fb3-44d5-adc8-2bfaa9cd3f28"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 436.22m, "Wooden", "Fish" },
                    { new Guid("be34a07a-6680-4440-b4db-2df4afd6a1fc"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 178.64m, "Wooden", "Tuna" },
                    { new Guid("bfd05140-60ec-48d4-84c9-078948eef632"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 487.51m, "Soft", "Mouse" },
                    { new Guid("c3c4a60b-e9f4-41a4-ae20-c4050dddb034"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 638.27m, "Concrete", "Cheese" },
                    { new Guid("c538e998-0be5-484f-89f5-4d74d1c297d8"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 990.44m, "Granite", "Towels" },
                    { new Guid("c6ea1c20-e953-4135-b167-4d6bba50671e"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 703.65m, "Plastic", "Pants" },
                    { new Guid("c9e97b1e-d785-4d20-af2e-6fa4de6eddc7"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 681.00m, "Plastic", "Fish" },
                    { new Guid("cb108bc2-04e4-4ebe-8a80-ee82d2bd8c6d"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 730.00m, "Rubber", "Keyboard" },
                    { new Guid("cc825e27-9f28-4cbf-9190-ab0e46db3d25"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 914.36m, "Metal", "Soap" },
                    { new Guid("cf631b08-8971-40f0-83d4-998b41d7a6c5"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 587.70m, "Fresh", "Cheese" },
                    { new Guid("cfc4184a-e4df-46d5-9295-4477f78cb79e"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 651.42m, "Cotton", "Soap" },
                    { new Guid("d1e12a59-3e7b-44e9-a90b-a6cbde8b6eb2"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 68.94m, "Wooden", "Pants" },
                    { new Guid("d3bff4ba-727d-4a58-a462-db81200dd655"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 998.81m, "Plastic", "Soap" },
                    { new Guid("d643b8e5-0b5c-498b-87bd-6ec9150c1f35"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 554.49m, "Concrete", "Hat" },
                    { new Guid("d72a70fe-eafd-43b1-8d68-ed18fed4c58a"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 936.84m, "Rubber", "Shoes" },
                    { new Guid("d79a301d-abce-469c-9579-e8392a43a6ed"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 428.26m, "Wooden", "Keyboard" },
                    { new Guid("db813643-390f-4581-88f1-19c056088ae2"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 628.56m, "Wooden", "Bacon" },
                    { new Guid("dc84b57d-5663-45c9-8858-99f36ba19f59"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 220.44m, "Granite", "Soap" },
                    { new Guid("ddca6af3-85a3-42df-8095-9fb213c55c06"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 197.71m, "Metal", "Sausages" },
                    { new Guid("e0dd9ff6-2db7-44ff-aa61-b49b8eac1739"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 523.63m, "Concrete", "Towels" },
                    { new Guid("e26c9870-c7bd-4fb3-aee3-be02767ee2ad"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 781.06m, "Fresh", "Car" },
                    { new Guid("e3d558f3-f6ff-4ef6-99af-3a857cd66c3c"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 774.31m, "Fresh", "Bacon" },
                    { new Guid("e49a373f-8a25-42c8-bacf-17bdd4bbc0bd"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 807.69m, "Frozen", "Sausages" },
                    { new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 776.81m, "Cotton", "Hat" },
                    { new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 955.91m, "Granite", "Cheese" },
                    { new Guid("f7f46857-0bde-4234-a8ef-4a5ef143d2a2"), "The Football Is Good For Training And Recreational Purposes", 752.47m, "Wooden", "Bacon" },
                    { new Guid("f85661c2-9184-47cf-b9ff-816dfa7c5eee"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 365.58m, "Metal", "Hat" },
                    { new Guid("fa5bfeb2-245b-43be-acdc-76452fcabdc9"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 648.80m, "Plastic", "Soap" },
                    { new Guid("fd263d85-76dc-43f1-8ca2-0a83b2091313"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 451.04m, "Plastic", "Fish" },
                    { new Guid("fd36f746-3390-41c0-9786-11ef7ead837a"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 326.82m, "Plastic", "Shoes" },
                    { new Guid("fdbac539-f8b0-4412-853d-285639821c09"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 434.81m, "Frozen", "Shirt" },
                    { new Guid("ffb9e721-dba0-45d0-97f9-a7441ccd3456"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 665.17m, "Metal", "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Customers-table",
                columns: new[] { "Id", "CountriesId", "Email", "FirstName", "LastName", "Locations", "Mobile", "Password" },
                values: new object[,]
                {
                    { new Guid("0147bf8b-50ec-4b6e-83ab-20376fe9f32f"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Sharon.Gusikowski@yahoo.com", "Sharon", "Gusikowski", "886 McLaughlin Wall, Margretfurt, Japan", "444.233.6587", "RvvSbXntCg" },
                    { new Guid("01f1ba04-00f5-4f16-9901-6b92be1e316f"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Johnnie76@yahoo.com", "Johnnie", "Schowalter", "865 Schowalter Crest, East Kody, Sao Tome and Principe", "(255) 842-6803 x5227", "tFYHTpN8BS" },
                    { new Guid("02710f45-46f8-4ac9-937d-1308d5cc7bf8"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Luz.Gusikowski94@gmail.com", "Luz", "Gusikowski", "149 Jena Forge, Amiyachester, Saint Kitts and Nevis", "834-356-3156", "tkie1IMpl8" },
                    { new Guid("0541d761-a3eb-4165-8877-c703eff65ed1"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Derek11@yahoo.com", "Derek", "Bergstrom", "786 Aaron Orchard, Lake Alexandriaborough, Greenland", "(336) 983-7309 x9419", "UOLMdwpcwV" },
                    { new Guid("060fb789-b466-4fe3-bc36-ba390dc9e172"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Kelley.Gulgowski61@hotmail.com", "Kelley", "Gulgowski", "73685 Judge Viaduct, Kevontown, Mauritius", "929.432.3475 x79426", "5IKUFsjchF" },
                    { new Guid("0a063f06-f9b3-4c36-95af-46642a3ae174"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Margarita_Denesik96@gmail.com", "Margarita", "Denesik", "007 Omer Forges, West Koby, Bangladesh", "(341) 451-8857", "Uh7WY2k8pW" },
                    { new Guid("0b48a4a9-6971-44d6-a19e-7fd7d3a4e696"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Wilfred.Shields@gmail.com", "Wilfred", "Shields", "52821 Kohler View, South Henderson, Peru", "452-259-0800 x42167", "znWJLvv8sl" },
                    { new Guid("0b89986d-107b-438c-9b89-e6cc5bc4333b"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Kristina.Skiles36@gmail.com", "Kristina", "Skiles", "520 Smith Brook, Velmaberg, Honduras", "867.520.2615", "D_gWfvTAQb" },
                    { new Guid("0da4fee4-5393-410b-aab3-1c7e8b2e04db"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Sheila_Hills@yahoo.com", "Sheila", "Hills", "93051 Jaeden Viaduct, Kihntown, Serbia", "1-587-887-3852 x5511", "lKSomXyWjQ" },
                    { new Guid("0edaf26c-0974-4a61-beef-5b25d2c3102b"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Brooke.Hegmann67@gmail.com", "Brooke", "Hegmann", "044 Kavon Junctions, East Gabriella, Holy See (Vatican City State)", "(447) 278-6488", "vf6NwFdlOL" },
                    { new Guid("0f2d5d7f-5528-4c21-8c5f-e5fea3f17b6e"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Jeffery68@gmail.com", "Jeffery", "Littel", "540 Clemens Drive, South Dannietown, Saint Kitts and Nevis", "894.314.5264", "GTmGzTA36w" },
                    { new Guid("12b68d33-b707-4b7b-b3d8-f543d529a6a6"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Jane_Greenholt@yahoo.com", "Jane", "Greenholt", "403 Suzanne Via, Wiltonfort, Andorra", "616.370.9656", "WiY_CaqR8h" },
                    { new Guid("17098e18-2c70-4ce7-b217-42f42dfbf9b6"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Rudolph_Grady@hotmail.com", "Rudolph", "Grady", "60129 Mavis Club, Port Gabriellehaven, Jamaica", "1-459-521-2594", "EH_EzFgcoU" },
                    { new Guid("174a4db1-8a08-4f73-a9c4-7bd5fe2c147d"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Alicia.Bauch@yahoo.com", "Alicia", "Bauch", "21328 Daphney Locks, Reynoldsberg, Trinidad and Tobago", "(351) 290-9216 x6473", "01wAKjrOTW" },
                    { new Guid("18132e54-dae8-4132-ac48-6009693c3929"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Juanita23@yahoo.com", "Juanita", "Roberts", "98690 Hudson Club, Schummberg, Japan", "293.931.9992", "zrdpIanr8A" },
                    { new Guid("1d3e1aa4-5c2d-4904-8e84-f58e87f379ce"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Anthony37@yahoo.com", "Anthony", "McGlynn", "38103 Abraham Village, Tillmanchester, Lao People's Democratic Republic", "1-609-407-0105 x3479", "vipS1ked98" },
                    { new Guid("1d8269a9-6fee-4313-a82b-47b2b323e1d1"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Christine_Bruen@yahoo.com", "Christine", "Bruen", "2196 Laurence Meadows, New Toreyfurt, Micronesia", "(264) 593-4234 x554", "NvWljYQG6E" },
                    { new Guid("1ddcf957-5837-4343-af91-4bfc9d612322"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Victor77@yahoo.com", "Victor", "Hilll", "308 Towne Walks, South Pierrefort, Antarctica (the territory South of 60 deg S)", "1-216-536-1154", "bKQFidwHbB" },
                    { new Guid("21a8500c-c9af-4102-a723-8cedff98f23a"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Phillip.Green@gmail.com", "Phillip", "Green", "35055 Watson Locks, Keenanville, Kenya", "362-683-7841", "zQcs_fkgY4" },
                    { new Guid("224ef483-4406-466f-9c4a-fd5a71f47839"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Virgil_Schroeder23@gmail.com", "Virgil", "Schroeder", "1878 Austin Coves, Bayerchester, Trinidad and Tobago", "800-800-8803 x42991", "QiMaTV5KxA" },
                    { new Guid("22d1697e-71f2-4453-a3c5-8552df8731a4"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Ramiro.Conn72@yahoo.com", "Ramiro", "Conn", "90793 Fausto Manors, Arvelburgh, Uganda", "1-966-357-3045 x216", "sCPLWM8Olt" },
                    { new Guid("23652965-5f89-460b-a763-4ce427737a51"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Scott_Blick@yahoo.com", "Scott", "Blick", "582 Gislason Harbor, North Colemanfort, Heard Island and McDonald Islands", "1-769-263-7579 x8248", "t4ogFL6FAD" },
                    { new Guid("29621f53-ca8d-4e1d-9347-446f304aaaa7"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Steven15@gmail.com", "Steven", "Marks", "345 Heller Plains, Josiannetown, Netherlands", "(685) 202-2606", "dTxv2ZkqNd" },
                    { new Guid("2eefe12a-bb52-49a4-ab41-2a7790085d2a"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Jacqueline.Homenick@gmail.com", "Jacqueline", "Homenick", "15161 Giles Fort, West Jaceyfort, Mongolia", "390-265-4317", "pcaBAJ8o9t" },
                    { new Guid("30d0b923-63bf-4812-9eab-08c7d684e21f"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Kristin_Simonis@gmail.com", "Kristin", "Simonis", "79664 Weimann Fords, Rathshire, Slovakia (Slovak Republic)", "722-328-0698", "57JzbvtEga" },
                    { new Guid("3248beed-eb63-44af-9c41-d7c11263a7ac"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Arturo_Schmeler80@hotmail.com", "Arturo", "Schmeler", "828 O'Reilly Drive, New Richie, Kyrgyz Republic", "(551) 785-6998", "srdLc13VUG" },
                    { new Guid("3376d914-f8b7-4611-95a7-01ed6f23b88c"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Valerie.OConner@gmail.com", "Valerie", "O'Conner", "9089 Kilback Wall, New Kraig, Suriname", "334.741.4724", "33l1kAoe6z" },
                    { new Guid("33bb92ad-e418-4b8b-a95e-e18bb62efad2"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Woodrow55@gmail.com", "Woodrow", "Mante", "709 Viola Creek, Lake Freeda, Slovenia", "226-942-9802 x73676", "hGEdU2Aiiu" },
                    { new Guid("3416ce50-135c-457a-a3c4-8ec7042e74e4"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Betty61@gmail.com", "Betty", "Lakin", "92419 Dock Track, South Madelyn, Congo", "740.949.3690 x570", "Nc6tW0bTLh" },
                    { new Guid("344311e0-6ecf-4837-9513-c69eb503d383"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Bobby16@gmail.com", "Bobby", "Moore", "01868 Polly Spur, Annabelland, Tanzania", "(540) 248-9150 x1078", "CBpYKNE5hc" },
                    { new Guid("37268960-75b1-4590-95c0-e88900d8fff6"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Irene29@hotmail.com", "Irene", "Quigley", "097 Dandre Plaza, Lakinhaven, Somalia", "(396) 633-0734", "8F4QuyQ1y6" },
                    { new Guid("37e58466-ecf3-4abc-a1b9-02ebd835dd4c"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Clayton.Nicolas@hotmail.com", "Clayton", "Nicolas", "5009 Jovan Bypass, Fredrickberg, Tanzania", "(774) 877-4087 x033", "OtDW3q4EGH" },
                    { new Guid("381b5a7d-faee-448a-93f2-b27ca658e458"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Andre57@hotmail.com", "Andre", "Jast", "6783 Olin Glens, Lake Brianneland, Jersey", "608-202-3765", "BDltsuTb93" },
                    { new Guid("38c9887f-4106-4b1c-bcc0-70983a7a9a28"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Leon.Lowe@yahoo.com", "Leon", "Lowe", "36415 Hartmann Highway, Port Georgeville, Guernsey", "(509) 544-2252 x4295", "a93SHtKRT0" },
                    { new Guid("396d90aa-f7c5-41a8-8287-e05204b4c2c0"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Sheri_Keeling@gmail.com", "Sheri", "Keeling", "049 Stella Village, North Connie, Cuba", "(900) 228-5553 x30859", "1vRFLdtDJD" },
                    { new Guid("3b4300c9-e958-40b3-9792-c28dc82d4e93"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Mattie.Ritchie@yahoo.com", "Mattie", "Ritchie", "06136 Felipa Wall, Ardentown, Fiji", "577.492.2380 x59151", "jxFa6OZgmC" },
                    { new Guid("3ba41dcf-5840-4f20-9e4f-e778d45968bb"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Pat_Balistreri52@gmail.com", "Pat", "Balistreri", "12229 Gregory Circle, Juanitatown, Niue", "880.223.6431 x508", "Nx6ZXii29Z" },
                    { new Guid("402875b0-55a8-4f41-89eb-83db9d6f02ac"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Joshua_Walker23@yahoo.com", "Joshua", "Walker", "308 White Dale, Bruenville, Kiribati", "343-983-1026", "ermm3h7KPH" },
                    { new Guid("41481b34-6a62-4495-896e-b95200bcc713"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Marie24@yahoo.com", "Marie", "Tromp", "57203 Wolf Wall, Lake Eunice, Martinique", "963.223.8140 x26766", "KloW84cytH" },
                    { new Guid("41dbc7df-cb93-4d3d-8ea9-510e194cae57"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Troy_Barrows@gmail.com", "Troy", "Barrows", "912 Otha Pines, East Rethabury, Pakistan", "534.627.2807", "D6YwrFL_fP" },
                    { new Guid("42e6e28c-305f-4763-8edc-c7a842b99f18"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Tracy75@gmail.com", "Tracy", "Wilkinson", "186 Ali Light, Lake Emily, Heard Island and McDonald Islands", "1-681-447-3492", "iRiy8lgRoF" },
                    { new Guid("43275365-984a-4fde-9de2-da30de5ba5db"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Marguerite_Wunsch92@hotmail.com", "Marguerite", "Wunsch", "8808 Aaliyah Crossroad, North Elinoreview, Vietnam", "(288) 576-4284", "Uj7LD3MdVw" },
                    { new Guid("435e8acf-27b6-44c5-b39c-605f0afc23dc"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Sherri_Boyle@hotmail.com", "Sherri", "Boyle", "3335 Lavon Hills, East Georgiana, Republic of Korea", "(748) 630-2894 x55801", "7KSM1p9EHK" },
                    { new Guid("4380c151-ed5e-4a6d-8431-87c9536b83be"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Corey_Prohaska@yahoo.com", "Corey", "Prohaska", "9722 Jalen Tunnel, North Isabellaberg, Italy", "(968) 860-7564", "5tD7hCPO9I" },
                    { new Guid("44db09d3-35ea-46d1-b086-359904f920bb"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Mitchell45@gmail.com", "Mitchell", "Tromp", "2126 Shaun Island, East Helmer, Belarus", "1-913-600-2640", "bfJsrMRFUR" },
                    { new Guid("453f7a11-b916-41ef-879f-8ecfeb6aa232"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Clark13@yahoo.com", "Clark", "Swift", "11648 Howe Fields, Lynchburgh, Bulgaria", "1-309-277-5681 x42355", "1hGbm2d_rA" },
                    { new Guid("4622a023-b19d-4c0c-8664-700a62c4f506"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Catherine66@hotmail.com", "Catherine", "Ledner", "868 Pamela Stream, Dibbertbury, China", "1-837-675-8328", "H23YogUPM_" },
                    { new Guid("468b4cc7-ce02-4caa-8938-dd59609c707c"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Rafael_Glover56@yahoo.com", "Rafael", "Glover", "9732 Elna Brook, West Pinkie, Faroe Islands", "(421) 421-4580", "0rBsbiZpwG" },
                    { new Guid("4752c179-a5bb-4062-9c08-3c4535c28ede"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Rene.Erdman@yahoo.com", "Rene", "Erdman", "983 McDermott Road, Stokesshire, Bolivia", "(614) 217-5110", "aaNsrAFTiF" },
                    { new Guid("4aebd8f3-f593-4088-a061-071a35b78681"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Clint.West@hotmail.com", "Clint", "West", "40333 Jennings Point, Rempelburgh, Paraguay", "274-453-0273 x80361", "AP7iqgQDPw" },
                    { new Guid("4c0241aa-16e4-403e-bbb4-ef41eac1b91b"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Joanna80@gmail.com", "Joanna", "Dickinson", "8450 Hagenes Rest, South Kareem, Germany", "1-750-359-2343 x014", "cUoQ9NHI4d" },
                    { new Guid("4c769826-ad2d-4606-bd54-dc7f0bfe498f"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Eleanor3@gmail.com", "Eleanor", "Erdman", "9505 Ollie Turnpike, East Gradyport, Montserrat", "697.342.3561 x96261", "8mviASSW3c" },
                    { new Guid("4e237dc2-ec6b-4975-9442-d24404ed8018"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Cathy_Goldner64@gmail.com", "Cathy", "Goldner", "29723 Kunze Cove, Grahamshire, Netherlands", "1-712-476-7384", "KBKgRdZCP6" },
                    { new Guid("4e9dce03-c935-416d-8091-da58af65ee06"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Dennis.Bins@hotmail.com", "Dennis", "Bins", "77813 Metz Road, Yasminmouth, Northern Mariana Islands", "1-596-586-8057 x08290", "II8k295vVX" },
                    { new Guid("51912d23-4c33-4e4d-ac2f-17434581288e"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Al8@hotmail.com", "Al", "Casper", "58090 Vincent Roads, Daughertytown, Andorra", "408-348-9825 x7306", "JlziD8GBN2" },
                    { new Guid("521baabf-61a3-40f1-a2ee-32d6814833d9"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Ruth92@gmail.com", "Ruth", "Fadel", "42125 Batz Forge, Lake Hildegard, Zambia", "1-399-746-8553 x8435", "0k_v7sxGrS" },
                    { new Guid("528e8456-76bd-4f2f-a588-4c9ffe68bfe8"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Terence_Yundt59@yahoo.com", "Terence", "Yundt", "51538 Raul Walks, Lake Aminachester, Holy See (Vatican City State)", "1-219-544-8505 x46592", "VKdJjMDWDI" },
                    { new Guid("54569b23-a865-4ece-9db3-c3975456b64f"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Felix_Schuppe@hotmail.com", "Felix", "Schuppe", "756 Cremin Gateway, West Vernerport, Ethiopia", "1-771-708-6109 x985", "JiUH8e7UXP" },
                    { new Guid("55341d2f-56db-4994-9107-92c4a7b5e988"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Velma.Hauck2@gmail.com", "Velma", "Hauck", "713 Schultz Mills, Kozeyshire, Kenya", "(243) 731-3356 x6954", "DsxPUquvKL" },
                    { new Guid("5568fc18-7d0b-4052-b373-f6d079404a24"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Lawrence1@yahoo.com", "Lawrence", "Lubowitz", "3327 Margarette Canyon, East Ethel, Reunion", "745.571.8123 x71685", "D0bNSwMs3h" },
                    { new Guid("56e0a98f-056a-43a2-9fc2-4fdde756ec08"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Edward_OKeefe@yahoo.com", "Edward", "O'Keefe", "083 Carter Fords, Labadieview, Trinidad and Tobago", "(548) 664-1708 x399", "PNXVYz3L5I" },
                    { new Guid("58d0a27e-128e-423e-9a80-ec399285d062"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Marjorie_Crist74@yahoo.com", "Marjorie", "Crist", "38589 Maida Locks, Ginaland, Spain", "284.996.5983 x0575", "tIBKN7gQIt" },
                    { new Guid("5ad640b3-0a17-4d31-945b-465e4713d7bc"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Cristina.OReilly@gmail.com", "Cristina", "O'Reilly", "9174 Alexane Loop, Clareborough, Malta", "525-791-7096 x86141", "pGkrrpuoFL" },
                    { new Guid("5b8d9d6d-9f4f-400f-9bdb-9dc83e279d2a"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Leona58@gmail.com", "Leona", "Emmerich", "9211 Tiffany Grove, Lemkeland, Mexico", "428.996.4222", "IasAHBIoKo" },
                    { new Guid("5d135bbb-ae15-4ce6-ba31-515a556512e7"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Peggy_Leuschke@hotmail.com", "Peggy", "Leuschke", "85316 Heaney Extension, Zelmaville, Christmas Island", "1-904-981-8429", "yW082lKWCa" },
                    { new Guid("5de33e98-f4ba-4af1-84f2-fd3739e5915f"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Margarita.OReilly@hotmail.com", "Margarita", "O'Reilly", "475 Stephen Cliffs, Trantowberg, Montenegro", "(453) 308-8195 x944", "RDgNi3B2EA" },
                    { new Guid("5e4786c7-8fc5-454b-abb5-fc8ee9dc0114"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Lyle73@gmail.com", "Lyle", "Murray", "899 Langworth Valleys, Gislasonview, Brunei Darussalam", "(430) 596-4917 x6115", "SeZarBnBCJ" },
                    { new Guid("5fb30673-1791-4b01-8c53-f0064fa12d57"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Alton15@hotmail.com", "Alton", "Brekke", "24444 Beatty Mountains, Helgaview, Syrian Arab Republic", "1-658-552-7510 x219", "GhNWE45v49" },
                    { new Guid("607ff147-1acf-438f-9479-c55af05ead12"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Alvin17@yahoo.com", "Alvin", "Hand", "03998 Williamson Haven, Kamrenburgh, Taiwan", "(477) 666-5501 x5699", "fJEVlkpZWG" },
                    { new Guid("613b27a3-28d4-4844-b4b7-c3ffe609b5b5"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Angel_McCullough@hotmail.com", "Angel", "McCullough", "4125 Johnathon Groves, Kerlukeport, Norway", "777.481.1467 x32356", "Zjzxzuj4VT" },
                    { new Guid("613c5d38-f65a-423a-8543-ac13f044663e"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Bernadette.Kerluke@gmail.com", "Bernadette", "Kerluke", "88736 Crist Brook, Port Mayra, Lao People's Democratic Republic", "449-797-0910 x84436", "aFeyzYlnCA" },
                    { new Guid("668fd3b8-f9bb-4ad3-9e04-12057fe41b59"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Clara83@hotmail.com", "Clara", "Marks", "8061 DuBuque Turnpike, Rennerbury, Kuwait", "536-331-8170 x64837", "4NGRWzFGLQ" },
                    { new Guid("677c28d2-668a-4167-b8e6-a6d59f958380"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Debbie_Heidenreich21@hotmail.com", "Debbie", "Heidenreich", "58248 Kemmer Mission, Thielburgh, South Georgia and the South Sandwich Islands", "(310) 823-4151 x112", "5rwetM6l03" },
                    { new Guid("6837a98a-5d3c-4396-8f61-41df515f73bb"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Melanie79@gmail.com", "Melanie", "Herzog", "09503 Selena Walk, East Adonishaven, Uganda", "659.452.5249", "3woQmR6mWv" },
                    { new Guid("688595f9-3894-4a08-adc7-64d1f0029c4f"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Eddie_Keeling@gmail.com", "Eddie", "Keeling", "96135 Lela Light, Lake Beulah, Antigua and Barbuda", "1-966-815-5420 x362", "43sEouBJih" },
                    { new Guid("696573d1-6d33-452c-82be-2391b236063d"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Sonia.OHara@gmail.com", "Sonia", "O'Hara", "296 Haley Shoals, Anabelleside, Tunisia", "932-454-3686", "eg91rVCmRA" },
                    { new Guid("6a585ec6-f611-4e1d-82f8-1033936fe38a"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Nina58@gmail.com", "Nina", "Runolfsdottir", "29603 Timmothy Passage, Tillmanside, United Kingdom", "908.773.6082 x1675", "iHTk7bLuEF" },
                    { new Guid("6df03384-bdad-4c2b-8433-69c3f3f68bdc"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Phillip_Leffler@yahoo.com", "Phillip", "Leffler", "80660 Clementine Mountains, Michelefort, Latvia", "410-704-8357", "FGad2aaZYb" },
                    { new Guid("6e08a6dd-ddd8-4108-b121-4990a8f3e541"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Gina.Hirthe@yahoo.com", "Gina", "Hirthe", "0542 Graham Vista, Port Jalynview, Palestinian Territory", "414-791-9831 x866", "08my9Re2Z9" },
                    { new Guid("6e0a4fae-e37f-46c6-a012-515087c2ffd2"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Clint_Koelpin0@yahoo.com", "Clint", "Koelpin", "5313 Zboncak Burg, North Rey, Bangladesh", "1-585-248-9710", "ij25Fs9SJV" },
                    { new Guid("6e991b94-efbd-4547-9d85-085d7bef85a5"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Perry17@gmail.com", "Perry", "Osinski", "438 Aracely Drive, Shaunside, Slovakia (Slovak Republic)", "719.502.9022 x7567", "1oMvIKbAAP" },
                    { new Guid("71638686-a510-4b10-a93e-d975be713fa6"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Tara.Olson72@gmail.com", "Tara", "Olson", "234 Greg Rapid, Spinkafort, Comoros", "841.456.0658 x0478", "e9Nr4XBaFP" },
                    { new Guid("7264d1e8-2efb-43a8-b52d-48f61cc3ed00"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Gerald.Hilpert@yahoo.com", "Gerald", "Hilpert", "891 Dale Club, Jonesmouth, France", "1-923-234-7915", "npyFlm0AF8" },
                    { new Guid("7437eb77-93fb-48e9-b629-bdb0d297caf8"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Jodi11@gmail.com", "Jodi", "Kuphal", "054 Crooks Lakes, West Angel, Saint Lucia", "(961) 892-5357", "GzQEf_fPmm" },
                    { new Guid("7568af18-ac01-4f48-8c1e-e12de5a50d21"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Karl88@yahoo.com", "Karl", "Adams", "8561 Zieme Orchard, Spencerport, Nepal", "(887) 844-5540 x510", "SxS209PQpe" },
                    { new Guid("7867a6ca-5282-40f3-8848-8dcf5f0ed9bf"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Cathy66@hotmail.com", "Cathy", "Schroeder", "2714 Cassie Heights, Port Rodgermouth, Spain", "202-956-3594", "HzKuRlahMB" },
                    { new Guid("790acf76-387d-46df-99f1-8632fca9facd"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Carrie7@hotmail.com", "Carrie", "Ankunding", "10442 Ansel Locks, Loyalbury, Puerto Rico", "1-447-811-3951 x2356", "GFyrNEKjgW" },
                    { new Guid("7ac0629c-64f8-4d5a-8381-3a1c3fe5c8f4"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Cora_Boehm@yahoo.com", "Cora", "Boehm", "815 Tod Tunnel, Jensenfurt, French Guiana", "933.210.1506", "AcJZIY3of1" },
                    { new Guid("7aef2f9f-a83a-4c9e-9b77-62876b6737ed"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Pat_Keeling@hotmail.com", "Pat", "Keeling", "81295 Kaela Junctions, Wisozkshire, Egypt", "1-228-231-8429 x84669", "757a0hohqn" },
                    { new Guid("7b4c3b6e-3d2c-4db0-b564-6254e4baaeaf"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Melba13@yahoo.com", "Melba", "Cronin", "123 Jacinthe Locks, Lake Eloise, Ethiopia", "(464) 942-3616 x7115", "gmpm57mwgK" },
                    { new Guid("7cb233c4-6570-4567-90a6-fd5b214f5a98"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Dexter77@hotmail.com", "Dexter", "Hoppe", "5796 Kris Cove, New Shanyville, Luxembourg", "1-713-705-0506 x9290", "8F7XPwJK5o" },
                    { new Guid("834cac26-61f7-4d94-b0f3-9a81dd2e83cf"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Natasha55@hotmail.com", "Natasha", "Quigley", "709 Jules Islands, Brentfort, Canada", "966-840-0669 x0556", "Yh9SnusjSi" },
                    { new Guid("85c2c617-29b7-4dcf-be9f-efc29480aaf8"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Jimmy_Abbott94@hotmail.com", "Jimmy", "Abbott", "902 Jenifer Bypass, South Emmyland, Jamaica", "494-402-1536 x091", "lAZJxsgOJr" },
                    { new Guid("86882691-2b74-4a86-bc6c-3af4628dbd43"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Miranda.Ratke38@gmail.com", "Miranda", "Ratke", "1625 Bernier Ports, Lake Fredy, United States Minor Outlying Islands", "995.810.2564", "g5382Urojz" },
                    { new Guid("8a92683f-857c-4098-a06b-2af504783426"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Wilbert.Hoeger@yahoo.com", "Wilbert", "Hoeger", "666 Auer Field, Cristalmouth, Singapore", "342-588-5946 x319", "JGiKTtGITd" },
                    { new Guid("8cc280e8-b735-4afb-bade-72c5d3fe6f7b"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Sylvester_Gerhold95@yahoo.com", "Sylvester", "Gerhold", "2081 Alan Corner, South Generalland, Cambodia", "1-996-942-0291", "sPR1ykUhv0" },
                    { new Guid("8e48f57c-4468-4fca-8ae1-86e5b3d4a1fb"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Michelle.Beier84@yahoo.com", "Michelle", "Beier", "9105 Tristian Village, South Audreanneburgh, Grenada", "1-377-374-9131", "NIIkyaTY1p" },
                    { new Guid("8f78794f-0d7c-4790-be55-3d862d4b8fc5"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Sherman90@gmail.com", "Sherman", "Abbott", "26305 Beahan Lodge, Osinskitown, Sweden", "(209) 701-9967", "9wsaKsk7Km" },
                    { new Guid("914b5fab-01b9-4197-bf7a-8af4f4481065"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Ben_Vandervort@gmail.com", "Ben", "Vandervort", "15367 Gutkowski Alley, West Felipaport, South Africa", "1-867-293-3241 x101", "yNovi5JXlH" },
                    { new Guid("9385cd32-b9bb-44a8-88ec-93f43484789d"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Joan.Schuster68@yahoo.com", "Joan", "Schuster", "58741 Harris Locks, Bruenstad, Syrian Arab Republic", "(670) 600-1647 x2547", "c0cTRmUKuz" },
                    { new Guid("945b7315-38e4-4962-9c5d-c4aede3b5b6e"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Rudy_Yost32@yahoo.com", "Rudy", "Yost", "71729 Maeve Lodge, Port Brownmouth, Trinidad and Tobago", "619-967-8683", "SmVIS0eQ5h" },
                    { new Guid("958ded78-d7cd-4431-b359-14774fe82db4"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Jaime_Parker33@gmail.com", "Jaime", "Parker", "566 Pearl Points, Cristchester, Malawi", "224-859-8762 x21339", "snqyy6ksZm" },
                    { new Guid("95c08215-2a62-4b11-bda9-6a8074750845"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Jose.Bogan68@yahoo.com", "Jose", "Bogan", "156 Luettgen Coves, Karolannborough, Iceland", "1-644-436-0012 x945", "kesc1ERwzC" },
                    { new Guid("98c1db6c-5465-4014-af6a-f06e835f2084"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Inez.Jacobson30@hotmail.com", "Inez", "Jacobson", "0187 Mueller Parkways, North Eriberto, Malaysia", "(280) 482-8574", "QRuchypdLR" },
                    { new Guid("9b306588-9764-41eb-8dad-21890b791786"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Stacy40@hotmail.com", "Stacy", "Auer", "49138 Kane Mountain, Reillyfurt, Isle of Man", "740.564.6027 x8754", "MIKJSo0eOf" },
                    { new Guid("9e600a3d-ef9c-4ab3-aa50-c2cb1e32f4f0"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Elias_Hintz@gmail.com", "Elias", "Hintz", "931 Kiel Crest, Blandamouth, Mayotte", "284-216-3635", "ZcL544NE0d" },
                    { new Guid("a0cfe7da-86ba-4eca-bef1-9ee47c27da83"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Bridget15@gmail.com", "Bridget", "Sporer", "30416 Major Light, McKenzieborough, Poland", "1-896-286-2286 x2030", "H4EAdD0v4i" },
                    { new Guid("a133254b-ca85-4676-acdf-223d2727dcf6"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Ronnie_Heathcote55@yahoo.com", "Ronnie", "Heathcote", "7201 Isabelle Center, Floydshire, Cameroon", "698-656-0723 x3783", "ii6sV4NGlh" },
                    { new Guid("a4edf60e-49de-44ad-b79b-d643add2f342"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Mary.Gulgowski56@yahoo.com", "Mary", "Gulgowski", "48536 Kihn Roads, Marcelfurt, Togo", "1-491-363-4996", "mO4V3vucS4" },
                    { new Guid("a6b93f95-3315-41d9-89f4-274d8cd57ffc"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Gretchen_Stroman@hotmail.com", "Gretchen", "Stroman", "77972 Sammie Mill, Lavadaburgh, Cuba", "950-704-9701 x0125", "NqDXfSCNYv" },
                    { new Guid("a9eeb733-832c-41b0-91bf-b6bd9f6a0377"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Christina.Muller@gmail.com", "Christina", "Muller", "4790 Konopelski Center, Baileyton, Cocos (Keeling) Islands", "1-931-793-3627", "2mE5jcW4aI" },
                    { new Guid("acf821bf-f609-46ce-8b9b-3618d58a8351"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Jana.Schmitt77@hotmail.com", "Jana", "Schmitt", "032 Adrain Loop, Kovacekville, Denmark", "795.936.3923 x30887", "j3_czKoRVi" },
                    { new Guid("b0db5d70-a422-4522-80ee-ab9768e0ab4a"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Laurie36@yahoo.com", "Laurie", "Prohaska", "8319 Lowe Courts, Billfort, Northern Mariana Islands", "384.919.6050", "9BIh4Q5pO7" },
                    { new Guid("b5521b36-8280-4c31-b1bc-ec6213a52339"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Mabel8@yahoo.com", "Mabel", "Moen", "8576 Lehner Field, Gulgowskiville, Myanmar", "542-554-0059 x165", "gzdt3wxXsI" },
                    { new Guid("b5aa6d38-6827-4443-a86f-09864d03808a"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Eugene_Schumm@hotmail.com", "Eugene", "Schumm", "66262 Tremblay Springs, New Andre, Tunisia", "329.648.8858", "1smr49EGzz" },
                    { new Guid("b6acbbc1-67ac-46b1-9929-8da295aee528"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Wade_Will@hotmail.com", "Wade", "Will", "43395 Schroeder Square, Gleichnerfurt, Bulgaria", "278.455.6133 x7425", "GdQ7E6lv3r" },
                    { new Guid("c03f9473-92d5-4888-b3d5-6a5a5752864f"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Jean.Cassin35@hotmail.com", "Jean", "Cassin", "197 Aron Via, North Leeside, El Salvador", "806.668.0915", "TRjpQV5zzo" },
                    { new Guid("c323ba07-1b10-48d1-a9ce-ea7440118b02"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Elvira29@gmail.com", "Elvira", "Kertzmann", "82236 Ondricka Place, Norastad, Madagascar", "339-530-9311 x28990", "plJ6Wq2XCy" },
                    { new Guid("c4063b44-7bb0-4859-b887-1af1ab7647ff"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Zachary.Schaden@gmail.com", "Zachary", "Schaden", "0461 Larson Gardens, Langworthfort, Micronesia", "415-599-4306 x4449", "5wiOqZG3nA" },
                    { new Guid("c6ce6c15-2a04-4a2e-8ec9-a948067ecc31"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Joann_Erdman17@hotmail.com", "Joann", "Erdman", "11423 Pablo Villages, South Ryley, Colombia", "1-428-342-9979", "UCvQDw5IfN" },
                    { new Guid("c798753c-684d-46c2-940d-86f68a26a3b4"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Clay95@hotmail.com", "Clay", "Powlowski", "1313 Humberto Inlet, McLaughlinbury, Algeria", "(698) 291-8485 x371", "H4jEiVALK7" },
                    { new Guid("c90e065a-f9ac-47c9-a91e-2482359cc9b6"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Irving47@gmail.com", "Irving", "Hodkiewicz", "329 Idell Station, Port Shanehaven, Isle of Man", "428-772-0529", "Iw0bCJ1_V_" },
                    { new Guid("c973fc98-534b-4da2-afe0-4dd440885649"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Stanley50@yahoo.com", "Stanley", "Thiel", "4656 Modesta Station, Nolanchester, Djibouti", "469-369-6224", "o8mb1uBTSJ" },
                    { new Guid("c9b7f669-bb10-42b4-86f1-990674e46d88"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Regina61@hotmail.com", "Regina", "Parker", "9702 Sheldon Bridge, East Tyramouth, Kazakhstan", "1-792-475-0787", "D2nlERjSZD" },
                    { new Guid("cb7b8924-0d64-48f0-83d8-273d5ed4b692"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Mable_Runte@gmail.com", "Mable", "Runte", "13796 Joy Rest, Port Vanfurt, South Georgia and the South Sandwich Islands", "(992) 634-2289 x67716", "CpzR8CW4W3" },
                    { new Guid("cca36535-8e95-4d9f-b74a-ec51f74ac099"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Paula.Cartwright23@hotmail.com", "Paula", "Cartwright", "94242 Maria Locks, Lynchshire, Jordan", "(849) 549-7355 x06384", "DaH3pGijj7" },
                    { new Guid("cde1ebbd-267d-4aad-b025-9ac7baa338ee"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Jenny.Murphy7@gmail.com", "Jenny", "Murphy", "8154 Wunsch Summit, Judebury, Bermuda", "1-797-505-9238", "usWUVj1P55" },
                    { new Guid("ce412353-e240-483a-b834-c1316057ed8b"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Dawn.Walker87@gmail.com", "Dawn", "Walker", "418 Emmanuelle Overpass, New Selmer, Comoros", "747.757.3202 x00898", "GdTBONym96" },
                    { new Guid("d160096d-9192-48af-846e-361ee351eb32"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Luz_Cole66@gmail.com", "Luz", "Cole", "746 O'Keefe Row, West Bertrand, Svalbard & Jan Mayen Islands", "(647) 787-9341", "wioBYgBfCS" },
                    { new Guid("d38c09ae-b8b0-48a2-94b9-c7173e87ec09"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Mona_Vandervort@yahoo.com", "Mona", "Vandervort", "5147 Hand Summit, East Eino, Ethiopia", "934-639-7429 x49584", "55oBvZx768" },
                    { new Guid("d66040b2-75b8-44a7-82b6-108263c3963c"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Nathaniel.Vandervort47@yahoo.com", "Nathaniel", "Vandervort", "22095 Bins Ramp, Winfieldfort, Argentina", "(400) 346-6063", "vUxKPEP3qn" },
                    { new Guid("d7373145-5235-4cf6-83d9-aa48337571ac"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Tasha_Baumbach13@hotmail.com", "Tasha", "Baumbach", "4122 Effertz Junction, New Kelvinfort, Cameroon", "1-590-746-8833", "E65zgSq3H0" },
                    { new Guid("d86c6913-fda2-49f9-85f0-4576773a3ee1"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Claudia.Rau@gmail.com", "Claudia", "Rau", "4533 Euna Streets, New Rylanmouth, Comoros", "(373) 557-0692 x747", "c5HSylJx7Y" },
                    { new Guid("db1b5994-75df-48c6-abbf-0bfff0e8e4eb"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Karen_Wiegand0@yahoo.com", "Karen", "Wiegand", "99231 Eden Causeway, West Judd, Bermuda", "1-225-530-0606 x316", "bGhKI2P9AL" },
                    { new Guid("df9442e6-d553-4876-9482-143afc40f257"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Jesse.OKon45@yahoo.com", "Jesse", "O'Kon", "30059 Asa Falls, Kaylastad, Jersey", "447.384.7363 x0286", "yDdV3xg2ae" },
                    { new Guid("e0770db7-e3e3-4cdf-8379-10b7431183bf"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Ismael10@gmail.com", "Ismael", "Schneider", "51154 Russel Fords, West Chelsea, Namibia", "1-709-890-0941 x29475", "uIfEqaOAhF" },
                    { new Guid("e0ee3ab2-0b65-4569-950f-adefe865daa1"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Ruth_Kozey91@gmail.com", "Ruth", "Kozey", "9464 Shemar Roads, Tillmanland, New Caledonia", "1-916-329-7786", "PU5lL6RSBN" },
                    { new Guid("e3efb51d-d6f1-48b5-aa4d-bc28bb7571d5"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Mark_Wiza@hotmail.com", "Mark", "Wiza", "195 Little Avenue, South Zachery, Mauritania", "(344) 520-9280 x9931", "yJi1IWmnwD" },
                    { new Guid("e507aa1a-07e1-46f9-9bb2-717860137410"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Robyn68@yahoo.com", "Robyn", "Maggio", "269 Kaden Causeway, West Jodiestad, Montenegro", "1-629-222-7337", "YM2lqydZEh" },
                    { new Guid("e7811290-0646-4b7d-b10f-5c4a6c047089"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Dominick_Ullrich34@yahoo.com", "Dominick", "Ullrich", "7258 Maryse Tunnel, Beertown, Luxembourg", "274.587.9576 x7640", "VlyuxXl8Yr" },
                    { new Guid("ea54c1d3-7c77-478a-81b1-7ffcbd46defb"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Drew0@gmail.com", "Drew", "Swift", "744 Chelsea Crest, New Tessie, Bulgaria", "519.851.6864", "csRKDTX_M_" },
                    { new Guid("ed8add2f-e421-4b74-aade-864b43c9a96d"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Janice_Wyman@yahoo.com", "Janice", "Wyman", "66787 Coby Circles, West Jaydenburgh, Madagascar", "1-861-939-9741", "x7N6YjiQEL" },
                    { new Guid("f228442b-bbd9-41c2-ba38-ce4b6299463b"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Carolyn_Dach@yahoo.com", "Carolyn", "Dach", "9078 Hickle Wells, Jimmyport, Micronesia", "(627) 464-1876 x0621", "LcCg0GMjBo" },
                    { new Guid("f2889dd7-12a3-4ff0-92f1-1ad35c365244"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Eleanor_Kilback52@hotmail.com", "Eleanor", "Kilback", "4437 Schaefer Lane, Lake Camillestad, Russian Federation", "(720) 821-9193 x06371", "VlY7b_opiC" },
                    { new Guid("f6ad7aa9-508b-46f9-a5f7-76bf3e9d15d5"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Bessie49@hotmail.com", "Bessie", "Schneider", "325 Devan Oval, North Marietta, Tunisia", "1-752-347-9600 x7237", "ijfzi9l3NH" },
                    { new Guid("f6d8fb61-d35d-4c78-96f1-68e16051b768"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Ella_McClure78@gmail.com", "Ella", "McClure", "1169 Caterina Station, Rosemarieburgh, Republic of Korea", "414.640.1908", "bPcDNtQsCk" },
                    { new Guid("f85834df-9460-4381-a426-e5198991db19"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Earl.Paucek@hotmail.com", "Earl", "Paucek", "77191 Zoey Ramp, North Emie, Kyrgyz Republic", "1-493-970-3412 x940", "pnD99GkW22" },
                    { new Guid("f8a16c5e-924b-4c78-86bc-f8cfc88fb093"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Terrance_Osinski@gmail.com", "Terrance", "Osinski", "84079 Dorthy Valley, Port Luz, Egypt", "750-692-0460 x1847", "AG9iR4LrGt" },
                    { new Guid("fbc73f61-3aee-411b-ac8c-e420fa35da78"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Sheldon.Gleichner@gmail.com", "Sheldon", "Gleichner", "483 Haley Roads, Thielbury, Thailand", "1-767-203-3212 x37846", "4o_b_7I8sc" },
                    { new Guid("fdf006a0-fd23-4eec-a714-68c214d657ac"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Angela.Aufderhar@hotmail.com", "Angela", "Aufderhar", "60180 Jillian Lodge, Silasside, Liechtenstein", "1-913-856-1860", "L9ERKm6R1J" }
                });

            migrationBuilder.InsertData(
                table: "Distributors-table",
                columns: new[] { "Id", "Address", "CountriesId", "Description", "Email", "Title" },
                values: new object[,]
                {
                    { new Guid("0165197c-e010-4e57-8305-d0076bc99dcb"), "356 Jacobson Creek, Port Maurice, Bulgaria", new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Pre-emptive bottom-line portal", "LangoshSchadenandZboncak.Nicolas41@gmail.com", "Langosh, Schaden and Zboncak" },
                    { new Guid("039b0733-3442-426e-837f-7c53a0468d37"), "06115 Corbin Meadow, Kittyfurt, Papua New Guinea", new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Organic intermediate instruction set", "FritschDurganandBogan_Gottlieb@hotmail.com", "Fritsch, Durgan and Bogan" },
                    { new Guid("06b24408-e8cb-44a6-b782-58ecb9529dfd"), "609 Thiel Ports, East Bethany, Bahrain", new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Organized foreground utilisation", "RunolfssonGroup_Ferry66@hotmail.com", "Runolfsson Group" },
                    { new Guid("06ee643a-2b91-415e-8752-94e8d8aa3467"), "43655 Broderick Fall, South Pinkie, Cook Islands", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Quality-focused zero administration neural-net", "SanfordBorerandRuecker59@hotmail.com", "Sanford, Borer and Ruecker" },
                    { new Guid("10439852-4816-43e2-b65d-f62f38a63597"), "306 Willard Well, Lilianmouth, Guatemala", new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Automated cohesive protocol", "Kuhn-Beatty.Koepp18@yahoo.com", "Kuhn - Beatty" },
                    { new Guid("15b7208b-eb17-4a51-ba76-17afbbf96068"), "01603 Parker Harbor, Curtishaven, Belgium", new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Horizontal homogeneous local area network", "KrajcikMcCulloughandKassulke.Hermiston@hotmail.com", "Krajcik, McCullough and Kassulke" },
                    { new Guid("19e8eeee-9782-4c18-8c1c-31e25bfe26e4"), "94042 Senger Divide, Aniyaville, Democratic People's Republic of Korea", new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Progressive executive interface", "HintzInc.Marquardt@yahoo.com", "Hintz Inc" },
                    { new Guid("1c2a5a04-eed8-4626-a3a7-3630bf3b0e95"), "061 Bria Island, South Dayneview, Libyan Arab Jamahiriya", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Multi-layered impactful system engine", "Cronin-Osinski_Jerde@gmail.com", "Cronin - Osinski" },
                    { new Guid("1e415287-85c2-4e91-a3a7-78ab80f29d41"), "308 Elenor Plain, New Alethahaven, Christmas Island", new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Optional 24/7 installation", "LindJaskolskiandJohns86@yahoo.com", "Lind, Jaskolski and Johns" },
                    { new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"), "747 Watsica Rapid, Schultzstad, Saint Lucia", new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Assimilated actuating knowledge user", "KuvalisInc_Pfeffer84@hotmail.com", "Kuvalis Inc" },
                    { new Guid("2c56dff9-7e7b-41ae-8dbf-cd0d7b55a51a"), "4611 Rodriguez Forks, Juliannefort, Cote d'Ivoire", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Persevering bandwidth-monitored utilisation", "JacobsMayerandPrice_Farrell@yahoo.com", "Jacobs, Mayer and Price" },
                    { new Guid("2ef952d7-2843-45e6-9fa2-b15b9383ff99"), "83801 Gia Plain, West Hermina, Virgin Islands, British", new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Distributed reciprocal software", "AnkundingSanfordandBlanda_Block@gmail.com", "Ankunding, Sanford and Blanda" },
                    { new Guid("2f2b69b5-08c5-4255-adf3-6dc04adbc448"), "53688 Sallie Hill, South Rebecca, Western Sahara", new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "User-centric zero tolerance website", "Franecki-Brown_Prohaska@gmail.com", "Franecki - Brown" },
                    { new Guid("3e444ecb-0eba-428c-9da5-fbc0606b6d47"), "55022 King Mews, Vicenteberg, Chad", new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "User-friendly reciprocal info-mediaries", "OKeefeInc.OConnell@hotmail.com", "O'Keefe Inc" },
                    { new Guid("40b9820c-9524-4196-a6c4-2c5120a8d185"), "66227 Skiles Square, New Vicenta, Saint Kitts and Nevis", new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Organized responsive project", "Torp-Klein38@gmail.com", "Torp - Klein" },
                    { new Guid("42dd62d7-9504-4805-bfe4-42d3ef3dac1e"), "795 Price Tunnel, Floydton, Micronesia", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Devolved heuristic instruction set", "StreichRyanandNitzsche75@hotmail.com", "Streich, Ryan and Nitzsche" },
                    { new Guid("439c0143-aa29-4f4a-be00-6c390ef9b39a"), "7174 Jaskolski Shores, Kundefurt, Slovenia", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Programmable next generation customer loyalty", "Cruickshank-Nitzsche_Kassulke70@yahoo.com", "Cruickshank - Nitzsche" },
                    { new Guid("47892d22-4bd2-458c-ac2d-730b131281f3"), "4880 Lueilwitz Meadows, New Everett, Aruba", new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Virtual context-sensitive policy", "RennerBeierandBruen.Fisher82@hotmail.com", "Renner, Beier and Bruen" },
                    { new Guid("658b1a98-7c9f-404c-a48e-1f1831b2c7fc"), "4881 Natasha Parkways, East Toni, Cook Islands", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Exclusive local data-warehouse", "SchusterandSons_Dickens@gmail.com", "Schuster and Sons" },
                    { new Guid("6dbd8a30-6580-4ac3-9c74-94441c39f686"), "8752 Marcia Brook, Lake Leorastad, French Guiana", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Phased neutral leverage", "BaileyGroup_Hand9@yahoo.com", "Bailey Group" },
                    { new Guid("7b71dcc1-7b36-431e-a69d-83c8a4be3555"), "21799 Swaniawski Orchard, Josephtown, Botswana", new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Front-line user-facing workforce", "Bogan-Morar_Harvey@yahoo.com", "Bogan - Morar" },
                    { new Guid("7dd582ba-f57b-4423-aac8-939ec85142cc"), "350 Lauretta Alley, Port Sylvester, Qatar", new Guid("e1938295-70cc-425a-8762-1790fcf44839"), "Enterprise-wide holistic solution", "JacobsHalvorsonandCarter_Bruen52@yahoo.com", "Jacobs, Halvorson and Carter" },
                    { new Guid("7f073178-d93a-4b97-a9fd-f50392699653"), "504 Daugherty Tunnel, Harrisfort, Timor-Leste", new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), "Synchronised systematic groupware", "BodeWeissnatandSchinner_Treutel29@hotmail.com", "Bode, Weissnat and Schinner" },
                    { new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"), "92947 Bell Mill, South Eloise, Norway", new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Team-oriented fresh-thinking success", "Johns-Cronin73@gmail.com", "Johns - Cronin" },
                    { new Guid("8b8e8e9c-05f8-42ce-9165-b97a44d6a61f"), "465 Morissette Hollow, Corwinland, Turkmenistan", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Secured multi-state firmware", "RunolfsdottirKuhicandHerzog57@hotmail.com", "Runolfsdottir, Kuhic and Herzog" },
                    { new Guid("8ebf7876-48ab-4a88-b72c-3886ad5e9e80"), "7681 Reynolds Inlet, South Pascale, Montenegro", new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Multi-tiered 4th generation function", "KuhlmanNaderandMohr_Blanda1@yahoo.com", "Kuhlman, Nader and Mohr" },
                    { new Guid("a0fa0891-1662-4776-bc2e-38cad5748ffc"), "8278 Keenan Flats, Port Maximillian, Belarus", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Profound radical matrices", "EbertLLC.Carroll25@hotmail.com", "Ebert LLC" },
                    { new Guid("a2667fd2-f3a3-4f16-bedb-88797a893d0d"), "3451 Wintheiser Parks, East Courtney, Cook Islands", new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Centralized 3rd generation algorithm", "GutkowskiRaynorandRodriguez.Schimmel14@gmail.com", "Gutkowski, Raynor and Rodriguez" },
                    { new Guid("a6273f31-2aff-461c-a660-f48b1d79831d"), "79558 Conn Bypass, Paucekberg, Falkland Islands (Malvinas)", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Face to face regional open system", "Quitzon-Mann.Hane@gmail.com", "Quitzon - Mann" },
                    { new Guid("ae095307-27ff-4328-87b9-249edce99907"), "462 Dudley Dale, Mosciskiburgh, Nicaragua", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Reactive holistic data-warehouse", "Grant-Baumbach36@gmail.com", "Grant - Baumbach" },
                    { new Guid("bbb1fe8b-3eee-4b01-bfb5-0ffd083f963e"), "389 Rodolfo Villages, Jeramieside, Serbia", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Centralized stable archive", "QuitzonGroup67@gmail.com", "Quitzon Group" },
                    { new Guid("bde0e665-959b-4735-9215-78f72214feb4"), "4596 Ali Fields, Lake Pattieview, Uruguay", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Fully-configurable intermediate middleware", "WatsicaInc_Heathcote@hotmail.com", "Watsica Inc" },
                    { new Guid("bf7ba1f4-ae44-41e6-a1bb-3bdf364c8405"), "329 Collins Mission, Feilhaven, Italy", new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), "Digitized system-worthy parallelism", "BoyerVolkmanandWilliamson_Cremin@hotmail.com", "Boyer, Volkman and Williamson" },
                    { new Guid("bf9d8238-5f41-4bde-894b-e2e3edea9fe0"), "76412 Boyle Circles, Lake Zoraview, Nepal", new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Programmable multi-tasking conglomeration", "Stiedemann-Erdman.Kunze17@gmail.com", "Stiedemann - Erdman" },
                    { new Guid("c1368eea-107e-4c03-8095-ab95a71d9d12"), "79362 Kayley Greens, Bernhardbury, Madagascar", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "User-friendly analyzing framework", "LindGroup.McDermott@yahoo.com", "Lind Group" },
                    { new Guid("c37c8613-1e50-495c-b539-13b435bb7b1b"), "1078 Myrtice Mall, North Waltonberg, Malaysia", new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Devolved 5th generation software", "VeumGroup.Runolfsdottir@hotmail.com", "Veum Group" },
                    { new Guid("cc9f943f-c54f-4e00-83a0-108e6f001c2c"), "59952 Alana Extension, North Ethyl, Bhutan", new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), "Configurable mobile moratorium", "RolfsonInc96@hotmail.com", "Rolfson Inc" },
                    { new Guid("cdcff493-05fd-4ed3-85a8-8b47810c2c5b"), "4819 Beier Mill, Jayceemouth, Egypt", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Innovative dedicated database", "GutkowskiLLC61@hotmail.com", "Gutkowski LLC" },
                    { new Guid("cf643469-5ed8-4783-9ba8-0acace88c69a"), "66288 Shanahan Forest, Lenoreland, Guyana", new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), "Polarised intermediate support", "Littel-Gottlieb87@yahoo.com", "Littel - Gottlieb" },
                    { new Guid("d0415a1e-b7c7-41d2-9e20-3a4c1a151748"), "52163 Koepp Spurs, Maciebury, American Samoa", new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Virtual eco-centric secured line", "Wolff-Stehr93@hotmail.com", "Wolff - Stehr" },
                    { new Guid("d753ed14-c342-4cf2-bfa2-fb6f5c3d39b9"), "0960 Mitchell Flat, West Mauricio, Lao People's Democratic Republic", new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Optimized client-server challenge", "KirlinGroup93@hotmail.com", "Kirlin Group" },
                    { new Guid("d9df7ae2-ba41-44fe-8688-f309bea046d5"), "79030 Green Union, West Percyport, United States Minor Outlying Islands", new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), "Organized demand-driven access", "RiceInc.OKon@gmail.com", "Rice Inc" },
                    { new Guid("e0b74872-5d26-4feb-90cd-55ff3edd9723"), "30257 Little Tunnel, North Manuelachester, Saint Lucia", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Universal cohesive policy", "SchinnerDaughertyandHalvorson76@gmail.com", "Schinner, Daugherty and Halvorson" },
                    { new Guid("e32b53d5-209e-456d-97ec-08083ae52cd5"), "83168 Purdy Ridge, South Kendall, United States of America", new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Networked zero administration toolset", "WatersConsidineandGoldner66@hotmail.com", "Waters, Considine and Goldner" },
                    { new Guid("e9ac3b35-e5eb-4445-be05-17f5ba75ef92"), "3784 Bill Crossroad, Pollichfurt, Saint Lucia", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Decentralized optimizing emulation", "Emard-Hartmann_Bernhard73@yahoo.com", "Emard - Hartmann" },
                    { new Guid("eb7f392b-39e6-4e4a-9412-66f270544b86"), "914 Ephraim Stream, Lavernshire, Israel", new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), "Devolved exuding system engine", "McKenzieInc.Kiehn@yahoo.com", "McKenzie Inc" },
                    { new Guid("f006df0e-cfc4-4685-833a-dc38c9d0a3ca"), "0960 Paucek Road, Lucindatown, Thailand", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Multi-lateral demand-driven workforce", "WatersInc42@gmail.com", "Waters Inc" },
                    { new Guid("f27861d3-1b27-4f07-8b53-f14dd18c9d3a"), "8606 Bogan Oval, North Kelly, Brunei Darussalam", new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), "Self-enabling holistic superstructure", "McGlynnandSons_Effertz@gmail.com", "McGlynn and Sons" },
                    { new Guid("f51ea93b-bbe6-4501-a3d4-8dcf2003f1f9"), "190 Adrian Green, Tevinshire, Mauritius", new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), "Team-oriented 3rd generation secured line", "WisokyKuphalandHahn_Pagac@hotmail.com", "Wisoky, Kuphal and Hahn" },
                    { new Guid("f9e6e7f4-2b14-48eb-80fa-35c0b8235d86"), "50927 Muller Ville, Pfefferhaven, Palau", new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), "Exclusive even-keeled approach", "McDermottRusselandDickens24@hotmail.com", "McDermott, Russel and Dickens" }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks-table",
                columns: new[] { "Id", "CustomersId", "Description", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("039cb3f1-f25f-4e99-aba8-295bc6ac7f9c"), new Guid("fdf006a0-fd23-4eec-a714-68c214d657ac"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e26c9870-c7bd-4fb3-aee3-be02767ee2ad") },
                    { new Guid("0470467e-5cd5-4d8d-87f7-c986a2d17775"), new Guid("29621f53-ca8d-4e1d-9347-446f304aaaa7"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3") },
                    { new Guid("06d9e5fe-943f-47ad-be62-62407a2a5aa6"), new Guid("4c0241aa-16e4-403e-bbb4-ef41eac1b91b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("7b0c42dd-636e-4e50-8ef0-7ab314f20864") },
                    { new Guid("0814c7e8-b15d-4d1f-b2f5-513f1dc69147"), new Guid("435e8acf-27b6-44c5-b39c-605f0afc23dc"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("94da780f-3505-422e-813b-3f27641ed828") },
                    { new Guid("087a2ccf-268d-4489-8261-5c74422aaa59"), new Guid("5e4786c7-8fc5-454b-abb5-fc8ee9dc0114"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("873ad122-3bc8-4978-bf2a-218e412c49c0") },
                    { new Guid("0f6cb690-dda4-4ea6-9cb1-5a6fade85cad"), new Guid("23652965-5f89-460b-a763-4ce427737a51"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29") },
                    { new Guid("11f365d1-93ba-4729-9ab0-b783ed4cd78d"), new Guid("5b8d9d6d-9f4f-400f-9bdb-9dc83e279d2a"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("94da780f-3505-422e-813b-3f27641ed828") },
                    { new Guid("138f88f7-46b3-4e11-8a57-f31121640606"), new Guid("d86c6913-fda2-49f9-85f0-4576773a3ee1"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("b7ba6b7b-ac79-4891-b894-d4611e27eb6c") },
                    { new Guid("17118b70-ba13-475c-b1ae-df3595adbacf"), new Guid("b0db5d70-a422-4522-80ee-ab9768e0ab4a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("e3d558f3-f6ff-4ef6-99af-3a857cd66c3c") },
                    { new Guid("198d40a9-9ca5-44d8-afbe-9fddd60caafc"), new Guid("1d8269a9-6fee-4313-a82b-47b2b323e1d1"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("15e9a113-3c52-45d2-abb2-69a984f91650") },
                    { new Guid("199fd50e-7758-404e-b8bb-ac371ab5bb82"), new Guid("5e4786c7-8fc5-454b-abb5-fc8ee9dc0114"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3") },
                    { new Guid("1de2f9e9-9c33-4bf1-b98e-957a06f9c651"), new Guid("e7811290-0646-4b7d-b10f-5c4a6c047089"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29") },
                    { new Guid("20d935eb-61d9-4cc3-b301-5fc4f449252a"), new Guid("a0cfe7da-86ba-4eca-bef1-9ee47c27da83"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("27338712-f315-4b2d-a89c-9bbc68c5d96b") },
                    { new Guid("21580c7e-8e07-46ef-9155-f874022eec6c"), new Guid("613c5d38-f65a-423a-8543-ac13f044663e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("95027e1d-c3ad-4496-b4a4-e5875409fbe1") },
                    { new Guid("25d46d4f-6e77-4a1b-9eac-7248339aed8a"), new Guid("7aef2f9f-a83a-4c9e-9b77-62876b6737ed"), "The Football Is Good For Training And Recreational Purposes", new Guid("6e8d8a5d-6f2d-4f71-b6de-171329e79391") },
                    { new Guid("3392fb57-702c-4cad-9e24-300280ae6505"), new Guid("453f7a11-b916-41ef-879f-8ecfeb6aa232"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("8da60164-a6b7-4434-8368-50d4f3fda0ed") },
                    { new Guid("3afd34be-7979-4d2d-81cf-9254a6ddd1dc"), new Guid("4622a023-b19d-4c0c-8664-700a62c4f506"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("27338712-f315-4b2d-a89c-9bbc68c5d96b") },
                    { new Guid("3b7febc8-ccca-494d-beff-4c2f6984508f"), new Guid("4c0241aa-16e4-403e-bbb4-ef41eac1b91b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("287e9929-6582-4698-a920-0458a4fd3404") },
                    { new Guid("3e6d047b-5e19-4956-bff4-587c60bdde08"), new Guid("945b7315-38e4-4962-9c5d-c4aede3b5b6e"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("74d25c20-69e8-45a4-8d96-380ac6564bfc") },
                    { new Guid("3f148613-475f-4f8f-bded-bd2890941015"), new Guid("a4edf60e-49de-44ad-b79b-d643add2f342"), "The Football Is Good For Training And Recreational Purposes", new Guid("cb108bc2-04e4-4ebe-8a80-ee82d2bd8c6d") },
                    { new Guid("41605ec0-e48c-434c-aad9-cad405c61e2d"), new Guid("d160096d-9192-48af-846e-361ee351eb32"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("41036d54-d5ae-47a9-b9fc-b7b9dfd1663a") },
                    { new Guid("453a2ccb-0ab3-4730-b2d0-f2072243c7a8"), new Guid("528e8456-76bd-4f2f-a588-4c9ffe68bfe8"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("287e9929-6582-4698-a920-0458a4fd3404") },
                    { new Guid("4606f6e2-b323-451b-b249-e0944eefeb30"), new Guid("1d8269a9-6fee-4313-a82b-47b2b323e1d1"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("8da60164-a6b7-4434-8368-50d4f3fda0ed") },
                    { new Guid("4c09b26e-b441-4ea3-a021-dc7f17625056"), new Guid("7aef2f9f-a83a-4c9e-9b77-62876b6737ed"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("b7ba6b7b-ac79-4891-b894-d4611e27eb6c") },
                    { new Guid("4d7a59ec-ed6f-4d5f-a867-b7a158c47f8d"), new Guid("453f7a11-b916-41ef-879f-8ecfeb6aa232"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("72a4fac6-0a24-4734-93da-6ff6c436c955") },
                    { new Guid("4e9eb89f-c612-43b7-a1ef-4e99257d7098"), new Guid("f6ad7aa9-508b-46f9-a5f7-76bf3e9d15d5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090") },
                    { new Guid("51124354-3bb9-48a0-a7e9-0317f2024f3d"), new Guid("9b306588-9764-41eb-8dad-21890b791786"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29") },
                    { new Guid("52191735-6c95-40a0-a876-10f7efdbfc28"), new Guid("7264d1e8-2efb-43a8-b52d-48f61cc3ed00"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("f85661c2-9184-47cf-b9ff-816dfa7c5eee") },
                    { new Guid("5a6553b0-5dc8-4f35-b372-24b86dd12326"), new Guid("668fd3b8-f9bb-4ad3-9e04-12057fe41b59"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("cc825e27-9f28-4cbf-9190-ab0e46db3d25") },
                    { new Guid("65e54592-dd2a-43a4-bf6d-02bb5de52a43"), new Guid("43275365-984a-4fde-9de2-da30de5ba5db"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d") },
                    { new Guid("69dae698-4171-4de2-82ea-f72440da770b"), new Guid("174a4db1-8a08-4f73-a9c4-7bd5fe2c147d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("37e89ea1-4595-42bc-93cb-31765744c9d7") },
                    { new Guid("69e698ca-3675-4436-9206-c462e931a895"), new Guid("cca36535-8e95-4d9f-b74a-ec51f74ac099"), "The Football Is Good For Training And Recreational Purposes", new Guid("3314db03-e390-406e-ae87-9bf5a511c2a4") },
                    { new Guid("6ccd1a9a-1267-421b-813e-754e189ef59d"), new Guid("85c2c617-29b7-4dcf-be9f-efc29480aaf8"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42") },
                    { new Guid("730eedf5-25b1-4e63-bcf5-01b964e32fec"), new Guid("5fb30673-1791-4b01-8c53-f0064fa12d57"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("cfc4184a-e4df-46d5-9295-4477f78cb79e") },
                    { new Guid("73218f6c-dcd8-457e-9fe5-46f533c02d77"), new Guid("381b5a7d-faee-448a-93f2-b27ca658e458"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("d79a301d-abce-469c-9579-e8392a43a6ed") },
                    { new Guid("735e44ed-71db-4f2b-9d46-eb5785bab877"), new Guid("38c9887f-4106-4b1c-bcc0-70983a7a9a28"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("cf631b08-8971-40f0-83d4-998b41d7a6c5") },
                    { new Guid("7634bb94-71c0-488b-b382-b4d98085f746"), new Guid("5fb30673-1791-4b01-8c53-f0064fa12d57"), "The Football Is Good For Training And Recreational Purposes", new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d") },
                    { new Guid("7669b61d-dc9c-4f95-bd0b-5abdc22c86f2"), new Guid("cb7b8924-0d64-48f0-83d8-273d5ed4b692"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("8a9834c6-df40-4227-92bd-d705192b564e") },
                    { new Guid("77ed728e-d9ff-4c35-9efa-70aa4647342d"), new Guid("6837a98a-5d3c-4396-8f61-41df515f73bb"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("7b52545c-9d53-4b90-bb3c-3e0d772359db") },
                    { new Guid("78169585-f892-4c6b-b52c-9312da91ef64"), new Guid("c03f9473-92d5-4888-b3d5-6a5a5752864f"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("74d25c20-69e8-45a4-8d96-380ac6564bfc") },
                    { new Guid("795e0581-2882-48e0-bd11-95bcf6435aa2"), new Guid("4c769826-ad2d-4606-bd54-dc7f0bfe498f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("7e3302da-1ea7-4962-ace5-0fb8d9e9db8b"), new Guid("8a92683f-857c-4098-a06b-2af504783426"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("50bebfdb-4443-4ffa-9519-40f35b8bc451") },
                    { new Guid("81c8af6f-2249-4afd-96f4-f50d5fb4e521"), new Guid("41481b34-6a62-4495-896e-b95200bcc713"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("8b9b2789-f88d-4b0a-8dd2-72b51d69af38") },
                    { new Guid("830a4391-7d29-4f93-945d-d4f7cb84a25f"), new Guid("95c08215-2a62-4b11-bda9-6a8074750845"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65") },
                    { new Guid("832b3da0-5ac4-475d-9e2e-1d2fa5bb32ec"), new Guid("4e237dc2-ec6b-4975-9442-d24404ed8018"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("d3bff4ba-727d-4a58-a462-db81200dd655") },
                    { new Guid("849f3f6b-c4ee-4282-a3fc-cf79b34a2307"), new Guid("9b306588-9764-41eb-8dad-21890b791786"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("27338712-f315-4b2d-a89c-9bbc68c5d96b") },
                    { new Guid("856eabf5-9ed3-4e5e-b843-a19aeeb69328"), new Guid("f6ad7aa9-508b-46f9-a5f7-76bf3e9d15d5"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("1d2612be-1a6f-4939-a7b1-ee2d1cf75bd4") },
                    { new Guid("8604ee61-5153-4754-8d6f-4891f1d7f9a3"), new Guid("0b89986d-107b-438c-9b89-e6cc5bc4333b"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("3081c486-dabc-4d3e-99ba-802bab9f46fe") },
                    { new Guid("874c9b1d-77fc-4f74-a226-1c617b294d3e"), new Guid("0f2d5d7f-5528-4c21-8c5f-e5fea3f17b6e"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("09b0f883-b9dd-47b0-a36c-007dc71cb139") },
                    { new Guid("891ee147-8b8d-4ebc-992a-5d3f7be6743f"), new Guid("db1b5994-75df-48c6-abbf-0bfff0e8e4eb"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("f7f46857-0bde-4234-a8ef-4a5ef143d2a2") },
                    { new Guid("90d7eb47-1c39-4762-97d2-d47d652b36b5"), new Guid("2eefe12a-bb52-49a4-ab41-2a7790085d2a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3") },
                    { new Guid("920caa69-308d-4fb2-8a5c-0b35d376a8cf"), new Guid("9385cd32-b9bb-44a8-88ec-93f43484789d"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42") },
                    { new Guid("94a74003-b845-437c-9e0e-964d78acba5d"), new Guid("945b7315-38e4-4962-9c5d-c4aede3b5b6e"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("210f8839-2f6f-4de2-9e29-469c83476018") },
                    { new Guid("9826783c-e401-46fc-9850-a9c89c23a805"), new Guid("9e600a3d-ef9c-4ab3-aa50-c2cb1e32f4f0"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1fdefd13-f245-42db-a1f3-08ff1e4dd30c") },
                    { new Guid("9a827809-06e2-476d-a92b-fbafdb617b26"), new Guid("43275365-984a-4fde-9de2-da30de5ba5db"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("2f07ec68-a27b-4012-8e8d-6c58095922b6") },
                    { new Guid("9fd2c228-e483-42e4-8351-2a9b294ff6f6"), new Guid("834cac26-61f7-4d94-b0f3-9a81dd2e83cf"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("88e21e38-3658-4c01-97a4-6b6423d656f6") },
                    { new Guid("a463c5ef-8eda-475f-a408-cb5410445eb2"), new Guid("12b68d33-b707-4b7b-b3d8-f543d529a6a6"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("363b8af6-9ead-43dc-b306-c1e77a057a5b") },
                    { new Guid("a924764d-9275-4d91-9338-e76d817e437d"), new Guid("b5aa6d38-6827-4443-a86f-09864d03808a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("bfd05140-60ec-48d4-84c9-078948eef632") },
                    { new Guid("a92fc9f7-3117-4d62-95c1-b428fd4604ce"), new Guid("86882691-2b74-4a86-bc6c-3af4628dbd43"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("1d2612be-1a6f-4939-a7b1-ee2d1cf75bd4") },
                    { new Guid("af05e25c-ebb6-4954-8fbd-30d182b7da0b"), new Guid("a0cfe7da-86ba-4eca-bef1-9ee47c27da83"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("f85661c2-9184-47cf-b9ff-816dfa7c5eee") },
                    { new Guid("af1b11ac-d2c1-4968-bf4d-870328850da9"), new Guid("468b4cc7-ce02-4caa-8938-dd59609c707c"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("2f07ec68-a27b-4012-8e8d-6c58095922b6") },
                    { new Guid("b2669318-25a4-4c6b-b02c-a5e6978f615c"), new Guid("c9b7f669-bb10-42b4-86f1-990674e46d88"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("855117f2-2ae4-474a-8d5c-198a7e133fe4") },
                    { new Guid("b332241e-a1e1-42ab-b0e6-b6149729ba51"), new Guid("677c28d2-668a-4167-b8e6-a6d59f958380"), "The Football Is Good For Training And Recreational Purposes", new Guid("95027e1d-c3ad-4496-b4a4-e5875409fbe1") },
                    { new Guid("b48ce4bb-c816-4d6a-bb23-fb261bbf846c"), new Guid("d7373145-5235-4cf6-83d9-aa48337571ac"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("7c9f6f5e-89e0-4234-b2c4-ab58a1c808fe") },
                    { new Guid("b667175b-285f-40af-b3bb-28446699cdbe"), new Guid("d66040b2-75b8-44a7-82b6-108263c3963c"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d") },
                    { new Guid("b84e345c-ec4f-4e47-b592-b36dacb5779d"), new Guid("ea54c1d3-7c77-478a-81b1-7ffcbd46defb"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("102af34b-9a44-4933-a28f-a699efa8200d") },
                    { new Guid("b994bd76-e786-48ef-bad5-4126335c1745"), new Guid("f6d8fb61-d35d-4c78-96f1-68e16051b768"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29") },
                    { new Guid("bd3343db-c4d7-45a4-9888-06472aac20c2"), new Guid("44db09d3-35ea-46d1-b086-359904f920bb"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("3891c2e2-260e-4e72-9631-7688af2df839") },
                    { new Guid("bdc366a1-c935-471e-8b6f-14043da5db60"), new Guid("9e600a3d-ef9c-4ab3-aa50-c2cb1e32f4f0"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("be646521-00bb-4969-8271-a7ddc1a4a9f2"), new Guid("4aebd8f3-f593-4088-a061-071a35b78681"), "The Football Is Good For Training And Recreational Purposes", new Guid("a84cebab-0d83-49a7-b7d0-1a4cdb725c43") },
                    { new Guid("c0055e83-ac22-4268-a141-c9a099605fc6"), new Guid("e0ee3ab2-0b65-4569-950f-adefe865daa1"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("2f07ec68-a27b-4012-8e8d-6c58095922b6") },
                    { new Guid("c49d8d07-737e-4c1e-8a12-8f140b0beb25"), new Guid("cb7b8924-0d64-48f0-83d8-273d5ed4b692"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("b7ba6b7b-ac79-4891-b894-d4611e27eb6c") },
                    { new Guid("c529824e-3119-4ce0-bca6-1f2ea1ce2d06"), new Guid("18132e54-dae8-4132-ac48-6009693c3929"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("82b676b6-59db-4ddf-9121-f9b621cd455c") },
                    { new Guid("c6758c54-9958-4ad2-bb94-e5d5696f9751"), new Guid("c323ba07-1b10-48d1-a9ce-ea7440118b02"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("fa5bfeb2-245b-43be-acdc-76452fcabdc9") },
                    { new Guid("c719c22c-5b9d-414d-9cc9-7941a39b9eba"), new Guid("c4063b44-7bb0-4859-b887-1af1ab7647ff"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("7b0c42dd-636e-4e50-8ef0-7ab314f20864") },
                    { new Guid("cf94d1ed-9b14-4ac2-b3a4-ab7e13067ee3"), new Guid("6df03384-bdad-4c2b-8433-69c3f3f68bdc"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("855117f2-2ae4-474a-8d5c-198a7e133fe4") },
                    { new Guid("d2ed86c3-882a-44d4-9813-850f5e22322c"), new Guid("790acf76-387d-46df-99f1-8632fca9facd"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("bc426f66-2fb3-44d5-adc8-2bfaa9cd3f28") },
                    { new Guid("d5bb33e7-fd6d-4aa4-ad08-86ca0c33d0a3"), new Guid("396d90aa-f7c5-41a8-8287-e05204b4c2c0"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("d643b8e5-0b5c-498b-87bd-6ec9150c1f35") },
                    { new Guid("d78b9bd4-435b-46df-99d2-9234cc2149ea"), new Guid("9e600a3d-ef9c-4ab3-aa50-c2cb1e32f4f0"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("77f6623b-08d2-481e-bf85-5040a7eb135a") },
                    { new Guid("d82cf4ed-cc71-4565-adae-211d9828aebd"), new Guid("e0ee3ab2-0b65-4569-950f-adefe865daa1"), "The Football Is Good For Training And Recreational Purposes", new Guid("74d25c20-69e8-45a4-8d96-380ac6564bfc") },
                    { new Guid("d897921f-1235-427f-b7fa-30993692c148"), new Guid("d7373145-5235-4cf6-83d9-aa48337571ac"), "The Football Is Good For Training And Recreational Purposes", new Guid("400a1eb4-95cf-4c20-a843-b96cb4c14f33") },
                    { new Guid("dc326bb4-9496-4526-ae33-e916fea928e5"), new Guid("396d90aa-f7c5-41a8-8287-e05204b4c2c0"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("e3d558f3-f6ff-4ef6-99af-3a857cd66c3c") },
                    { new Guid("dc72d9f2-6a0c-490a-a53c-de0d785d2439"), new Guid("55341d2f-56db-4994-9107-92c4a7b5e988"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("873ad122-3bc8-4978-bf2a-218e412c49c0") },
                    { new Guid("ddd31763-17c8-4d69-9564-b526aa387b34"), new Guid("174a4db1-8a08-4f73-a9c4-7bd5fe2c147d"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("2de3dc7d-7a34-4b86-a48a-ab13b61ad379") },
                    { new Guid("e34216e5-489a-49d1-aab1-dabb48d80d6b"), new Guid("958ded78-d7cd-4431-b359-14774fe82db4"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("09b0f883-b9dd-47b0-a36c-007dc71cb139") },
                    { new Guid("e3f46127-4a1c-4723-81e8-1146eab4d0db"), new Guid("0edaf26c-0974-4a61-beef-5b25d2c3102b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7118351c-8397-40ee-a11f-b73bfe4e1eb0") },
                    { new Guid("e73cf9af-b2d9-44fc-97c9-f8c41434b5ae"), new Guid("0a063f06-f9b3-4c36-95af-46642a3ae174"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("e26c9870-c7bd-4fb3-aee3-be02767ee2ad") },
                    { new Guid("ea7e3b4e-e255-481f-9cd1-fa68e5e4d144"), new Guid("914b5fab-01b9-4197-bf7a-8af4f4481065"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("400a1eb4-95cf-4c20-a843-b96cb4c14f33") },
                    { new Guid("ec3a3332-c27d-40c2-b7ff-4975e6c16816"), new Guid("8a92683f-857c-4098-a06b-2af504783426"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("cfc4184a-e4df-46d5-9295-4477f78cb79e") },
                    { new Guid("ecd0bc0f-7d20-437b-9dd2-523bd6f78431"), new Guid("4e9dce03-c935-416d-8091-da58af65ee06"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("8b92030f-7005-4f57-96ce-54efe8bf7ccb") },
                    { new Guid("edb7021c-f8db-45f6-889b-3d7f5fa2f35e"), new Guid("f85834df-9460-4381-a426-e5198991db19"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("41036d54-d5ae-47a9-b9fc-b7b9dfd1663a") },
                    { new Guid("ee51def1-ca00-44d1-8994-e114f2530d3d"), new Guid("9b306588-9764-41eb-8dad-21890b791786"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("82b676b6-59db-4ddf-9121-f9b621cd455c") },
                    { new Guid("f1753f66-4ef9-44a7-961a-ebb507e79293"), new Guid("5568fc18-7d0b-4052-b373-f6d079404a24"), "The Football Is Good For Training And Recreational Purposes", new Guid("88e21e38-3658-4c01-97a4-6b6423d656f6") },
                    { new Guid("f3fb25c6-78cf-4df6-ab35-1fec4490e4a7"), new Guid("f6ad7aa9-508b-46f9-a5f7-76bf3e9d15d5"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("37e89ea1-4595-42bc-93cb-31765744c9d7") },
                    { new Guid("f4bbbaa9-84bb-44be-880d-e056b953cb70"), new Guid("b5aa6d38-6827-4443-a86f-09864d03808a"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("acc706fb-3a3c-4576-a3f3-116dd4c7ec4b") },
                    { new Guid("f706f6c4-f1e0-43bb-8433-fe2dd65c32be"), new Guid("1d8269a9-6fee-4313-a82b-47b2b323e1d1"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("2de3dc7d-7a34-4b86-a48a-ab13b61ad379") },
                    { new Guid("f7e1422c-0000-4a62-8592-a911ca08a75d"), new Guid("58d0a27e-128e-423e-9a80-ec399285d062"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("48ab48b0-cba7-479a-bf98-62f135413e18") },
                    { new Guid("fce7cbf9-bc7f-41ac-ac79-5fdfc670088e"), new Guid("d7373145-5235-4cf6-83d9-aa48337571ac"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("210f8839-2f6f-4de2-9e29-469c83476018") },
                    { new Guid("fd6f7e43-0a05-48db-bfe4-13438cfbd19d"), new Guid("8a92683f-857c-4098-a06b-2af504783426"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("febdf02a-5689-45e7-910a-18aba54c8f1f"), new Guid("18132e54-dae8-4132-ac48-6009693c3929"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("894b9207-8de7-4308-b07e-b6a6ab7c8720") }
                });

            migrationBuilder.InsertData(
                table: "Ingredients-table",
                columns: new[] { "Id", "CountriesId", "DistributorsId", "Title" },
                values: new object[,]
                {
                    { new Guid("00fba144-1f24-44ed-9b79-b6c503e63945"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("ae095307-27ff-4328-87b9-249edce99907"), "Pants" },
                    { new Guid("035babe5-9a5d-42d4-8e07-fc050d3ddbd1"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("8ebf7876-48ab-4a88-b72c-3886ad5e9e80"), "Bike" },
                    { new Guid("0446fcb3-3508-46e0-be46-42c8879e4f91"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("2ef952d7-2843-45e6-9fa2-b15b9383ff99"), "Cheese" },
                    { new Guid("05582433-8955-425a-8964-edf36e8441c3"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("e32b53d5-209e-456d-97ec-08083ae52cd5"), "Bike" },
                    { new Guid("05bd7eed-24c2-41e3-8892-31f8b07df909"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("6dbd8a30-6580-4ac3-9c74-94441c39f686"), "Keyboard" },
                    { new Guid("06dc4dfc-d909-40a5-aef5-804bbe1e8a40"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("f006df0e-cfc4-4685-833a-dc38c9d0a3ca"), "Chips" },
                    { new Guid("0ae1be56-abb1-428f-b9d3-001ef648e7c5"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("cdcff493-05fd-4ed3-85a8-8b47810c2c5b"), "Shirt" },
                    { new Guid("0cdff66e-912c-48bd-a56b-d0f8c6be0128"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("c1368eea-107e-4c03-8095-ab95a71d9d12"), "Tuna" },
                    { new Guid("1469671c-b6c1-486a-989d-b684e547f753"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("0165197c-e010-4e57-8305-d0076bc99dcb"), "Salad" },
                    { new Guid("182c8ab8-3847-4a06-a6a4-0fddd2e8325d"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("c1368eea-107e-4c03-8095-ab95a71d9d12"), "Fish" },
                    { new Guid("18526c35-8620-4779-bb17-06e055f4bae3"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("0165197c-e010-4e57-8305-d0076bc99dcb"), "Soap" },
                    { new Guid("1d953171-55db-4aca-b3eb-672cf65a37cd"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("19e8eeee-9782-4c18-8c1c-31e25bfe26e4"), "Shirt" },
                    { new Guid("1e586dd2-7884-4a38-8722-f54fa5b40ea3"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("f9e6e7f4-2b14-48eb-80fa-35c0b8235d86"), "Tuna" },
                    { new Guid("1f178981-7702-47bc-805f-7c60c9d37b69"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("06b24408-e8cb-44a6-b782-58ecb9529dfd"), "Soap" },
                    { new Guid("2028425c-292b-42f6-bfb3-9d24738ea3e8"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"), "Pants" },
                    { new Guid("2363019e-e99a-467f-9ded-dadd9152e15e"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("bbb1fe8b-3eee-4b01-bfb5-0ffd083f963e"), "Chair" },
                    { new Guid("247201c7-7e3c-497b-8a56-2c3d04c0284c"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("7b71dcc1-7b36-431e-a69d-83c8a4be3555"), "Table" },
                    { new Guid("25cc98b6-8064-4f70-8624-20f719985207"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("eb7f392b-39e6-4e4a-9412-66f270544b86"), "Chair" },
                    { new Guid("25e20ed1-f4b3-451e-b183-a150a59a8ae9"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("06ee643a-2b91-415e-8752-94e8d8aa3467"), "Gloves" },
                    { new Guid("2639191d-ca75-4caf-9791-b98dc90db4b4"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("15b7208b-eb17-4a51-ba76-17afbbf96068"), "Mouse" },
                    { new Guid("27f01d35-0d0e-409d-b9cb-831a0f480b7d"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("d9df7ae2-ba41-44fe-8688-f309bea046d5"), "Ball" },
                    { new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("f006df0e-cfc4-4685-833a-dc38c9d0a3ca"), "Salad" },
                    { new Guid("4374623b-91b4-4192-87b6-82fb296fdc98"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("d9df7ae2-ba41-44fe-8688-f309bea046d5"), "Computer" },
                    { new Guid("457b77d7-eeee-4f9d-b629-031fff6e66a2"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("cc9f943f-c54f-4e00-83a0-108e6f001c2c"), "Sausages" },
                    { new Guid("462d0486-ecd7-45eb-8c79-8ec7892b7524"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("2f2b69b5-08c5-4255-adf3-6dc04adbc448"), "Chair" },
                    { new Guid("48fedacb-f00b-43aa-a7c7-4ab2ce49f89d"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("d9df7ae2-ba41-44fe-8688-f309bea046d5"), "Soap" },
                    { new Guid("491304c1-9405-46e9-866e-de6321cd900a"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("f51ea93b-bbe6-4501-a3d4-8dcf2003f1f9"), "Ball" },
                    { new Guid("4c2a73da-348a-4567-9fc6-20828a12eeff"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("19e8eeee-9782-4c18-8c1c-31e25bfe26e4"), "Salad" },
                    { new Guid("4f30dcc5-4c72-4cf1-a790-9816e4d5a0a6"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("10439852-4816-43e2-b65d-f62f38a63597"), "Keyboard" },
                    { new Guid("5ad1734f-8c4b-4127-918f-dbd2b48374a6"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("f51ea93b-bbe6-4501-a3d4-8dcf2003f1f9"), "Soap" },
                    { new Guid("5ed263b4-30e8-4219-8d05-5323a910cab7"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("bf7ba1f4-ae44-41e6-a1bb-3bdf364c8405"), "Soap" },
                    { new Guid("60faf1ba-d384-454e-a5fd-0055662a2387"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("10439852-4816-43e2-b65d-f62f38a63597"), "Cheese" },
                    { new Guid("66557298-7891-41f4-9d9b-c602b6f6d25e"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("e9ac3b35-e5eb-4445-be05-17f5ba75ef92"), "Tuna" },
                    { new Guid("672a1ee2-d7d4-4b0f-b40c-cae6c7ec26ee"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("06ee643a-2b91-415e-8752-94e8d8aa3467"), "Shirt" },
                    { new Guid("67c7d05e-733c-460b-82e9-16bb9b794807"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("15b7208b-eb17-4a51-ba76-17afbbf96068"), "Table" },
                    { new Guid("6c2c2cfe-099e-4197-9c48-8448399f477b"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"), "Fish" },
                    { new Guid("6c5ac107-55b6-4ca1-b2db-56f440d77468"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("bf9d8238-5f41-4bde-894b-e2e3edea9fe0"), "Chair" },
                    { new Guid("6e5cb8e9-dbf4-4fc4-8476-91293113361a"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("2f2b69b5-08c5-4255-adf3-6dc04adbc448"), "Ball" },
                    { new Guid("706f525d-d5f8-4c59-ab7d-ecb70c4b0536"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("658b1a98-7c9f-404c-a48e-1f1831b2c7fc"), "Gloves" },
                    { new Guid("70df3deb-a92a-4205-9100-7e3430bc1e53"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"), "Sausages" },
                    { new Guid("71877662-ba0c-495b-bd3c-a5b7dbefe184"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("8b8e8e9c-05f8-42ce-9165-b97a44d6a61f"), "Towels" },
                    { new Guid("74d185a7-c06b-4085-9634-2f2fcb66eb0c"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("7dd582ba-f57b-4423-aac8-939ec85142cc"), "Salad" },
                    { new Guid("75f293cf-a9d5-487a-afe5-0a9183b562c1"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("7f073178-d93a-4b97-a9fd-f50392699653"), "Pizza" },
                    { new Guid("774a5209-4913-4be9-9434-0bcf2c9065c3"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("439c0143-aa29-4f4a-be00-6c390ef9b39a"), "Chicken" },
                    { new Guid("77ba700a-9834-4a71-b9ee-a7f833e2619f"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("f27861d3-1b27-4f07-8b53-f14dd18c9d3a"), "Car" },
                    { new Guid("7ccbc01f-ab39-46b7-b422-67c375b236fe"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("cf643469-5ed8-4783-9ba8-0acace88c69a"), "Towels" },
                    { new Guid("7ddc42d7-2ee6-4ab7-a3a8-076ae9d2a541"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("06b24408-e8cb-44a6-b782-58ecb9529dfd"), "Pizza" },
                    { new Guid("858086a4-47af-4314-93e1-8781e16cfd7e"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"), "Mouse" },
                    { new Guid("896d1c81-345d-4d7f-a2a5-8ab92e678f25"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("ae095307-27ff-4328-87b9-249edce99907"), "Mouse" },
                    { new Guid("8ad4de25-deaa-43c7-836a-f158fa7e588a"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("1e415287-85c2-4e91-a3a7-78ab80f29d41"), "Table" },
                    { new Guid("8d5ac3a2-2364-4d1b-b473-808a451ecdca"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("47892d22-4bd2-458c-ac2d-730b131281f3"), "Keyboard" },
                    { new Guid("8fc745de-65a1-4ed0-8797-9021c0b28351"), new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"), new Guid("06ee643a-2b91-415e-8752-94e8d8aa3467"), "Computer" },
                    { new Guid("905689b8-9550-4ab2-b653-916979ba3410"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("bf7ba1f4-ae44-41e6-a1bb-3bdf364c8405"), "Table" },
                    { new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("f006df0e-cfc4-4685-833a-dc38c9d0a3ca"), "Salad" },
                    { new Guid("94a97825-d121-4260-bf37-99db9d3ef31b"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"), "Hat" },
                    { new Guid("961d6ff8-5ad1-4792-a2ef-a4b8752d7aa5"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("7f073178-d93a-4b97-a9fd-f50392699653"), "Salad" },
                    { new Guid("9ee3f651-1179-4b17-8a22-b9ab95bc7311"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("d0415a1e-b7c7-41d2-9e20-3a4c1a151748"), "Car" },
                    { new Guid("9fc820b0-5ba8-4167-89d2-eddcdd26ebaf"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"), "Salad" },
                    { new Guid("9ff9cf4e-0b5f-40c6-988d-06264ea414f5"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("40b9820c-9524-4196-a6c4-2c5120a8d185"), "Shirt" },
                    { new Guid("a1e0a92f-9811-4b28-b2e1-c19da225897a"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("c1368eea-107e-4c03-8095-ab95a71d9d12"), "Shoes" },
                    { new Guid("a3192d8a-1caf-43ea-8612-6f79932b204b"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("e32b53d5-209e-456d-97ec-08083ae52cd5"), "Towels" },
                    { new Guid("a465b151-e032-4b0f-9988-e091f21b20ec"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("f9e6e7f4-2b14-48eb-80fa-35c0b8235d86"), "Towels" },
                    { new Guid("a4e2c8ce-1b22-43ea-bf52-6dea95c7e077"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("eb7f392b-39e6-4e4a-9412-66f270544b86"), "Cheese" },
                    { new Guid("a74a1172-1e8d-4b7c-86dc-b30b7fe55bb0"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("8b8e8e9c-05f8-42ce-9165-b97a44d6a61f"), "Chicken" },
                    { new Guid("a7f27380-56c1-434c-95f9-707cf5c8e0ee"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("2c56dff9-7e7b-41ae-8dbf-cd0d7b55a51a"), "Gloves" },
                    { new Guid("a8ec13af-7403-4af3-8c01-bd6f85958d21"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("40b9820c-9524-4196-a6c4-2c5120a8d185"), "Hat" },
                    { new Guid("a99339c9-1e39-498f-8ba1-d0825fcc908b"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("47892d22-4bd2-458c-ac2d-730b131281f3"), "Ball" },
                    { new Guid("ad51d056-f92e-4524-8132-3794371109b7"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("eb7f392b-39e6-4e4a-9412-66f270544b86"), "Ball" },
                    { new Guid("ad7d91fb-f972-4d67-b97f-712807889e3a"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("8ebf7876-48ab-4a88-b72c-3886ad5e9e80"), "Fish" },
                    { new Guid("b061cf29-d69e-4e26-8e94-7626c7d07c31"), new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"), new Guid("8b8e8e9c-05f8-42ce-9165-b97a44d6a61f"), "Chips" },
                    { new Guid("b26fe17c-d513-4a79-a020-cf22d70fc7a8"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"), "Bike" },
                    { new Guid("b50f5e2b-7112-4438-9b3f-051194091844"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("8ebf7876-48ab-4a88-b72c-3886ad5e9e80"), "Fish" },
                    { new Guid("baeb1822-2be8-4837-8a7a-3bb2f1b5063f"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("a2667fd2-f3a3-4f16-bedb-88797a893d0d"), "Hat" },
                    { new Guid("bc130b58-6eec-4d53-9f0c-cc9d468c8b6e"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("06b24408-e8cb-44a6-b782-58ecb9529dfd"), "Computer" },
                    { new Guid("bfbb540a-3a41-4f90-a7a6-b649da49277c"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("6dbd8a30-6580-4ac3-9c74-94441c39f686"), "Car" },
                    { new Guid("c04016dc-8ca9-4df0-a3b2-273150a4bdb0"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("cf643469-5ed8-4783-9ba8-0acace88c69a"), "Chicken" },
                    { new Guid("c431a66b-c07f-42f9-a3df-0eb92216f489"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("42dd62d7-9504-4805-bfe4-42d3ef3dac1e"), "Chips" },
                    { new Guid("c9f31925-273d-4801-bdb8-eff290218b34"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"), "Bacon" },
                    { new Guid("ca124c0c-d9b2-499d-8ba0-bc9b055bdaa5"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("1c2a5a04-eed8-4626-a3a7-3630bf3b0e95"), "Soap" },
                    { new Guid("ca801c33-855e-4212-9607-fea9e1010a7e"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("cdcff493-05fd-4ed3-85a8-8b47810c2c5b"), "Chicken" },
                    { new Guid("cb0af761-0659-4b63-b4b1-4569dacb0e4e"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("e32b53d5-209e-456d-97ec-08083ae52cd5"), "Chicken" },
                    { new Guid("cbc7707e-9429-433d-aef3-9e424b5b1108"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("10439852-4816-43e2-b65d-f62f38a63597"), "Shoes" },
                    { new Guid("cc8a13f4-c734-44d9-8222-5dbafa38082b"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("7f073178-d93a-4b97-a9fd-f50392699653"), "Soap" },
                    { new Guid("d1bdba81-9fe0-48b7-ab60-080407724dc0"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("2f2b69b5-08c5-4255-adf3-6dc04adbc448"), "Table" },
                    { new Guid("d1df1c09-8a6e-47f1-8c91-3d1813bffd29"), new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"), new Guid("d9df7ae2-ba41-44fe-8688-f309bea046d5"), "Keyboard" },
                    { new Guid("db35c045-7b37-45c9-a1d2-cbaa981941ab"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("8b8e8e9c-05f8-42ce-9165-b97a44d6a61f"), "Sausages" },
                    { new Guid("db4b778b-c82c-49ca-b238-5b79b6090e77"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("47892d22-4bd2-458c-ac2d-730b131281f3"), "Chips" },
                    { new Guid("dbdf2ee6-1c8b-4fab-a8ca-4938607ad809"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"), "Towels" },
                    { new Guid("e16594ac-7982-409b-bc60-13b1024234dd"), new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"), new Guid("cf643469-5ed8-4783-9ba8-0acace88c69a"), "Gloves" },
                    { new Guid("e177fa12-b498-4944-9226-ddae0efe432d"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("f27861d3-1b27-4f07-8b53-f14dd18c9d3a"), "Chips" },
                    { new Guid("e4f1bcfd-105e-4683-a1c6-582eb3b9c091"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("d753ed14-c342-4cf2-bfa2-fb6f5c3d39b9"), "Cheese" },
                    { new Guid("ea4ffed4-9df7-40e2-9e38-7b3fc3f5d7ed"), new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"), new Guid("f9e6e7f4-2b14-48eb-80fa-35c0b8235d86"), "Car" },
                    { new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"), new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"), new Guid("40b9820c-9524-4196-a6c4-2c5120a8d185"), "Mouse" },
                    { new Guid("eb2116c9-a309-422a-aaeb-45b37f519272"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"), "Keyboard" },
                    { new Guid("eeab6aec-8e7d-4e78-92fd-b386d45bde74"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("a2667fd2-f3a3-4f16-bedb-88797a893d0d"), "Bike" },
                    { new Guid("ef8750e2-7147-4891-9685-79aeb8064541"), new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"), new Guid("eb7f392b-39e6-4e4a-9412-66f270544b86"), "Bike" },
                    { new Guid("f42ca59f-c6fc-48b2-9501-7c8f06db53e9"), new Guid("e1938295-70cc-425a-8762-1790fcf44839"), new Guid("c1368eea-107e-4c03-8095-ab95a71d9d12"), "Chair" },
                    { new Guid("f73ff307-c4f3-4ea4-8ba1-e32ef11f452d"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("7dd582ba-f57b-4423-aac8-939ec85142cc"), "Hat" },
                    { new Guid("f8dc0381-9903-4dc3-88b3-cd1fa9196062"), new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"), new Guid("e32b53d5-209e-456d-97ec-08083ae52cd5"), "Computer" },
                    { new Guid("fc277ae7-9a6a-4eb6-af43-1303043d7fe5"), new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"), new Guid("c37c8613-1e50-495c-b539-13b435bb7b1b"), "Soap" }
                });

            migrationBuilder.InsertData(
                table: "IngredientsProducts-table",
                columns: new[] { "Id", "IngredientsId", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("01f57fca-cb50-4772-8485-79910fb1520f"), new Guid("a8ec13af-7403-4af3-8c01-bd6f85958d21"), new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42") },
                    { new Guid("03bcaa2b-3a8f-4a11-9844-f16bf4fceecc"), new Guid("48fedacb-f00b-43aa-a7c7-4ab2ce49f89d"), new Guid("fdbac539-f8b0-4412-853d-285639821c09") },
                    { new Guid("03dbab7b-b9de-4e08-b854-05e72ec24284"), new Guid("05582433-8955-425a-8964-edf36e8441c3"), new Guid("1696fa95-5d72-4832-af77-abf902fb6233") },
                    { new Guid("03f7f204-7b8c-4bd8-9e95-ab674491a46d"), new Guid("2363019e-e99a-467f-9ded-dadd9152e15e"), new Guid("466f5007-75ee-4c02-8301-b866eebfc0bf") },
                    { new Guid("0510f8dc-ff1f-4dfa-b7be-1f87d4cc3355"), new Guid("247201c7-7e3c-497b-8a56-2c3d04c0284c"), new Guid("8da60164-a6b7-4434-8368-50d4f3fda0ed") },
                    { new Guid("05712241-6da7-486a-926c-9372ddbb1b70"), new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("04b0c317-5a93-4f3d-b6b9-1c476ec07e5a") },
                    { new Guid("05e5c5d7-929b-490d-ab6a-0e4a6fe98769"), new Guid("1f178981-7702-47bc-805f-7c60c9d37b69"), new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29") },
                    { new Guid("0603beb3-8e39-4bf2-8c39-a1f13a9a9a54"), new Guid("2639191d-ca75-4caf-9791-b98dc90db4b4"), new Guid("72a4fac6-0a24-4734-93da-6ff6c436c955") },
                    { new Guid("07132802-39dd-4f46-a93f-2b2328b8c435"), new Guid("60faf1ba-d384-454e-a5fd-0055662a2387"), new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("07486adc-3129-485b-afb9-6d4f7bd07761"), new Guid("94a97825-d121-4260-bf37-99db9d3ef31b"), new Guid("102af34b-9a44-4933-a28f-a699efa8200d") },
                    { new Guid("0aef11cb-f9f3-4120-8493-4a3d3bbae570"), new Guid("bfbb540a-3a41-4f90-a7a6-b649da49277c"), new Guid("acc706fb-3a3c-4576-a3f3-116dd4c7ec4b") },
                    { new Guid("0ba559d2-b850-42b3-9399-a32a54ac1dbf"), new Guid("2363019e-e99a-467f-9ded-dadd9152e15e"), new Guid("ddca6af3-85a3-42df-8095-9fb213c55c06") },
                    { new Guid("0bdb2c07-7879-4e22-b352-9cda610237aa"), new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"), new Guid("8da60164-a6b7-4434-8368-50d4f3fda0ed") },
                    { new Guid("0e2a96cf-16b4-433b-8dbe-0aa98cd03c49"), new Guid("baeb1822-2be8-4837-8a7a-3bb2f1b5063f"), new Guid("6a605faf-9399-41cd-971a-ed0d4cda2e33") },
                    { new Guid("10a259cd-ed40-496d-a5c0-0c98bc04d52b"), new Guid("858086a4-47af-4314-93e1-8781e16cfd7e"), new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65") },
                    { new Guid("160503a3-effd-407e-a377-d357d153ab6a"), new Guid("60faf1ba-d384-454e-a5fd-0055662a2387"), new Guid("102af34b-9a44-4933-a28f-a699efa8200d") },
                    { new Guid("1862eddc-9f63-4a92-b7d8-b8d24b39cf70"), new Guid("48fedacb-f00b-43aa-a7c7-4ab2ce49f89d"), new Guid("ffb9e721-dba0-45d0-97f9-a7441ccd3456") },
                    { new Guid("18b7138d-ddde-401f-919c-9cf036400f46"), new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("cb108bc2-04e4-4ebe-8a80-ee82d2bd8c6d") },
                    { new Guid("1adf92a7-ae7f-445c-806e-76d5844bf3e9"), new Guid("247201c7-7e3c-497b-8a56-2c3d04c0284c"), new Guid("c6ea1c20-e953-4135-b167-4d6bba50671e") },
                    { new Guid("1b209ea6-d89c-4104-844b-499490640ba4"), new Guid("7ddc42d7-2ee6-4ab7-a3a8-076ae9d2a541"), new Guid("50bebfdb-4443-4ffa-9519-40f35b8bc451") },
                    { new Guid("2173793e-9fcd-49b3-a189-023956b9ad78"), new Guid("cbc7707e-9429-433d-aef3-9e424b5b1108"), new Guid("2f07ec68-a27b-4012-8e8d-6c58095922b6") },
                    { new Guid("21761519-ce56-486c-b899-faea92d0fbf5"), new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"), new Guid("20e2a7ad-80e7-44f2-af4d-4f2cc59f497c") },
                    { new Guid("21bf456b-de58-4ade-a09a-20b834303229"), new Guid("00fba144-1f24-44ed-9b79-b6c503e63945"), new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090") },
                    { new Guid("228c5dbe-f43d-49b8-a048-8507e182bbcd"), new Guid("a74a1172-1e8d-4b7c-86dc-b30b7fe55bb0"), new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29") },
                    { new Guid("22cf58af-2dca-440e-bd01-54c445729a92"), new Guid("c9f31925-273d-4801-bdb8-eff290218b34"), new Guid("4850690d-c87b-43c3-8a6f-ce4f12b41006") },
                    { new Guid("247cea44-ad70-4e6e-8ae5-13a6f3b93ddc"), new Guid("672a1ee2-d7d4-4b0f-b40c-cae6c7ec26ee"), new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42") },
                    { new Guid("2798a821-dd90-415f-8c8b-d4a9c9d43134"), new Guid("f73ff307-c4f3-4ea4-8ba1-e32ef11f452d"), new Guid("400a1eb4-95cf-4c20-a843-b96cb4c14f33") },
                    { new Guid("27a57f6b-8b0a-4a1a-bb1d-0262fb2cd52d"), new Guid("05bd7eed-24c2-41e3-8892-31f8b07df909"), new Guid("287e9929-6582-4698-a920-0458a4fd3404") },
                    { new Guid("27d8bd3f-34c6-4e25-a5bb-fb5694c5397b"), new Guid("4374623b-91b4-4192-87b6-82fb296fdc98"), new Guid("be34a07a-6680-4440-b4db-2df4afd6a1fc") },
                    { new Guid("283183a2-8307-471b-bf88-4c852157a4ab"), new Guid("05582433-8955-425a-8964-edf36e8441c3"), new Guid("1cd63b53-947b-4e59-8455-dfa8f0a983fd") },
                    { new Guid("2db79ab4-24a0-4d10-9432-4674d156b77c"), new Guid("66557298-7891-41f4-9d9b-c602b6f6d25e"), new Guid("8a9834c6-df40-4227-92bd-d705192b564e") },
                    { new Guid("2f9a8108-a41c-4ffa-a0b2-8ddd9708e8e8"), new Guid("5ad1734f-8c4b-4127-918f-dbd2b48374a6"), new Guid("09b0f883-b9dd-47b0-a36c-007dc71cb139") },
                    { new Guid("35fffed8-d85a-42f0-8119-eca1eed3bf7f"), new Guid("c431a66b-c07f-42f9-a3df-0eb92216f489"), new Guid("fd36f746-3390-41c0-9786-11ef7ead837a") },
                    { new Guid("369985a0-7e22-4d82-a3bd-25453ddb99e2"), new Guid("eb2116c9-a309-422a-aaeb-45b37f519272"), new Guid("cc825e27-9f28-4cbf-9190-ab0e46db3d25") },
                    { new Guid("3b5243c8-169d-4297-94f5-f3c4a3dd1986"), new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("7b52545c-9d53-4b90-bb3c-3e0d772359db") },
                    { new Guid("3bca9e77-05f1-4590-b087-00b098a86449"), new Guid("1e586dd2-7884-4a38-8722-f54fa5b40ea3"), new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65") },
                    { new Guid("3c91942e-1cf6-452a-a87a-8f5c41b06bdb"), new Guid("5ad1734f-8c4b-4127-918f-dbd2b48374a6"), new Guid("bc426f66-2fb3-44d5-adc8-2bfaa9cd3f28") },
                    { new Guid("3ce080ac-6a8a-49ed-9ed0-178da29e9574"), new Guid("05bd7eed-24c2-41e3-8892-31f8b07df909"), new Guid("f85661c2-9184-47cf-b9ff-816dfa7c5eee") },
                    { new Guid("413aa04c-9ff1-4ad0-af11-4b9e985cb882"), new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("a84cebab-0d83-49a7-b7d0-1a4cdb725c43") },
                    { new Guid("42beae25-c0f4-4811-ae32-e0d3f7c6cbf1"), new Guid("6e5cb8e9-dbf4-4fc4-8476-91293113361a"), new Guid("894b9207-8de7-4308-b07e-b6a6ab7c8720") },
                    { new Guid("4497459e-c83e-4491-91d1-eb8da6c91f67"), new Guid("a99339c9-1e39-498f-8ba1-d0825fcc908b"), new Guid("e26c9870-c7bd-4fb3-aee3-be02767ee2ad") },
                    { new Guid("4a146168-bf03-4a0d-a7e2-eb9bba047490"), new Guid("b50f5e2b-7112-4438-9b3f-051194091844"), new Guid("d1e12a59-3e7b-44e9-a90b-a6cbde8b6eb2") },
                    { new Guid("4a54c49d-c2a1-47a2-a559-fcfc6fed912d"), new Guid("a3192d8a-1caf-43ea-8612-6f79932b204b"), new Guid("be34a07a-6680-4440-b4db-2df4afd6a1fc") },
                    { new Guid("4d4a98eb-588f-4a67-8c1b-be0a4dd9ef4e"), new Guid("a99339c9-1e39-498f-8ba1-d0825fcc908b"), new Guid("d72a70fe-eafd-43b1-8d68-ed18fed4c58a") },
                    { new Guid("4da6db94-f6c3-468e-b98e-fe69864b519b"), new Guid("9ff9cf4e-0b5f-40c6-988d-06264ea414f5"), new Guid("7118351c-8397-40ee-a11f-b73bfe4e1eb0") },
                    { new Guid("52ee7fac-371e-46e8-b2f3-6777818cce32"), new Guid("462d0486-ecd7-45eb-8c79-8ec7892b7524"), new Guid("400a1eb4-95cf-4c20-a843-b96cb4c14f33") },
                    { new Guid("5364d8cf-ce4d-4c4e-a716-5e3b2ae1c6c9"), new Guid("c9f31925-273d-4801-bdb8-eff290218b34"), new Guid("7c9f6f5e-89e0-4234-b2c4-ab58a1c808fe") },
                    { new Guid("53f0ad53-0dcb-4fbf-9916-0e105d5cd0fa"), new Guid("dbdf2ee6-1c8b-4fab-a8ca-4938607ad809"), new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("54bc462f-e446-4ca0-b48a-ae57ec1ebe17"), new Guid("a74a1172-1e8d-4b7c-86dc-b30b7fe55bb0"), new Guid("210f8839-2f6f-4de2-9e29-469c83476018") },
                    { new Guid("55d1c262-4b5f-4bd3-980e-f81131e596d6"), new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"), new Guid("fdbac539-f8b0-4412-853d-285639821c09") },
                    { new Guid("55f54681-82cb-4f9c-8850-78c3277b6c30"), new Guid("94a97825-d121-4260-bf37-99db9d3ef31b"), new Guid("1696fa95-5d72-4832-af77-abf902fb6233") },
                    { new Guid("579ab880-6760-4869-9e55-5ba2b6670b74"), new Guid("25e20ed1-f4b3-451e-b183-a150a59a8ae9"), new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d") },
                    { new Guid("57f5b6dd-1f2e-4c7c-9b2d-25ab6a701ae1"), new Guid("2028425c-292b-42f6-bfb3-9d24738ea3e8"), new Guid("363b8af6-9ead-43dc-b306-c1e77a057a5b") },
                    { new Guid("5894e9ee-164e-4059-a793-6f4db9fb3eac"), new Guid("27f01d35-0d0e-409d-b9cb-831a0f480b7d"), new Guid("db813643-390f-4581-88f1-19c056088ae2") },
                    { new Guid("5b0b1ef4-d8cd-45a6-a25b-bae54b6b15fb"), new Guid("706f525d-d5f8-4c59-ab7d-ecb70c4b0536"), new Guid("3314db03-e390-406e-ae87-9bf5a511c2a4") },
                    { new Guid("5c37e7d7-576b-478a-b877-02b3e3b4f4fa"), new Guid("2639191d-ca75-4caf-9791-b98dc90db4b4"), new Guid("fa5bfeb2-245b-43be-acdc-76452fcabdc9") },
                    { new Guid("5c5bc4fb-3b36-4ec6-bd29-15dae6e9d7ba"), new Guid("9ff9cf4e-0b5f-40c6-988d-06264ea414f5"), new Guid("c3c4a60b-e9f4-41a4-ae20-c4050dddb034") },
                    { new Guid("5f5512e2-5810-4234-bd8b-544b57c2cee6"), new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("e49a373f-8a25-42c8-bacf-17bdd4bbc0bd") },
                    { new Guid("5ffb9e63-2b7c-49da-8158-40aa970f2135"), new Guid("bc130b58-6eec-4d53-9f0c-cc9d468c8b6e"), new Guid("cf631b08-8971-40f0-83d4-998b41d7a6c5") },
                    { new Guid("627bb270-eda2-46b3-917b-a4f7740f3b80"), new Guid("bc130b58-6eec-4d53-9f0c-cc9d468c8b6e"), new Guid("c9e97b1e-d785-4d20-af2e-6fa4de6eddc7") },
                    { new Guid("649ec7e7-eb7d-4046-a3e3-4f20b2051d0a"), new Guid("eeab6aec-8e7d-4e78-92fd-b386d45bde74"), new Guid("37e89ea1-4595-42bc-93cb-31765744c9d7") },
                    { new Guid("678e61f2-f1de-4fb7-950a-7a86b910b462"), new Guid("247201c7-7e3c-497b-8a56-2c3d04c0284c"), new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("69eb4221-88f4-4cfc-a9ef-ab2ffd8d5f36"), new Guid("1d953171-55db-4aca-b3eb-672cf65a37cd"), new Guid("e49a373f-8a25-42c8-bacf-17bdd4bbc0bd") },
                    { new Guid("6a5841c5-2785-469f-a033-35214fe7cd77"), new Guid("2639191d-ca75-4caf-9791-b98dc90db4b4"), new Guid("051f3ea3-f299-4880-81ed-c91c97ada90a") },
                    { new Guid("6c2ead64-0a44-46c5-9295-3cc7738f7e69"), new Guid("672a1ee2-d7d4-4b0f-b40c-cae6c7ec26ee"), new Guid("051f3ea3-f299-4880-81ed-c91c97ada90a") },
                    { new Guid("6d4dd031-9556-4a99-b886-9aa664309672"), new Guid("dbdf2ee6-1c8b-4fab-a8ca-4938607ad809"), new Guid("20e2a7ad-80e7-44f2-af4d-4f2cc59f497c") },
                    { new Guid("6e030cc8-a084-4f95-841f-c57068d44107"), new Guid("d1df1c09-8a6e-47f1-8c91-3d1813bffd29"), new Guid("db813643-390f-4581-88f1-19c056088ae2") },
                    { new Guid("71623c79-7808-40bc-94ba-3cfb3746852d"), new Guid("a3192d8a-1caf-43ea-8612-6f79932b204b"), new Guid("4d274729-0ca2-447c-9b7a-1f8d688428a3") },
                    { new Guid("7211e501-e31b-415f-972f-e914f6075b54"), new Guid("457b77d7-eeee-4f9d-b629-031fff6e66a2"), new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("748d1b6f-6ee1-426e-b84c-e60c47843a0e"), new Guid("d1bdba81-9fe0-48b7-ab60-080407724dc0"), new Guid("873ad122-3bc8-4978-bf2a-218e412c49c0") },
                    { new Guid("75256c45-6957-40f8-b293-6fa2ffb5caae"), new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("accc9197-e896-4a94-ae9a-8fa089d834e8") },
                    { new Guid("75c19a6c-af4d-428e-86e4-4ffa071ab9df"), new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("873ad122-3bc8-4978-bf2a-218e412c49c0") },
                    { new Guid("766a64bd-f6b8-4d4d-9064-e32cc54cb2b9"), new Guid("f73ff307-c4f3-4ea4-8ba1-e32ef11f452d"), new Guid("8b9b2789-f88d-4b0a-8dd2-72b51d69af38") },
                    { new Guid("79db2cfd-c3d4-472f-8e17-8b8a33edaab5"), new Guid("774a5209-4913-4be9-9434-0bcf2c9065c3"), new Guid("d79a301d-abce-469c-9579-e8392a43a6ed") },
                    { new Guid("7c011c68-6acd-40f3-b556-a2ccd1f624a5"), new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("be34a07a-6680-4440-b4db-2df4afd6a1fc") },
                    { new Guid("7c39f24b-8339-41ab-b779-7aa7291c54f5"), new Guid("ca124c0c-d9b2-499d-8ba0-bc9b055bdaa5"), new Guid("1fdefd13-f245-42db-a1f3-08ff1e4dd30c") },
                    { new Guid("7f039814-7d02-4889-badf-bd0df0c00d5f"), new Guid("25cc98b6-8064-4f70-8624-20f719985207"), new Guid("bc426f66-2fb3-44d5-adc8-2bfaa9cd3f28") },
                    { new Guid("8080f0d0-9afd-4eb6-a07c-80839e552122"), new Guid("eeab6aec-8e7d-4e78-92fd-b386d45bde74"), new Guid("be34a07a-6680-4440-b4db-2df4afd6a1fc") },
                    { new Guid("83cc89df-b907-497d-a3f5-fc23338f34b6"), new Guid("66557298-7891-41f4-9d9b-c602b6f6d25e"), new Guid("1cd63b53-947b-4e59-8455-dfa8f0a983fd") },
                    { new Guid("84f128a6-7247-4912-bd6a-00eac6432e0c"), new Guid("a1e0a92f-9811-4b28-b2e1-c19da225897a"), new Guid("363b8af6-9ead-43dc-b306-c1e77a057a5b") },
                    { new Guid("857b3dd9-43aa-43de-909d-aec73983bda7"), new Guid("ad7d91fb-f972-4d67-b97f-712807889e3a"), new Guid("bfd05140-60ec-48d4-84c9-078948eef632") },
                    { new Guid("8709472d-2615-404c-85d0-ca4fb69c3464"), new Guid("a4e2c8ce-1b22-43ea-bf52-6dea95c7e077"), new Guid("102af34b-9a44-4933-a28f-a699efa8200d") },
                    { new Guid("879e8c27-57d3-410b-b472-fa97534e9652"), new Guid("1e586dd2-7884-4a38-8722-f54fa5b40ea3"), new Guid("1fdefd13-f245-42db-a1f3-08ff1e4dd30c") },
                    { new Guid("87b53bf3-7468-423c-b67e-dd9b87b09517"), new Guid("67c7d05e-733c-460b-82e9-16bb9b794807"), new Guid("210f8839-2f6f-4de2-9e29-469c83476018") },
                    { new Guid("87b5bd6e-f007-49c7-8dba-976783ed8470"), new Guid("f42ca59f-c6fc-48b2-9501-7c8f06db53e9"), new Guid("82b676b6-59db-4ddf-9121-f9b621cd455c") },
                    { new Guid("8c05c300-b043-47a6-b3b7-6605e0e4be93"), new Guid("f42ca59f-c6fc-48b2-9501-7c8f06db53e9"), new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3") },
                    { new Guid("8c210ef6-4ced-44ee-9807-c96828f08bc9"), new Guid("94a97825-d121-4260-bf37-99db9d3ef31b"), new Guid("acc706fb-3a3c-4576-a3f3-116dd4c7ec4b") },
                    { new Guid("8d07df68-6818-4ab8-a0eb-b890057b47fc"), new Guid("71877662-ba0c-495b-bd3c-a5b7dbefe184"), new Guid("a0292c52-a952-497e-a3cf-c9e7ae54d851") },
                    { new Guid("8d183e82-2fce-40af-818d-ec8eba73ee62"), new Guid("9fc820b0-5ba8-4167-89d2-eddcdd26ebaf"), new Guid("b06781f6-9082-4052-aba2-5e09e0e3a21c") },
                    { new Guid("8e54a18c-9ff6-4b87-9590-a54002d81c93"), new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("41036d54-d5ae-47a9-b9fc-b7b9dfd1663a") },
                    { new Guid("91bfb91f-9700-4552-9d4e-25bcb0fd13ed"), new Guid("ad51d056-f92e-4524-8132-3794371109b7"), new Guid("5b8206c8-977a-4829-be0f-b8758a161634") },
                    { new Guid("921fd6b2-4987-4fc9-9c48-ad4a936dc216"), new Guid("a7f27380-56c1-434c-95f9-707cf5c8e0ee"), new Guid("e26c9870-c7bd-4fb3-aee3-be02767ee2ad") },
                    { new Guid("9481f723-8217-43f4-95f1-e591e573107c"), new Guid("f8dc0381-9903-4dc3-88b3-cd1fa9196062"), new Guid("1cd63b53-947b-4e59-8455-dfa8f0a983fd") },
                    { new Guid("94853ecc-c30a-44bb-9e53-0af6234483fa"), new Guid("bc130b58-6eec-4d53-9f0c-cc9d468c8b6e"), new Guid("94da780f-3505-422e-813b-3f27641ed828") },
                    { new Guid("977d3c64-331e-46b4-91b5-c39d90746429"), new Guid("ad7d91fb-f972-4d67-b97f-712807889e3a"), new Guid("2d54dc3f-9bdc-401c-974c-57115e354aa5") },
                    { new Guid("9a1814ca-a0af-403b-b99a-e5c83ae2deff"), new Guid("66557298-7891-41f4-9d9b-c602b6f6d25e"), new Guid("d1e12a59-3e7b-44e9-a90b-a6cbde8b6eb2") },
                    { new Guid("9a1ec7c3-9d9c-418c-b675-f4fe6cc88c8c"), new Guid("a1e0a92f-9811-4b28-b2e1-c19da225897a"), new Guid("48ab48b0-cba7-479a-bf98-62f135413e18") },
                    { new Guid("9b39148b-ddb2-41d8-a228-141764f92c54"), new Guid("48fedacb-f00b-43aa-a7c7-4ab2ce49f89d"), new Guid("bfd05140-60ec-48d4-84c9-078948eef632") },
                    { new Guid("9c1711a7-8f81-472d-a043-b3aa7607b81a"), new Guid("66557298-7891-41f4-9d9b-c602b6f6d25e"), new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42") },
                    { new Guid("9cb487ab-dcdc-4110-a583-7a6ad6a74235"), new Guid("b061cf29-d69e-4e26-8e94-7626c7d07c31"), new Guid("48ab48b0-cba7-479a-bf98-62f135413e18") },
                    { new Guid("9e7bbf9b-d4d1-4959-96f7-0f7d29c014df"), new Guid("baeb1822-2be8-4837-8a7a-3bb2f1b5063f"), new Guid("1204127d-07e0-48b3-8e63-8e2efc297924") },
                    { new Guid("9fa42541-0d92-423f-b062-d3f415e77bd8"), new Guid("cc8a13f4-c734-44d9-8222-5dbafa38082b"), new Guid("b11dc087-ac7e-4d93-b32d-bcab337caa3c") },
                    { new Guid("a3d69ad9-067e-4dfb-897c-41a4829620f3"), new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"), new Guid("accc9197-e896-4a94-ae9a-8fa089d834e8") },
                    { new Guid("a84abc47-cdef-4d06-8033-265c94f30bd2"), new Guid("a74a1172-1e8d-4b7c-86dc-b30b7fe55bb0"), new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f") },
                    { new Guid("aac361cf-5dc5-444c-989b-0bc61e6a1e0c"), new Guid("672a1ee2-d7d4-4b0f-b40c-cae6c7ec26ee"), new Guid("bfd05140-60ec-48d4-84c9-078948eef632") },
                    { new Guid("af764dbb-14a3-44c7-a4a5-41a15f052fd3"), new Guid("0cdff66e-912c-48bd-a56b-d0f8c6be0128"), new Guid("e49a373f-8a25-42c8-bacf-17bdd4bbc0bd") },
                    { new Guid("af887e9d-4a5c-4663-8d54-072fab6f8c7a"), new Guid("cbc7707e-9429-433d-aef3-9e424b5b1108"), new Guid("88e21e38-3658-4c01-97a4-6b6423d656f6") },
                    { new Guid("b69028bd-0362-4e6f-a233-1b2c8156346b"), new Guid("c9f31925-273d-4801-bdb8-eff290218b34"), new Guid("6e8d8a5d-6f2d-4f71-b6de-171329e79391") },
                    { new Guid("b8d45c82-f014-497c-864a-465a0a6c4b02"), new Guid("db4b778b-c82c-49ca-b238-5b79b6090e77"), new Guid("8b92030f-7005-4f57-96ce-54efe8bf7ccb") },
                    { new Guid("b919a323-2760-44ef-a544-136c8ea532d7"), new Guid("05582433-8955-425a-8964-edf36e8441c3"), new Guid("94da780f-3505-422e-813b-3f27641ed828") },
                    { new Guid("b99fa219-b2ae-4339-bfb8-5a0e87cefe74"), new Guid("0cdff66e-912c-48bd-a56b-d0f8c6be0128"), new Guid("c6ea1c20-e953-4135-b167-4d6bba50671e") },
                    { new Guid("bae58f83-45af-4661-ad5c-8457c4c038d0"), new Guid("4f30dcc5-4c72-4cf1-a790-9816e4d5a0a6"), new Guid("72a4fac6-0a24-4734-93da-6ff6c436c955") },
                    { new Guid("bcd75a67-ffa2-44de-984c-9d9cf55ae4b7"), new Guid("7ccbc01f-ab39-46b7-b422-67c375b236fe"), new Guid("e0dd9ff6-2db7-44ff-aa61-b49b8eac1739") },
                    { new Guid("c03f7745-9820-49f3-ae57-3fb50a3f5b43"), new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"), new Guid("466f5007-75ee-4c02-8301-b866eebfc0bf") },
                    { new Guid("c16aca34-4fed-4dfa-9992-e69b3020710b"), new Guid("706f525d-d5f8-4c59-ab7d-ecb70c4b0536"), new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65") },
                    { new Guid("c247a7f0-8739-4e3e-a9d5-3fcc01b19b16"), new Guid("457b77d7-eeee-4f9d-b629-031fff6e66a2"), new Guid("1cd63b53-947b-4e59-8455-dfa8f0a983fd") },
                    { new Guid("c556a33c-e982-4503-8502-12244aa009dd"), new Guid("b50f5e2b-7112-4438-9b3f-051194091844"), new Guid("6dd266ce-83e6-4cb6-bc41-65b88c412fda") },
                    { new Guid("c86010b5-99cf-46b9-8ae2-0182efbeb600"), new Guid("48fedacb-f00b-43aa-a7c7-4ab2ce49f89d"), new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d") },
                    { new Guid("c970d8d4-988d-4d76-941c-1fdf072051d6"), new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("926bf620-114b-410d-bc50-de5213741cae") },
                    { new Guid("cad43709-0bfa-404a-94a2-6c8641cc2b5c"), new Guid("1e586dd2-7884-4a38-8722-f54fa5b40ea3"), new Guid("6a605faf-9399-41cd-971a-ed0d4cda2e33") },
                    { new Guid("cbd05f4d-6757-4967-b9e3-62f88e70b737"), new Guid("8ad4de25-deaa-43c7-836a-f158fa7e588a"), new Guid("f7f46857-0bde-4234-a8ef-4a5ef143d2a2") },
                    { new Guid("cea222c8-60f0-42b1-8727-1047ff0846f1"), new Guid("bfbb540a-3a41-4f90-a7a6-b649da49277c"), new Guid("cc825e27-9f28-4cbf-9190-ab0e46db3d25") },
                    { new Guid("d0e72a4f-2324-46b9-9b19-ed727735acd2"), new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"), new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3") },
                    { new Guid("d0ecedbb-debe-47cb-a826-239ac2841e0e"), new Guid("baeb1822-2be8-4837-8a7a-3bb2f1b5063f"), new Guid("894b9207-8de7-4308-b07e-b6a6ab7c8720") },
                    { new Guid("d14f0326-cc4c-4310-ad53-104a8f353b38"), new Guid("eb2116c9-a309-422a-aaeb-45b37f519272"), new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090") },
                    { new Guid("d1752884-c732-43ce-804d-abb2fd919a08"), new Guid("457b77d7-eeee-4f9d-b629-031fff6e66a2"), new Guid("d72a70fe-eafd-43b1-8d68-ed18fed4c58a") },
                    { new Guid("d19f255f-fe21-48a5-8459-28568777edd6"), new Guid("18526c35-8620-4779-bb17-06e055f4bae3"), new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65") },
                    { new Guid("d4f7cfa5-7a71-467f-9dc9-91a6d2d48c2a"), new Guid("b26fe17c-d513-4a79-a020-cf22d70fc7a8"), new Guid("82b676b6-59db-4ddf-9121-f9b621cd455c") },
                    { new Guid("d64deab4-5700-4b34-aa9d-367cc118d833"), new Guid("8fc745de-65a1-4ed0-8797-9021c0b28351"), new Guid("b11dc087-ac7e-4d93-b32d-bcab337caa3c") },
                    { new Guid("d8a35540-5cd4-4987-8257-f8488c2a1248"), new Guid("1469671c-b6c1-486a-989d-b684e547f753"), new Guid("102af34b-9a44-4933-a28f-a699efa8200d") },
                    { new Guid("db844c00-f178-4940-9586-75e79bb1b7eb"), new Guid("bc130b58-6eec-4d53-9f0c-cc9d468c8b6e"), new Guid("a0292c52-a952-497e-a3cf-c9e7ae54d851") },
                    { new Guid("dc0cc370-53d1-4dbf-9ca4-6a58981116ee"), new Guid("2028425c-292b-42f6-bfb3-9d24738ea3e8"), new Guid("1fdefd13-f245-42db-a1f3-08ff1e4dd30c") },
                    { new Guid("dc797f66-a79c-4300-b55f-52f12430cd29"), new Guid("74d185a7-c06b-4085-9634-2f2fcb66eb0c"), new Guid("e3d558f3-f6ff-4ef6-99af-3a857cd66c3c") },
                    { new Guid("e43a273e-c002-4f65-8019-be98141e9836"), new Guid("8ad4de25-deaa-43c7-836a-f158fa7e588a"), new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090") },
                    { new Guid("e9f3aae7-1353-4670-940e-dca13582fb1d"), new Guid("a99339c9-1e39-498f-8ba1-d0825fcc908b"), new Guid("bc426f66-2fb3-44d5-adc8-2bfaa9cd3f28") },
                    { new Guid("ea52e397-646d-4b3f-bfca-258f1ab2be01"), new Guid("0ae1be56-abb1-428f-b9d3-001ef648e7c5"), new Guid("fd263d85-76dc-43f1-8ca2-0a83b2091313") },
                    { new Guid("eb13211d-9a4f-4e34-86c5-4ed6d1c0dbdd"), new Guid("05582433-8955-425a-8964-edf36e8441c3"), new Guid("37e89ea1-4595-42bc-93cb-31765744c9d7") },
                    { new Guid("eb2d5361-1890-4d1e-b29d-ae58d1a95a54"), new Guid("25e20ed1-f4b3-451e-b183-a150a59a8ae9"), new Guid("04b0c317-5a93-4f3d-b6b9-1c476ec07e5a") },
                    { new Guid("eb7258b7-853a-4cb3-bac0-90afbec1ffe8"), new Guid("9ee3f651-1179-4b17-8a22-b9ab95bc7311"), new Guid("d79a301d-abce-469c-9579-e8392a43a6ed") },
                    { new Guid("ec3e54ab-a9c7-422e-bf4c-88c7d1b0c486"), new Guid("c9f31925-273d-4801-bdb8-eff290218b34"), new Guid("8a9834c6-df40-4227-92bd-d705192b564e") },
                    { new Guid("f00f73ef-7e8e-4f98-bfca-0fdd662e2450"), new Guid("bfbb540a-3a41-4f90-a7a6-b649da49277c"), new Guid("b11dc087-ac7e-4d93-b32d-bcab337caa3c") },
                    { new Guid("f099450b-6052-41d2-a5d8-febab23cfe4d"), new Guid("ad51d056-f92e-4524-8132-3794371109b7"), new Guid("5274d061-1608-4402-b580-5fad93996548") },
                    { new Guid("f2494e5f-1795-493e-9602-1ec1ac7c2026"), new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"), new Guid("3314db03-e390-406e-ae87-9bf5a511c2a4") },
                    { new Guid("f461c014-c582-428a-8bb9-6d26e265ea8f"), new Guid("fc277ae7-9a6a-4eb6-af43-1303043d7fe5"), new Guid("c3c4a60b-e9f4-41a4-ae20-c4050dddb034") },
                    { new Guid("f4e996c8-1ec9-4ae9-b8d9-bf417a44695f"), new Guid("baeb1822-2be8-4837-8a7a-3bb2f1b5063f"), new Guid("77f6623b-08d2-481e-bf85-5040a7eb135a") },
                    { new Guid("f66acc09-9eb0-419d-b32d-d9393d07586d"), new Guid("457b77d7-eeee-4f9d-b629-031fff6e66a2"), new Guid("14155de7-aa41-48b3-b3d2-7e563508ab86") },
                    { new Guid("f862f98c-b428-46a3-8359-9d26e168c012"), new Guid("961d6ff8-5ad1-4792-a2ef-a4b8752d7aa5"), new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090") },
                    { new Guid("fbf03296-8225-4fed-972a-7c3eb44dfd04"), new Guid("9ff9cf4e-0b5f-40c6-988d-06264ea414f5"), new Guid("6e8d8a5d-6f2d-4f71-b6de-171329e79391") },
                    { new Guid("fc4bd8b9-5fd0-4414-94bb-93e9ee6e5eda"), new Guid("4f30dcc5-4c72-4cf1-a790-9816e4d5a0a6"), new Guid("74d25c20-69e8-45a4-8d96-380ac6564bfc") },
                    { new Guid("fd1d1861-3fb5-48d5-b9a2-9184386c53c9"), new Guid("6e5cb8e9-dbf4-4fc4-8476-91293113361a"), new Guid("855117f2-2ae4-474a-8d5c-198a7e133fe4") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0147bf8b-50ec-4b6e-83ab-20376fe9f32f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("01f1ba04-00f5-4f16-9901-6b92be1e316f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("02710f45-46f8-4ac9-937d-1308d5cc7bf8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0541d761-a3eb-4165-8877-c703eff65ed1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("060fb789-b466-4fe3-bc36-ba390dc9e172"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0b48a4a9-6971-44d6-a19e-7fd7d3a4e696"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0da4fee4-5393-410b-aab3-1c7e8b2e04db"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("17098e18-2c70-4ce7-b217-42f42dfbf9b6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1d3e1aa4-5c2d-4904-8e84-f58e87f379ce"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1ddcf957-5837-4343-af91-4bfc9d612322"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("21a8500c-c9af-4102-a723-8cedff98f23a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("224ef483-4406-466f-9c4a-fd5a71f47839"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("22d1697e-71f2-4453-a3c5-8552df8731a4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("30d0b923-63bf-4812-9eab-08c7d684e21f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3248beed-eb63-44af-9c41-d7c11263a7ac"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3376d914-f8b7-4611-95a7-01ed6f23b88c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("33bb92ad-e418-4b8b-a95e-e18bb62efad2"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3416ce50-135c-457a-a3c4-8ec7042e74e4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("344311e0-6ecf-4837-9513-c69eb503d383"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("37268960-75b1-4590-95c0-e88900d8fff6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("37e58466-ecf3-4abc-a1b9-02ebd835dd4c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3b4300c9-e958-40b3-9792-c28dc82d4e93"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3ba41dcf-5840-4f20-9e4f-e778d45968bb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("402875b0-55a8-4f41-89eb-83db9d6f02ac"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("41dbc7df-cb93-4d3d-8ea9-510e194cae57"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("42e6e28c-305f-4763-8edc-c7a842b99f18"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4380c151-ed5e-4a6d-8431-87c9536b83be"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4752c179-a5bb-4062-9c08-3c4535c28ede"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("51912d23-4c33-4e4d-ac2f-17434581288e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("521baabf-61a3-40f1-a2ee-32d6814833d9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("54569b23-a865-4ece-9db3-c3975456b64f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("56e0a98f-056a-43a2-9fc2-4fdde756ec08"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5ad640b3-0a17-4d31-945b-465e4713d7bc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5d135bbb-ae15-4ce6-ba31-515a556512e7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5de33e98-f4ba-4af1-84f2-fd3739e5915f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("607ff147-1acf-438f-9479-c55af05ead12"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("613b27a3-28d4-4844-b4b7-c3ffe609b5b5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("688595f9-3894-4a08-adc7-64d1f0029c4f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("696573d1-6d33-452c-82be-2391b236063d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6a585ec6-f611-4e1d-82f8-1033936fe38a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6e08a6dd-ddd8-4108-b121-4990a8f3e541"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6e0a4fae-e37f-46c6-a012-515087c2ffd2"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6e991b94-efbd-4547-9d85-085d7bef85a5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("71638686-a510-4b10-a93e-d975be713fa6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7437eb77-93fb-48e9-b629-bdb0d297caf8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7568af18-ac01-4f48-8c1e-e12de5a50d21"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7867a6ca-5282-40f3-8848-8dcf5f0ed9bf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7ac0629c-64f8-4d5a-8381-3a1c3fe5c8f4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7b4c3b6e-3d2c-4db0-b564-6254e4baaeaf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7cb233c4-6570-4567-90a6-fd5b214f5a98"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8cc280e8-b735-4afb-bade-72c5d3fe6f7b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8e48f57c-4468-4fca-8ae1-86e5b3d4a1fb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8f78794f-0d7c-4790-be55-3d862d4b8fc5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("98c1db6c-5465-4014-af6a-f06e835f2084"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a133254b-ca85-4676-acdf-223d2727dcf6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a6b93f95-3315-41d9-89f4-274d8cd57ffc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a9eeb733-832c-41b0-91bf-b6bd9f6a0377"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("acf821bf-f609-46ce-8b9b-3618d58a8351"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b5521b36-8280-4c31-b1bc-ec6213a52339"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b6acbbc1-67ac-46b1-9929-8da295aee528"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c6ce6c15-2a04-4a2e-8ec9-a948067ecc31"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c798753c-684d-46c2-940d-86f68a26a3b4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c90e065a-f9ac-47c9-a91e-2482359cc9b6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c973fc98-534b-4da2-afe0-4dd440885649"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cde1ebbd-267d-4aad-b025-9ac7baa338ee"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ce412353-e240-483a-b834-c1316057ed8b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d38c09ae-b8b0-48a2-94b9-c7173e87ec09"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("df9442e6-d553-4876-9482-143afc40f257"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e0770db7-e3e3-4cdf-8379-10b7431183bf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e3efb51d-d6f1-48b5-aa4d-bc28bb7571d5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e507aa1a-07e1-46f9-9bb2-717860137410"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ed8add2f-e421-4b74-aade-864b43c9a96d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f228442b-bbd9-41c2-ba38-ce4b6299463b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f2889dd7-12a3-4ff0-92f1-1ad35c365244"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f8a16c5e-924b-4c78-86bc-f8cfc88fb093"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fbc73f61-3aee-411b-ac8c-e420fa35da78"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("039b0733-3442-426e-837f-7c53a0468d37"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3e444ecb-0eba-428c-9da5-fbc0606b6d47"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a0fa0891-1662-4776-bc2e-38cad5748ffc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a6273f31-2aff-461c-a660-f48b1d79831d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("bde0e665-959b-4735-9215-78f72214feb4"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("e0b74872-5d26-4feb-90cd-55ff3edd9723"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("039cb3f1-f25f-4e99-aba8-295bc6ac7f9c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("0470467e-5cd5-4d8d-87f7-c986a2d17775"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("06d9e5fe-943f-47ad-be62-62407a2a5aa6"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("0814c7e8-b15d-4d1f-b2f5-513f1dc69147"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("087a2ccf-268d-4489-8261-5c74422aaa59"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("0f6cb690-dda4-4ea6-9cb1-5a6fade85cad"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("11f365d1-93ba-4729-9ab0-b783ed4cd78d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("138f88f7-46b3-4e11-8a57-f31121640606"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("17118b70-ba13-475c-b1ae-df3595adbacf"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("198d40a9-9ca5-44d8-afbe-9fddd60caafc"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("199fd50e-7758-404e-b8bb-ac371ab5bb82"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("1de2f9e9-9c33-4bf1-b98e-957a06f9c651"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("20d935eb-61d9-4cc3-b301-5fc4f449252a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("21580c7e-8e07-46ef-9155-f874022eec6c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("25d46d4f-6e77-4a1b-9eac-7248339aed8a"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3392fb57-702c-4cad-9e24-300280ae6505"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3afd34be-7979-4d2d-81cf-9254a6ddd1dc"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3b7febc8-ccca-494d-beff-4c2f6984508f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3e6d047b-5e19-4956-bff4-587c60bdde08"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("3f148613-475f-4f8f-bded-bd2890941015"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("41605ec0-e48c-434c-aad9-cad405c61e2d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("453a2ccb-0ab3-4730-b2d0-f2072243c7a8"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("4606f6e2-b323-451b-b249-e0944eefeb30"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("4c09b26e-b441-4ea3-a021-dc7f17625056"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("4d7a59ec-ed6f-4d5f-a867-b7a158c47f8d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("4e9eb89f-c612-43b7-a1ef-4e99257d7098"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("51124354-3bb9-48a0-a7e9-0317f2024f3d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("52191735-6c95-40a0-a876-10f7efdbfc28"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("5a6553b0-5dc8-4f35-b372-24b86dd12326"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("65e54592-dd2a-43a4-bf6d-02bb5de52a43"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("69dae698-4171-4de2-82ea-f72440da770b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("69e698ca-3675-4436-9206-c462e931a895"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("6ccd1a9a-1267-421b-813e-754e189ef59d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("730eedf5-25b1-4e63-bcf5-01b964e32fec"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("73218f6c-dcd8-457e-9fe5-46f533c02d77"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("735e44ed-71db-4f2b-9d46-eb5785bab877"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7634bb94-71c0-488b-b382-b4d98085f746"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7669b61d-dc9c-4f95-bd0b-5abdc22c86f2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("77ed728e-d9ff-4c35-9efa-70aa4647342d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("78169585-f892-4c6b-b52c-9312da91ef64"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("795e0581-2882-48e0-bd11-95bcf6435aa2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("7e3302da-1ea7-4962-ace5-0fb8d9e9db8b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("81c8af6f-2249-4afd-96f4-f50d5fb4e521"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("830a4391-7d29-4f93-945d-d4f7cb84a25f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("832b3da0-5ac4-475d-9e2e-1d2fa5bb32ec"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("849f3f6b-c4ee-4282-a3fc-cf79b34a2307"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("856eabf5-9ed3-4e5e-b843-a19aeeb69328"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("8604ee61-5153-4754-8d6f-4891f1d7f9a3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("874c9b1d-77fc-4f74-a226-1c617b294d3e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("891ee147-8b8d-4ebc-992a-5d3f7be6743f"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("90d7eb47-1c39-4762-97d2-d47d652b36b5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("920caa69-308d-4fb2-8a5c-0b35d376a8cf"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("94a74003-b845-437c-9e0e-964d78acba5d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9826783c-e401-46fc-9850-a9c89c23a805"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9a827809-06e2-476d-a92b-fbafdb617b26"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("9fd2c228-e483-42e4-8351-2a9b294ff6f6"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("a463c5ef-8eda-475f-a408-cb5410445eb2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("a924764d-9275-4d91-9338-e76d817e437d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("a92fc9f7-3117-4d62-95c1-b428fd4604ce"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("af05e25c-ebb6-4954-8fbd-30d182b7da0b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("af1b11ac-d2c1-4968-bf4d-870328850da9"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b2669318-25a4-4c6b-b02c-a5e6978f615c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b332241e-a1e1-42ab-b0e6-b6149729ba51"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b48ce4bb-c816-4d6a-bb23-fb261bbf846c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b667175b-285f-40af-b3bb-28446699cdbe"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b84e345c-ec4f-4e47-b592-b36dacb5779d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("b994bd76-e786-48ef-bad5-4126335c1745"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("bd3343db-c4d7-45a4-9888-06472aac20c2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("bdc366a1-c935-471e-8b6f-14043da5db60"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("be646521-00bb-4969-8271-a7ddc1a4a9f2"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("c0055e83-ac22-4268-a141-c9a099605fc6"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("c49d8d07-737e-4c1e-8a12-8f140b0beb25"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("c529824e-3119-4ce0-bca6-1f2ea1ce2d06"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("c6758c54-9958-4ad2-bb94-e5d5696f9751"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("c719c22c-5b9d-414d-9cc9-7941a39b9eba"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("cf94d1ed-9b14-4ac2-b3a4-ab7e13067ee3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d2ed86c3-882a-44d4-9813-850f5e22322c"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d5bb33e7-fd6d-4aa4-ad08-86ca0c33d0a3"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d78b9bd4-435b-46df-99d2-9234cc2149ea"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d82cf4ed-cc71-4565-adae-211d9828aebd"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("d897921f-1235-427f-b7fa-30993692c148"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("dc326bb4-9496-4526-ae33-e916fea928e5"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("dc72d9f2-6a0c-490a-a53c-de0d785d2439"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("ddd31763-17c8-4d69-9564-b526aa387b34"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e34216e5-489a-49d1-aab1-dabb48d80d6b"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e3f46127-4a1c-4723-81e8-1146eab4d0db"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("e73cf9af-b2d9-44fc-97c9-f8c41434b5ae"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("ea7e3b4e-e255-481f-9cd1-fa68e5e4d144"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("ec3a3332-c27d-40c2-b7ff-4975e6c16816"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("ecd0bc0f-7d20-437b-9dd2-523bd6f78431"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("edb7021c-f8db-45f6-889b-3d7f5fa2f35e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("ee51def1-ca00-44d1-8994-e114f2530d3d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f1753f66-4ef9-44a7-961a-ebb507e79293"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f3fb25c6-78cf-4df6-ab35-1fec4490e4a7"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f4bbbaa9-84bb-44be-880d-e056b953cb70"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f706f6c4-f1e0-43bb-8433-fe2dd65c32be"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("f7e1422c-0000-4a62-8592-a911ca08a75d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("fce7cbf9-bc7f-41ac-ac79-5fdfc670088e"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("fd6f7e43-0a05-48db-bfe4-13438cfbd19d"));

            migrationBuilder.DeleteData(
                table: "Feedbacks-table",
                keyColumn: "Id",
                keyValue: new Guid("febdf02a-5689-45e7-910a-18aba54c8f1f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("035babe5-9a5d-42d4-8e07-fc050d3ddbd1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("0446fcb3-3508-46e0-be46-42c8879e4f91"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("06dc4dfc-d909-40a5-aef5-804bbe1e8a40"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("182c8ab8-3847-4a06-a6a4-0fddd2e8325d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("491304c1-9405-46e9-866e-de6321cd900a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("4c2a73da-348a-4567-9fc6-20828a12eeff"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("5ed263b4-30e8-4219-8d05-5323a910cab7"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6c2c2cfe-099e-4197-9c48-8448399f477b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6c5ac107-55b6-4ca1-b2db-56f440d77468"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("70df3deb-a92a-4205-9100-7e3430bc1e53"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("75f293cf-a9d5-487a-afe5-0a9183b562c1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("77ba700a-9834-4a71-b9ee-a7f833e2619f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("896d1c81-345d-4d7f-a2a5-8ab92e678f25"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("8d5ac3a2-2364-4d1b-b473-808a451ecdca"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("905689b8-9550-4ab2-b653-916979ba3410"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a465b151-e032-4b0f-9988-e091f21b20ec"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c04016dc-8ca9-4df0-a3b2-273150a4bdb0"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ca801c33-855e-4212-9607-fea9e1010a7e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cb0af761-0659-4b63-b4b1-4569dacb0e4e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("db35c045-7b37-45c9-a1d2-cbaa981941ab"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e16594ac-7982-409b-bc60-13b1024234dd"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e177fa12-b498-4944-9226-ddae0efe432d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("e4f1bcfd-105e-4683-a1c6-582eb3b9c091"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ea4ffed4-9df7-40e2-9e38-7b3fc3f5d7ed"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ef8750e2-7147-4891-9685-79aeb8064541"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("01f57fca-cb50-4772-8485-79910fb1520f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("03bcaa2b-3a8f-4a11-9844-f16bf4fceecc"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("03dbab7b-b9de-4e08-b854-05e72ec24284"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("03f7f204-7b8c-4bd8-9e95-ab674491a46d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0510f8dc-ff1f-4dfa-b7be-1f87d4cc3355"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("05712241-6da7-486a-926c-9372ddbb1b70"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("05e5c5d7-929b-490d-ab6a-0e4a6fe98769"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0603beb3-8e39-4bf2-8c39-a1f13a9a9a54"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("07132802-39dd-4f46-a93f-2b2328b8c435"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("07486adc-3129-485b-afb9-6d4f7bd07761"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0aef11cb-f9f3-4120-8493-4a3d3bbae570"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0ba559d2-b850-42b3-9399-a32a54ac1dbf"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0bdb2c07-7879-4e22-b352-9cda610237aa"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("0e2a96cf-16b4-433b-8dbe-0aa98cd03c49"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("10a259cd-ed40-496d-a5c0-0c98bc04d52b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("160503a3-effd-407e-a377-d357d153ab6a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("1862eddc-9f63-4a92-b7d8-b8d24b39cf70"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("18b7138d-ddde-401f-919c-9cf036400f46"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("1adf92a7-ae7f-445c-806e-76d5844bf3e9"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("1b209ea6-d89c-4104-844b-499490640ba4"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2173793e-9fcd-49b3-a189-023956b9ad78"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("21761519-ce56-486c-b899-faea92d0fbf5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("21bf456b-de58-4ade-a09a-20b834303229"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("228c5dbe-f43d-49b8-a048-8507e182bbcd"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("22cf58af-2dca-440e-bd01-54c445729a92"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("247cea44-ad70-4e6e-8ae5-13a6f3b93ddc"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2798a821-dd90-415f-8c8b-d4a9c9d43134"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("27a57f6b-8b0a-4a1a-bb1d-0262fb2cd52d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("27d8bd3f-34c6-4e25-a5bb-fb5694c5397b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("283183a2-8307-471b-bf88-4c852157a4ab"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2db79ab4-24a0-4d10-9432-4674d156b77c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("2f9a8108-a41c-4ffa-a0b2-8ddd9708e8e8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("35fffed8-d85a-42f0-8119-eca1eed3bf7f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("369985a0-7e22-4d82-a3bd-25453ddb99e2"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3b5243c8-169d-4297-94f5-f3c4a3dd1986"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3bca9e77-05f1-4590-b087-00b098a86449"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3c91942e-1cf6-452a-a87a-8f5c41b06bdb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("3ce080ac-6a8a-49ed-9ed0-178da29e9574"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("413aa04c-9ff1-4ad0-af11-4b9e985cb882"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("42beae25-c0f4-4811-ae32-e0d3f7c6cbf1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("4497459e-c83e-4491-91d1-eb8da6c91f67"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("4a146168-bf03-4a0d-a7e2-eb9bba047490"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("4a54c49d-c2a1-47a2-a559-fcfc6fed912d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("4d4a98eb-588f-4a67-8c1b-be0a4dd9ef4e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("4da6db94-f6c3-468e-b98e-fe69864b519b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("52ee7fac-371e-46e8-b2f3-6777818cce32"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5364d8cf-ce4d-4c4e-a716-5e3b2ae1c6c9"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("53f0ad53-0dcb-4fbf-9916-0e105d5cd0fa"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("54bc462f-e446-4ca0-b48a-ae57ec1ebe17"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("55d1c262-4b5f-4bd3-980e-f81131e596d6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("55f54681-82cb-4f9c-8850-78c3277b6c30"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("579ab880-6760-4869-9e55-5ba2b6670b74"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("57f5b6dd-1f2e-4c7c-9b2d-25ab6a701ae1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5894e9ee-164e-4059-a793-6f4db9fb3eac"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5b0b1ef4-d8cd-45a6-a25b-bae54b6b15fb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5c37e7d7-576b-478a-b877-02b3e3b4f4fa"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5c5bc4fb-3b36-4ec6-bd29-15dae6e9d7ba"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5f5512e2-5810-4234-bd8b-544b57c2cee6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("5ffb9e63-2b7c-49da-8158-40aa970f2135"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("627bb270-eda2-46b3-917b-a4f7740f3b80"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("649ec7e7-eb7d-4046-a3e3-4f20b2051d0a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("678e61f2-f1de-4fb7-950a-7a86b910b462"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("69eb4221-88f4-4cfc-a9ef-ab2ffd8d5f36"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6a5841c5-2785-469f-a033-35214fe7cd77"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6c2ead64-0a44-46c5-9295-3cc7738f7e69"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6d4dd031-9556-4a99-b886-9aa664309672"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("6e030cc8-a084-4f95-841f-c57068d44107"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("71623c79-7808-40bc-94ba-3cfb3746852d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7211e501-e31b-415f-972f-e914f6075b54"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("748d1b6f-6ee1-426e-b84c-e60c47843a0e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("75256c45-6957-40f8-b293-6fa2ffb5caae"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("75c19a6c-af4d-428e-86e4-4ffa071ab9df"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("766a64bd-f6b8-4d4d-9064-e32cc54cb2b9"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("79db2cfd-c3d4-472f-8e17-8b8a33edaab5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7c011c68-6acd-40f3-b556-a2ccd1f624a5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7c39f24b-8339-41ab-b779-7aa7291c54f5"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("7f039814-7d02-4889-badf-bd0df0c00d5f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8080f0d0-9afd-4eb6-a07c-80839e552122"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("83cc89df-b907-497d-a3f5-fc23338f34b6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("84f128a6-7247-4912-bd6a-00eac6432e0c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("857b3dd9-43aa-43de-909d-aec73983bda7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8709472d-2615-404c-85d0-ca4fb69c3464"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("879e8c27-57d3-410b-b472-fa97534e9652"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("87b53bf3-7468-423c-b67e-dd9b87b09517"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("87b5bd6e-f007-49c7-8dba-976783ed8470"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8c05c300-b043-47a6-b3b7-6605e0e4be93"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8c210ef6-4ced-44ee-9807-c96828f08bc9"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8d07df68-6818-4ab8-a0eb-b890057b47fc"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8d183e82-2fce-40af-818d-ec8eba73ee62"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("8e54a18c-9ff6-4b87-9590-a54002d81c93"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("91bfb91f-9700-4552-9d4e-25bcb0fd13ed"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("921fd6b2-4987-4fc9-9c48-ad4a936dc216"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9481f723-8217-43f4-95f1-e591e573107c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("94853ecc-c30a-44bb-9e53-0af6234483fa"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("977d3c64-331e-46b4-91b5-c39d90746429"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9a1814ca-a0af-403b-b99a-e5c83ae2deff"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9a1ec7c3-9d9c-418c-b675-f4fe6cc88c8c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9b39148b-ddb2-41d8-a228-141764f92c54"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9c1711a7-8f81-472d-a043-b3aa7607b81a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9cb487ab-dcdc-4110-a583-7a6ad6a74235"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9e7bbf9b-d4d1-4959-96f7-0f7d29c014df"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("9fa42541-0d92-423f-b062-d3f415e77bd8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a3d69ad9-067e-4dfb-897c-41a4829620f3"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("a84abc47-cdef-4d06-8033-265c94f30bd2"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("aac361cf-5dc5-444c-989b-0bc61e6a1e0c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("af764dbb-14a3-44c7-a4a5-41a15f052fd3"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("af887e9d-4a5c-4663-8d54-072fab6f8c7a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b69028bd-0362-4e6f-a233-1b2c8156346b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b8d45c82-f014-497c-864a-465a0a6c4b02"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b919a323-2760-44ef-a544-136c8ea532d7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("b99fa219-b2ae-4339-bfb8-5a0e87cefe74"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("bae58f83-45af-4661-ad5c-8457c4c038d0"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("bcd75a67-ffa2-44de-984c-9d9cf55ae4b7"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c03f7745-9820-49f3-ae57-3fb50a3f5b43"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c16aca34-4fed-4dfa-9992-e69b3020710b"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c247a7f0-8739-4e3e-a9d5-3fcc01b19b16"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c556a33c-e982-4503-8502-12244aa009dd"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c86010b5-99cf-46b9-8ae2-0182efbeb600"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("c970d8d4-988d-4d76-941c-1fdf072051d6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("cad43709-0bfa-404a-94a2-6c8641cc2b5c"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("cbd05f4d-6757-4967-b9e3-62f88e70b737"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("cea222c8-60f0-42b1-8727-1047ff0846f1"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d0e72a4f-2324-46b9-9b19-ed727735acd2"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d0ecedbb-debe-47cb-a826-239ac2841e0e"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d14f0326-cc4c-4310-ad53-104a8f353b38"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d1752884-c732-43ce-804d-abb2fd919a08"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d19f255f-fe21-48a5-8459-28568777edd6"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d4f7cfa5-7a71-467f-9dc9-91a6d2d48c2a"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d64deab4-5700-4b34-aa9d-367cc118d833"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("d8a35540-5cd4-4987-8257-f8488c2a1248"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("db844c00-f178-4940-9586-75e79bb1b7eb"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("dc0cc370-53d1-4dbf-9ca4-6a58981116ee"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("dc797f66-a79c-4300-b55f-52f12430cd29"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e43a273e-c002-4f65-8019-be98141e9836"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("e9f3aae7-1353-4670-940e-dca13582fb1d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ea52e397-646d-4b3f-bfca-258f1ab2be01"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("eb13211d-9a4f-4e34-86c5-4ed6d1c0dbdd"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("eb2d5361-1890-4d1e-b29d-ae58d1a95a54"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("eb7258b7-853a-4cb3-bac0-90afbec1ffe8"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("ec3e54ab-a9c7-422e-bf4c-88c7d1b0c486"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f00f73ef-7e8e-4f98-bfca-0fdd662e2450"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f099450b-6052-41d2-a5d8-febab23cfe4d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f2494e5f-1795-493e-9602-1ec1ac7c2026"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f461c014-c582-428a-8bb9-6d26e265ea8f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f4e996c8-1ec9-4ae9-b8d9-bf417a44695f"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f66acc09-9eb0-419d-b32d-d9393d07586d"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("f862f98c-b428-46a3-8359-9d26e168c012"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("fbf03296-8225-4fed-972a-7c3eb44dfd04"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("fc4bd8b9-5fd0-4414-94bb-93e9ee6e5eda"));

            migrationBuilder.DeleteData(
                table: "IngredientsProducts-table",
                keyColumn: "Id",
                keyValue: new Guid("fd1d1861-3fb5-48d5-b9a2-9184386c53c9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("069783c8-3edd-4578-b982-6bd05c025e82"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("203d7894-13b0-4436-8e92-3408bc347c26"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c538e998-0be5-484f-89f5-4d74d1c297d8"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("dc84b57d-5663-45c9-8858-99f36ba19f59"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0a063f06-f9b3-4c36-95af-46642a3ae174"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0b89986d-107b-438c-9b89-e6cc5bc4333b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0edaf26c-0974-4a61-beef-5b25d2c3102b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0f2d5d7f-5528-4c21-8c5f-e5fea3f17b6e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("12b68d33-b707-4b7b-b3d8-f543d529a6a6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("174a4db1-8a08-4f73-a9c4-7bd5fe2c147d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("18132e54-dae8-4132-ac48-6009693c3929"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1d8269a9-6fee-4313-a82b-47b2b323e1d1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("23652965-5f89-460b-a763-4ce427737a51"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("29621f53-ca8d-4e1d-9347-446f304aaaa7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2eefe12a-bb52-49a4-ab41-2a7790085d2a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("381b5a7d-faee-448a-93f2-b27ca658e458"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("38c9887f-4106-4b1c-bcc0-70983a7a9a28"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("396d90aa-f7c5-41a8-8287-e05204b4c2c0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("41481b34-6a62-4495-896e-b95200bcc713"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("43275365-984a-4fde-9de2-da30de5ba5db"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("435e8acf-27b6-44c5-b39c-605f0afc23dc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("44db09d3-35ea-46d1-b086-359904f920bb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("453f7a11-b916-41ef-879f-8ecfeb6aa232"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4622a023-b19d-4c0c-8664-700a62c4f506"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("468b4cc7-ce02-4caa-8938-dd59609c707c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4aebd8f3-f593-4088-a061-071a35b78681"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4c0241aa-16e4-403e-bbb4-ef41eac1b91b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4c769826-ad2d-4606-bd54-dc7f0bfe498f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4e237dc2-ec6b-4975-9442-d24404ed8018"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4e9dce03-c935-416d-8091-da58af65ee06"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("528e8456-76bd-4f2f-a588-4c9ffe68bfe8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("55341d2f-56db-4994-9107-92c4a7b5e988"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5568fc18-7d0b-4052-b373-f6d079404a24"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("58d0a27e-128e-423e-9a80-ec399285d062"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5b8d9d6d-9f4f-400f-9bdb-9dc83e279d2a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5e4786c7-8fc5-454b-abb5-fc8ee9dc0114"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5fb30673-1791-4b01-8c53-f0064fa12d57"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("613c5d38-f65a-423a-8543-ac13f044663e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("668fd3b8-f9bb-4ad3-9e04-12057fe41b59"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("677c28d2-668a-4167-b8e6-a6d59f958380"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6837a98a-5d3c-4396-8f61-41df515f73bb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6df03384-bdad-4c2b-8433-69c3f3f68bdc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7264d1e8-2efb-43a8-b52d-48f61cc3ed00"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("790acf76-387d-46df-99f1-8632fca9facd"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7aef2f9f-a83a-4c9e-9b77-62876b6737ed"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("834cac26-61f7-4d94-b0f3-9a81dd2e83cf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("85c2c617-29b7-4dcf-be9f-efc29480aaf8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("86882691-2b74-4a86-bc6c-3af4628dbd43"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a92683f-857c-4098-a06b-2af504783426"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("914b5fab-01b9-4197-bf7a-8af4f4481065"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9385cd32-b9bb-44a8-88ec-93f43484789d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("945b7315-38e4-4962-9c5d-c4aede3b5b6e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("958ded78-d7cd-4431-b359-14774fe82db4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("95c08215-2a62-4b11-bda9-6a8074750845"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9b306588-9764-41eb-8dad-21890b791786"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9e600a3d-ef9c-4ab3-aa50-c2cb1e32f4f0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a0cfe7da-86ba-4eca-bef1-9ee47c27da83"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a4edf60e-49de-44ad-b79b-d643add2f342"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b0db5d70-a422-4522-80ee-ab9768e0ab4a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b5aa6d38-6827-4443-a86f-09864d03808a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c03f9473-92d5-4888-b3d5-6a5a5752864f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c323ba07-1b10-48d1-a9ce-ea7440118b02"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c4063b44-7bb0-4859-b887-1af1ab7647ff"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c9b7f669-bb10-42b4-86f1-990674e46d88"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cb7b8924-0d64-48f0-83d8-273d5ed4b692"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cca36535-8e95-4d9f-b74a-ec51f74ac099"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d160096d-9192-48af-846e-361ee351eb32"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d66040b2-75b8-44a7-82b6-108263c3963c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d7373145-5235-4cf6-83d9-aa48337571ac"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d86c6913-fda2-49f9-85f0-4576773a3ee1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("db1b5994-75df-48c6-abbf-0bfff0e8e4eb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e0ee3ab2-0b65-4569-950f-adefe865daa1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e7811290-0646-4b7d-b10f-5c4a6c047089"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ea54c1d3-7c77-478a-81b1-7ffcbd46defb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f6ad7aa9-508b-46f9-a5f7-76bf3e9d15d5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f6d8fb61-d35d-4c78-96f1-68e16051b768"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f85834df-9460-4381-a426-e5198991db19"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fdf006a0-fd23-4eec-a714-68c214d657ac"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("2ef952d7-2843-45e6-9fa2-b15b9383ff99"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("bf7ba1f4-ae44-41e6-a1bb-3bdf364c8405"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("bf9d8238-5f41-4bde-894b-e2e3edea9fe0"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d753ed14-c342-4cf2-bfa2-fb6f5c3d39b9"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("f27861d3-1b27-4f07-8b53-f14dd18c9d3a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("00fba144-1f24-44ed-9b79-b6c503e63945"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("05582433-8955-425a-8964-edf36e8441c3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("05bd7eed-24c2-41e3-8892-31f8b07df909"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("0ae1be56-abb1-428f-b9d3-001ef648e7c5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("0cdff66e-912c-48bd-a56b-d0f8c6be0128"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1469671c-b6c1-486a-989d-b684e547f753"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("18526c35-8620-4779-bb17-06e055f4bae3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1d953171-55db-4aca-b3eb-672cf65a37cd"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1e586dd2-7884-4a38-8722-f54fa5b40ea3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("1f178981-7702-47bc-805f-7c60c9d37b69"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2028425c-292b-42f6-bfb3-9d24738ea3e8"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2363019e-e99a-467f-9ded-dadd9152e15e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("247201c7-7e3c-497b-8a56-2c3d04c0284c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("25cc98b6-8064-4f70-8624-20f719985207"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("25e20ed1-f4b3-451e-b183-a150a59a8ae9"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("2639191d-ca75-4caf-9791-b98dc90db4b4"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("27f01d35-0d0e-409d-b9cb-831a0f480b7d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("41b78ab9-be69-4aa1-be92-a37c3ad411f1"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("4374623b-91b4-4192-87b6-82fb296fdc98"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("457b77d7-eeee-4f9d-b629-031fff6e66a2"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("462d0486-ecd7-45eb-8c79-8ec7892b7524"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("48fedacb-f00b-43aa-a7c7-4ab2ce49f89d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("4f30dcc5-4c72-4cf1-a790-9816e4d5a0a6"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("5ad1734f-8c4b-4127-918f-dbd2b48374a6"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("60faf1ba-d384-454e-a5fd-0055662a2387"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("66557298-7891-41f4-9d9b-c602b6f6d25e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("672a1ee2-d7d4-4b0f-b40c-cae6c7ec26ee"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("67c7d05e-733c-460b-82e9-16bb9b794807"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("6e5cb8e9-dbf4-4fc4-8476-91293113361a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("706f525d-d5f8-4c59-ab7d-ecb70c4b0536"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("71877662-ba0c-495b-bd3c-a5b7dbefe184"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("74d185a7-c06b-4085-9634-2f2fcb66eb0c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("774a5209-4913-4be9-9434-0bcf2c9065c3"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("7ccbc01f-ab39-46b7-b422-67c375b236fe"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("7ddc42d7-2ee6-4ab7-a3a8-076ae9d2a541"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("858086a4-47af-4314-93e1-8781e16cfd7e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("8ad4de25-deaa-43c7-836a-f158fa7e588a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("8fc745de-65a1-4ed0-8797-9021c0b28351"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("93a42c30-9996-47a2-947a-c29192d5a31b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("94a97825-d121-4260-bf37-99db9d3ef31b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("961d6ff8-5ad1-4792-a2ef-a4b8752d7aa5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9ee3f651-1179-4b17-8a22-b9ab95bc7311"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9fc820b0-5ba8-4167-89d2-eddcdd26ebaf"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("9ff9cf4e-0b5f-40c6-988d-06264ea414f5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a1e0a92f-9811-4b28-b2e1-c19da225897a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a3192d8a-1caf-43ea-8612-6f79932b204b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a4e2c8ce-1b22-43ea-bf52-6dea95c7e077"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a74a1172-1e8d-4b7c-86dc-b30b7fe55bb0"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a7f27380-56c1-434c-95f9-707cf5c8e0ee"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a8ec13af-7403-4af3-8c01-bd6f85958d21"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("a99339c9-1e39-498f-8ba1-d0825fcc908b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ad51d056-f92e-4524-8132-3794371109b7"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ad7d91fb-f972-4d67-b97f-712807889e3a"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b061cf29-d69e-4e26-8e94-7626c7d07c31"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b26fe17c-d513-4a79-a020-cf22d70fc7a8"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("b50f5e2b-7112-4438-9b3f-051194091844"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("baeb1822-2be8-4837-8a7a-3bb2f1b5063f"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("bc130b58-6eec-4d53-9f0c-cc9d468c8b6e"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("bfbb540a-3a41-4f90-a7a6-b649da49277c"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c431a66b-c07f-42f9-a3df-0eb92216f489"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("c9f31925-273d-4801-bdb8-eff290218b34"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("ca124c0c-d9b2-499d-8ba0-bc9b055bdaa5"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cbc7707e-9429-433d-aef3-9e424b5b1108"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("cc8a13f4-c734-44d9-8222-5dbafa38082b"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d1bdba81-9fe0-48b7-ab60-080407724dc0"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("d1df1c09-8a6e-47f1-8c91-3d1813bffd29"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("db4b778b-c82c-49ca-b238-5b79b6090e77"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("dbdf2ee6-1c8b-4fab-a8ca-4938607ad809"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("eaf4fb53-eaaf-4faf-9fcb-d613abf963e0"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("eb2116c9-a309-422a-aaeb-45b37f519272"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("eeab6aec-8e7d-4e78-92fd-b386d45bde74"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f42ca59f-c6fc-48b2-9501-7c8f06db53e9"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f73ff307-c4f3-4ea4-8ba1-e32ef11f452d"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("f8dc0381-9903-4dc3-88b3-cd1fa9196062"));

            migrationBuilder.DeleteData(
                table: "Ingredients-table",
                keyColumn: "Id",
                keyValue: new Guid("fc277ae7-9a6a-4eb6-af43-1303043d7fe5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("04b0c317-5a93-4f3d-b6b9-1c476ec07e5a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("051f3ea3-f299-4880-81ed-c91c97ada90a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("09b0f883-b9dd-47b0-a36c-007dc71cb139"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("102af34b-9a44-4933-a28f-a699efa8200d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1204127d-07e0-48b3-8e63-8e2efc297924"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("14155de7-aa41-48b3-b3d2-7e563508ab86"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("15e9a113-3c52-45d2-abb2-69a984f91650"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1696fa95-5d72-4832-af77-abf902fb6233"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1cd63b53-947b-4e59-8455-dfa8f0a983fd"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1d2612be-1a6f-4939-a7b1-ee2d1cf75bd4"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1fdefd13-f245-42db-a1f3-08ff1e4dd30c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("20e2a7ad-80e7-44f2-af4d-4f2cc59f497c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("210f8839-2f6f-4de2-9e29-469c83476018"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("27338712-f315-4b2d-a89c-9bbc68c5d96b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("287e9929-6582-4698-a920-0458a4fd3404"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2d54dc3f-9bdc-401c-974c-57115e354aa5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2de3dc7d-7a34-4b86-a48a-ab13b61ad379"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2f07ec68-a27b-4012-8e8d-6c58095922b6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("3081c486-dabc-4d3e-99ba-802bab9f46fe"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("3314db03-e390-406e-ae87-9bf5a511c2a4"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("363b8af6-9ead-43dc-b306-c1e77a057a5b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("37e89ea1-4595-42bc-93cb-31765744c9d7"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("3891c2e2-260e-4e72-9631-7688af2df839"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("400a1eb4-95cf-4c20-a843-b96cb4c14f33"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("41036d54-d5ae-47a9-b9fc-b7b9dfd1663a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("466f5007-75ee-4c02-8301-b866eebfc0bf"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4850690d-c87b-43c3-8a6f-ce4f12b41006"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("48ab48b0-cba7-479a-bf98-62f135413e18"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4d274729-0ca2-447c-9b7a-1f8d688428a3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("50bebfdb-4443-4ffa-9519-40f35b8bc451"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5274d061-1608-4402-b580-5fad93996548"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("59d100b9-82c6-4423-8ee2-6bf1536e1d42"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5b8206c8-977a-4829-be0f-b8758a161634"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("633469ee-07a4-42a2-9365-e5dc4e37cd29"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("65b5dec9-7a54-4ac4-a1f8-8912b12056b3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6a605faf-9399-41cd-971a-ed0d4cda2e33"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6dd266ce-83e6-4cb6-bc41-65b88c412fda"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6e8d8a5d-6f2d-4f71-b6de-171329e79391"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7118351c-8397-40ee-a11f-b73bfe4e1eb0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("72a4fac6-0a24-4734-93da-6ff6c436c955"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("74d25c20-69e8-45a4-8d96-380ac6564bfc"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("75a3dfa7-c6c5-4e92-bb18-ecfd3b745b8f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("77f6623b-08d2-481e-bf85-5040a7eb135a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7b0c42dd-636e-4e50-8ef0-7ab314f20864"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7b52545c-9d53-4b90-bb3c-3e0d772359db"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7c9f6f5e-89e0-4234-b2c4-ab58a1c808fe"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("82b676b6-59db-4ddf-9121-f9b621cd455c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("855117f2-2ae4-474a-8d5c-198a7e133fe4"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("873ad122-3bc8-4978-bf2a-218e412c49c0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("88e21e38-3658-4c01-97a4-6b6423d656f6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("894b9207-8de7-4308-b07e-b6a6ab7c8720"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8a9834c6-df40-4227-92bd-d705192b564e"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8b92030f-7005-4f57-96ce-54efe8bf7ccb"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8b9b2789-f88d-4b0a-8dd2-72b51d69af38"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8da60164-a6b7-4434-8368-50d4f3fda0ed"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("926bf620-114b-410d-bc50-de5213741cae"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("94da780f-3505-422e-813b-3f27641ed828"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("95027e1d-c3ad-4496-b4a4-e5875409fbe1"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a0292c52-a952-497e-a3cf-c9e7ae54d851"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a84cebab-0d83-49a7-b7d0-1a4cdb725c43"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("acc706fb-3a3c-4576-a3f3-116dd4c7ec4b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("accc9197-e896-4a94-ae9a-8fa089d834e8"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("adc5f80f-8e17-40f8-b657-9e721aed6e65"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b06781f6-9082-4052-aba2-5e09e0e3a21c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b11dc087-ac7e-4d93-b32d-bcab337caa3c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b7ba6b7b-ac79-4891-b894-d4611e27eb6c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bc426f66-2fb3-44d5-adc8-2bfaa9cd3f28"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("be34a07a-6680-4440-b4db-2df4afd6a1fc"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bfd05140-60ec-48d4-84c9-078948eef632"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c3c4a60b-e9f4-41a4-ae20-c4050dddb034"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c6ea1c20-e953-4135-b167-4d6bba50671e"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c9e97b1e-d785-4d20-af2e-6fa4de6eddc7"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cb108bc2-04e4-4ebe-8a80-ee82d2bd8c6d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cc825e27-9f28-4cbf-9190-ab0e46db3d25"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cf631b08-8971-40f0-83d4-998b41d7a6c5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cfc4184a-e4df-46d5-9295-4477f78cb79e"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d1e12a59-3e7b-44e9-a90b-a6cbde8b6eb2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d3bff4ba-727d-4a58-a462-db81200dd655"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d643b8e5-0b5c-498b-87bd-6ec9150c1f35"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d72a70fe-eafd-43b1-8d68-ed18fed4c58a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d79a301d-abce-469c-9579-e8392a43a6ed"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("db813643-390f-4581-88f1-19c056088ae2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("ddca6af3-85a3-42df-8095-9fb213c55c06"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e0dd9ff6-2db7-44ff-aa61-b49b8eac1739"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e26c9870-c7bd-4fb3-aee3-be02767ee2ad"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e3d558f3-f6ff-4ef6-99af-3a857cd66c3c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e49a373f-8a25-42c8-bacf-17bdd4bbc0bd"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e90a8c21-01f7-4c52-8409-5d2b525f269d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f292d0e8-2aaa-45f5-b52e-4a875eaa2090"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f7f46857-0bde-4234-a8ef-4a5ef143d2a2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f85661c2-9184-47cf-b9ff-816dfa7c5eee"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fa5bfeb2-245b-43be-acdc-76452fcabdc9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fd263d85-76dc-43f1-8ca2-0a83b2091313"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fd36f746-3390-41c0-9786-11ef7ead837a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fdbac539-f8b0-4412-853d-285639821c09"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("ffb9e721-dba0-45d0-97f9-a7441ccd3456"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("0165197c-e010-4e57-8305-d0076bc99dcb"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("06b24408-e8cb-44a6-b782-58ecb9529dfd"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("06ee643a-2b91-415e-8752-94e8d8aa3467"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("10439852-4816-43e2-b65d-f62f38a63597"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("15b7208b-eb17-4a51-ba76-17afbbf96068"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("19e8eeee-9782-4c18-8c1c-31e25bfe26e4"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("1c2a5a04-eed8-4626-a3a7-3630bf3b0e95"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("1e415287-85c2-4e91-a3a7-78ab80f29d41"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("299d6c5a-3eb4-4a7e-a688-cbfa85925d78"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("2c56dff9-7e7b-41ae-8dbf-cd0d7b55a51a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("2f2b69b5-08c5-4255-adf3-6dc04adbc448"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("40b9820c-9524-4196-a6c4-2c5120a8d185"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("42dd62d7-9504-4805-bfe4-42d3ef3dac1e"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("439c0143-aa29-4f4a-be00-6c390ef9b39a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("47892d22-4bd2-458c-ac2d-730b131281f3"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("658b1a98-7c9f-404c-a48e-1f1831b2c7fc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("6dbd8a30-6580-4ac3-9c74-94441c39f686"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("7b71dcc1-7b36-431e-a69d-83c8a4be3555"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("7dd582ba-f57b-4423-aac8-939ec85142cc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("7f073178-d93a-4b97-a9fd-f50392699653"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8234318f-fedb-4cef-b9e1-df06ab46227d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8b8e8e9c-05f8-42ce-9165-b97a44d6a61f"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8ebf7876-48ab-4a88-b72c-3886ad5e9e80"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a2667fd2-f3a3-4f16-bedb-88797a893d0d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("ae095307-27ff-4328-87b9-249edce99907"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("bbb1fe8b-3eee-4b01-bfb5-0ffd083f963e"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("c1368eea-107e-4c03-8095-ab95a71d9d12"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("c37c8613-1e50-495c-b539-13b435bb7b1b"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("cc9f943f-c54f-4e00-83a0-108e6f001c2c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("cdcff493-05fd-4ed3-85a8-8b47810c2c5b"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("cf643469-5ed8-4783-9ba8-0acace88c69a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d0415a1e-b7c7-41d2-9e20-3a4c1a151748"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d9df7ae2-ba41-44fe-8688-f309bea046d5"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("e32b53d5-209e-456d-97ec-08083ae52cd5"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("e9ac3b35-e5eb-4445-be05-17f5ba75ef92"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("eb7f392b-39e6-4e4a-9412-66f270544b86"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("f006df0e-cfc4-4685-833a-dc38c9d0a3ca"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("f51ea93b-bbe6-4501-a3d4-8dcf2003f1f9"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("f9e6e7f4-2b14-48eb-80fa-35c0b8235d86"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("2781085b-1698-46ca-ab9b-f6b769226b79"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("307f1b95-c9d1-4ff8-a210-2835e149d635"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("38d59506-c7ee-4a86-aad6-107db6e0680e"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("43ded5f0-7c2d-45b2-b7c7-bc0cea6f1e32"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("4b0bc1d4-94cc-4518-8b18-88f665686943"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("58c7ff5f-b820-4782-99a5-57e50744baab"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("5b747792-b0c9-469e-b462-e823ce7463f8"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("b741e386-7df9-4988-99a8-d26275a25ebf"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("cbabf50d-74a6-4a96-a10d-15eda36b7c55"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("e1938295-70cc-425a-8762-1790fcf44839"));

            migrationBuilder.InsertData(
                table: "Countries-table",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Congo" },
                    { new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Oman" },
                    { new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Norway" },
                    { new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Gibraltar" },
                    { new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "British Indian Ocean Territory (Chagos Archipelago)" },
                    { new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Uruguay" },
                    { new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Wallis and Futuna" },
                    { new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Argentina" },
                    { new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Malta" },
                    { new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Azerbaijan" }
                });

            migrationBuilder.InsertData(
                table: "Products-table",
                columns: new[] { "Id", "Description", "Price", "Recipe", "Title" },
                values: new object[,]
                {
                    { new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 475.42m, "Frozen", "Salad" },
                    { new Guid("035f593d-eb78-4a43-a406-422e51fe284f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 778.79m, "Metal", "Cheese" },
                    { new Guid("03fd0d33-6852-40f9-9529-53edfeb980eb"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 885.73m, "Frozen", "Bacon" },
                    { new Guid("045969eb-e9bd-48c9-92a3-f0e50ca96e67"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 293.05m, "Steel", "Chips" },
                    { new Guid("052ce2b6-f4f9-45fc-a36b-fd871997cf47"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 9.33m, "Metal", "Soap" },
                    { new Guid("0b217f79-749b-4bed-b984-eae29e896ab6"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 719.95m, "Granite", "Cheese" },
                    { new Guid("0d424444-b16e-4095-a462-5e0df2b830b6"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 703.74m, "Soft", "Keyboard" },
                    { new Guid("0e94a252-bebc-4b90-a08c-71bd06bfe83a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 856.25m, "Granite", "Pizza" },
                    { new Guid("0f3b1af9-cff3-4958-8d91-973db903e663"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 370.25m, "Frozen", "Shirt" },
                    { new Guid("0f4a9350-b921-4249-af70-22d73dffb2ba"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 794.21m, "Granite", "Car" },
                    { new Guid("1641484a-2411-4e80-a25b-a8f82d4414e3"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 971.36m, "Granite", "Pizza" },
                    { new Guid("17c89867-ed3a-40bd-aff0-8bc6085b0ee3"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 785.66m, "Metal", "Cheese" },
                    { new Guid("1bfdf0b1-cf83-4442-9f59-8f398227ea3d"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 234.12m, "Wooden", "Computer" },
                    { new Guid("1dcac742-c73a-469a-b8ea-7f16de87126e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 942.79m, "Soft", "Hat" },
                    { new Guid("1f4720be-f37b-4941-ac7f-2785f1fa82e3"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 234.59m, "Wooden", "Salad" },
                    { new Guid("238fc4d2-7dae-46e8-a6a1-10348319d2c7"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 282.25m, "Granite", "Chicken" },
                    { new Guid("2657dae5-6e31-4bc3-8d93-1665e676d327"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 39.66m, "Concrete", "Computer" },
                    { new Guid("283a9319-1c2a-4220-b31b-62f5b79aec26"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 47.13m, "Fresh", "Fish" },
                    { new Guid("29c110dd-5908-4da3-84ab-364d5d59a414"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 458.72m, "Fresh", "Computer" },
                    { new Guid("2bc9534b-c854-4b54-b2ea-386a42447750"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 750.70m, "Metal", "Cheese" },
                    { new Guid("2dcf78b0-b441-4445-a916-538bd1de8ee0"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 441.53m, "Fresh", "Gloves" },
                    { new Guid("30253c1d-d45b-475e-9e4c-78d23f2fb8dc"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 438.83m, "Steel", "Hat" },
                    { new Guid("31010288-224c-4304-914d-6380bad1b4d7"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 936.30m, "Plastic", "Salad" },
                    { new Guid("335ac5e5-0e96-409a-90a2-0b2bd42e0b31"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 462.97m, "Metal", "Keyboard" },
                    { new Guid("36cf0e6a-a3f7-4284-9470-049c95e1a625"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 723.39m, "Concrete", "Sausages" },
                    { new Guid("384bc094-7a1a-4388-8a4a-ed4f90363745"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 909.37m, "Granite", "Pizza" },
                    { new Guid("397e4333-672a-4908-ae48-5bfbbe70da30"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 510.29m, "Granite", "Pants" },
                    { new Guid("3ad91fe1-7c02-49a4-a908-7eba00a54c51"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 356.54m, "Metal", "Table" },
                    { new Guid("44bc5f98-1215-4619-8bb7-67c0793eb04a"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 471.70m, "Steel", "Fish" },
                    { new Guid("4566aa98-606b-45c2-809d-dc96adbc3f29"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 466.26m, "Fresh", "Chair" },
                    { new Guid("46bfe5e4-89e8-42b7-9b9e-2c8197e34f4f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 882.65m, "Frozen", "Ball" },
                    { new Guid("4a245771-f443-4a92-8bb2-deb048473599"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 731.66m, "Frozen", "Hat" },
                    { new Guid("4aac426e-97f0-4edf-8c5b-d9af506c8beb"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 772.65m, "Steel", "Sausages" },
                    { new Guid("4ff9988b-8d64-413a-902f-b04c14710b30"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 136.62m, "Soft", "Chair" },
                    { new Guid("500f60be-f942-4ad4-8109-2d28050bbfed"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 165.61m, "Steel", "Sausages" },
                    { new Guid("568726fd-9699-4cd2-ad82-a09d68e35bfa"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 4.14m, "Concrete", "Mouse" },
                    { new Guid("56a5a710-0a47-42c3-ac66-54730524330d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 848.32m, "Fresh", "Car" },
                    { new Guid("5cde69d9-400d-465e-86ab-6476bad46875"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 436.74m, "Metal", "Fish" },
                    { new Guid("5d61416b-363d-456a-9251-907fab5d8a14"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 387.66m, "Concrete", "Fish" },
                    { new Guid("5d83ec35-d21e-4e1d-9d81-8e6a2052f162"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 106.38m, "Cotton", "Salad" },
                    { new Guid("5fb21ed7-d4b7-45d5-9ecd-7ee6177537fe"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 955.80m, "Soft", "Sausages" },
                    { new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 628.49m, "Wooden", "Chips" },
                    { new Guid("66e8ca49-e237-4521-99ab-e6845e9125b5"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 72.49m, "Concrete", "Pants" },
                    { new Guid("6f34af44-c1bb-41f8-b5ef-a4c85d8df5b5"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 319.62m, "Soft", "Bacon" },
                    { new Guid("72003795-ec9a-4b02-98f5-ea1cc3e259e3"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 407.27m, "Concrete", "Cheese" },
                    { new Guid("7249ea5c-ab2e-4f3f-a661-e78bcf0832b2"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 167.65m, "Soft", "Chicken" },
                    { new Guid("75111d6d-06c0-4a4e-8c98-fc483eabef98"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 857.24m, "Wooden", "Bacon" },
                    { new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 691.70m, "Concrete", "Soap" },
                    { new Guid("7ad10cbc-6e7f-4c62-88d0-7844449ff012"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 168.38m, "Frozen", "Keyboard" },
                    { new Guid("7c0abed5-11c6-4b13-b8d6-006e7e657532"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 613.98m, "Metal", "Cheese" },
                    { new Guid("7d2a2196-2c6e-4b0d-a190-fa766238b28c"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 207.45m, "Granite", "Bike" },
                    { new Guid("7d4f838e-8531-4ffb-9951-5272da37f109"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 921.67m, "Fresh", "Cheese" },
                    { new Guid("7dd3612b-1beb-453f-bbd4-4c9922bfe55c"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 544.09m, "Plastic", "Salad" },
                    { new Guid("7de88853-b8d3-44c2-9eb6-039c95d2e5a1"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 332.29m, "Soft", "Pizza" },
                    { new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 118.02m, "Granite", "Keyboard" },
                    { new Guid("8d5476fc-d7a5-4f03-af2f-daa8b5b33188"), "The Football Is Good For Training And Recreational Purposes", 653.81m, "Plastic", "Shoes" },
                    { new Guid("8ec348e4-39d7-41f0-b130-26ea13df4cb5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 461.55m, "Plastic", "Chair" },
                    { new Guid("91ca4a95-aec9-4498-9f10-ad2825e2cdb5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 375.07m, "Granite", "Sausages" },
                    { new Guid("925b1758-4588-4f53-a7d0-6f30808f8585"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 356.75m, "Rubber", "Soap" },
                    { new Guid("9590b338-faa6-497d-b86a-032436291832"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 541.62m, "Plastic", "Car" },
                    { new Guid("99ac08d3-d873-4e45-aa85-df08f33a0db0"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 358.36m, "Fresh", "Computer" },
                    { new Guid("9f11a0cc-f2d1-4aa3-9f25-a945122e053b"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 50.11m, "Concrete", "Salad" },
                    { new Guid("a09a513b-cf49-41aa-843f-318aedab497a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 120.35m, "Cotton", "Hat" },
                    { new Guid("a8500346-4973-4a38-a803-5f544e093f75"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 69.94m, "Rubber", "Tuna" },
                    { new Guid("ae2f87cd-8883-42dd-94c4-6c12b1515840"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 517.31m, "Steel", "Pants" },
                    { new Guid("ae4df5c1-b4c5-4e29-bf37-62799c0923b1"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 833.14m, "Steel", "Pizza" },
                    { new Guid("b16c1208-20a5-41b1-9a4b-4dc1adea2036"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 978.42m, "Steel", "Bacon" },
                    { new Guid("b18dce57-6361-43fd-af9c-c0353017140c"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 370.60m, "Steel", "Shoes" },
                    { new Guid("b35e2a5b-c070-45e3-9554-e42d66f9823d"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 504.91m, "Plastic", "Table" },
                    { new Guid("b58906ae-aca7-4e79-9bfa-8b9fad43e555"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 583.80m, "Soft", "Car" },
                    { new Guid("b720a29d-da68-4da7-8fa4-751f879a186a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 903.65m, "Soft", "Tuna" },
                    { new Guid("b7e33c6c-1a5f-46ab-9e82-7cdfc74ac037"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 830.05m, "Rubber", "Cheese" },
                    { new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 907.90m, "Fresh", "Ball" },
                    { new Guid("bb893e9f-024b-4b0d-8af3-8eb0aad9154f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 80.99m, "Rubber", "Gloves" },
                    { new Guid("bfacd1cd-4524-4a7a-88d8-5ccfa95b9c43"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 502.23m, "Steel", "Pizza" },
                    { new Guid("c0b3b1fa-4d7b-456b-a923-7ade7f99326f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 21.93m, "Granite", "Shoes" },
                    { new Guid("c29da83d-8034-4293-81ab-35d5750bf4bb"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 366.03m, "Steel", "Mouse" },
                    { new Guid("c601d2b9-9a0d-4eef-af09-77f025fcbfe1"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 70.15m, "Wooden", "Computer" },
                    { new Guid("c82e9144-ee18-48e3-bec5-feca8a654e40"), "The Football Is Good For Training And Recreational Purposes", 60.20m, "Rubber", "Chair" },
                    { new Guid("cbaaed48-abad-449d-8cdf-cc2cf7098d3f"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 365.45m, "Concrete", "Keyboard" },
                    { new Guid("cbd81ac2-af19-4668-a5fd-eeeabf4fe71b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 987.30m, "Frozen", "Salad" },
                    { new Guid("cd9f6b17-67db-4a67-a837-addb6be95bfa"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 825.74m, "Soft", "Towels" },
                    { new Guid("d2bf338a-1bd2-41c8-b154-adc567aaebfa"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 531.61m, "Concrete", "Hat" },
                    { new Guid("d6f9b017-4069-4e9d-9f70-7f2bbcf400a9"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 486.64m, "Wooden", "Keyboard" },
                    { new Guid("d717e21d-2f19-41f7-b7c6-4d94bc2b6f95"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 287.09m, "Rubber", "Pants" },
                    { new Guid("da25e087-14e2-4ede-84b1-6054195818b6"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 290.52m, "Cotton", "Computer" },
                    { new Guid("dbf7a227-ad3c-41c6-a925-e1d99b3ebc92"), "The Football Is Good For Training And Recreational Purposes", 308.86m, "Metal", "Computer" },
                    { new Guid("de545f40-b45f-432a-8aa9-b3832dd38122"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 968.83m, "Metal", "Gloves" },
                    { new Guid("e0edd8b6-a94e-48ca-b0ad-f68fdd80260c"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 825.62m, "Fresh", "Pizza" },
                    { new Guid("e11404fa-ae62-452d-ad2d-bda60893e803"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 751.63m, "Concrete", "Towels" },
                    { new Guid("e4b1dab0-0c3c-444d-b314-7f6f53d68516"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 264.11m, "Metal", "Bacon" },
                    { new Guid("e5764c37-03d5-4cb4-aaf8-c4458a0cbf55"), "The Football Is Good For Training And Recreational Purposes", 605.26m, "Steel", "Keyboard" },
                    { new Guid("e59bd4bf-bc3b-4cf4-a57c-1c74fd30350c"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 503.84m, "Cotton", "Bacon" },
                    { new Guid("e721335a-5a69-483c-abef-e6a8f7b327d3"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 319.25m, "Steel", "Sausages" },
                    { new Guid("f3c79597-d21d-4162-a023-aebae482889d"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 55.59m, "Frozen", "Tuna" },
                    { new Guid("f44972c6-8fd5-49b4-8682-9fa87e1010fe"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 817.25m, "Concrete", "Computer" },
                    { new Guid("f65f4440-6f5f-4b63-9bf9-bfbb954e7f60"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 75.49m, "Granite", "Tuna" },
                    { new Guid("f6e05e7d-51ff-465d-9b2d-29c3ff977562"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 572.24m, "Plastic", "Pants" },
                    { new Guid("f829e3a8-a969-4368-9891-785763f3bf67"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 832.71m, "Frozen", "Pizza" },
                    { new Guid("fe79abf3-02a3-4a6b-8034-7f4b0886b10c"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 375.05m, "Metal", "Cheese" }
                });

            migrationBuilder.InsertData(
                table: "Customers-table",
                columns: new[] { "Id", "CountriesId", "Email", "FirstName", "LastName", "Locations", "Mobile", "Password" },
                values: new object[,]
                {
                    { new Guid("00afe744-458c-4eba-8d64-caad6772f50e"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Ann.Trantow50@gmail.com", "Ann", "Trantow", "95755 O'Connell Union, Mitchellberg, Central African Republic", "324.396.4694", "rHK1_vw1me" },
                    { new Guid("00caf0a4-8012-4b60-97d9-2980c8854381"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Ken_Feil38@hotmail.com", "Ken", "Feil", "457 Goodwin Prairie, North Lethamouth, Djibouti", "(346) 236-2785 x30898", "qKsBAMw1qz" },
                    { new Guid("01606516-fa32-46a7-b561-06a6f65f92b2"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Ryan_Durgan23@gmail.com", "Ryan", "Durgan", "46737 Jody Keys, Cristianfurt, Virgin Islands, U.S.", "592-378-1454 x2132", "OQXGcUqEcb" },
                    { new Guid("0249c6fa-af09-4f9a-ba67-03b57c195dbd"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Donald.Wehner@gmail.com", "Donald", "Wehner", "20761 Ward View, Port Bradfordland, Netherlands Antilles", "1-352-702-1722 x1272", "vp4SyZOAwX" },
                    { new Guid("043df866-51a0-42e1-8427-14a5ea69cfaa"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Jeremiah.Hagenes19@gmail.com", "Jeremiah", "Hagenes", "0689 Lang Shores, East Coleman, Saudi Arabia", "1-700-596-3114 x884", "0UR_3xsZfL" },
                    { new Guid("07bb97cd-a5bb-4b92-ae2d-3d579e646cd6"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Leigh.Ullrich34@yahoo.com", "Leigh", "Ullrich", "74499 Osinski Roads, West Joana, Germany", "228-657-2188 x034", "hSmSweLCE7" },
                    { new Guid("085c9cd0-665b-4bbe-96a7-6f4ebfde37f5"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Malcolm.Willms@gmail.com", "Malcolm", "Willms", "67792 Volkman Hill, Ricetown, Cuba", "823.210.6440", "xt6dYfSASj" },
                    { new Guid("0b661bb9-ef64-4856-b39d-742660d36497"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Geoffrey.MacGyver18@yahoo.com", "Geoffrey", "MacGyver", "022 Von Run, Port Chandler, United States of America", "997-556-9745 x3549", "HbFhPbpRss" },
                    { new Guid("0c7e0e03-47b1-47f8-912d-fa6f13c85e8c"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Christine_Shanahan@yahoo.com", "Christine", "Shanahan", "830 Romaguera Junctions, Tobyport, Zimbabwe", "668-546-2336 x201", "GBsiRvctET" },
                    { new Guid("0ed754ad-2c6a-4c74-9aac-1ab065f239f0"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Steven66@hotmail.com", "Steven", "Will", "1520 Smitham Fall, North Mavistown, Slovenia", "(879) 858-0797", "C2xy_n6OEy" },
                    { new Guid("1087765e-6906-45f0-bb5b-6cb7b20b5bca"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Iris.Adams@gmail.com", "Iris", "Adams", "0008 Breana Locks, South Stanfordtown, Burundi", "1-997-908-3170", "RcEoSMBjeD" },
                    { new Guid("1146f334-1956-4be4-a5b7-542b911b68a1"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Kathleen.Wiegand81@yahoo.com", "Kathleen", "Wiegand", "4564 Wiza Mountain, Johnsonstad, Anguilla", "1-792-757-3462 x26970", "zzfCRlUFLy" },
                    { new Guid("116c74c5-2362-47f9-a575-6a9c9d3bf2e5"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Caleb_Gleason15@yahoo.com", "Caleb", "Gleason", "1427 Rau Stream, New Darrellstad, Svalbard & Jan Mayen Islands", "409.272.9522 x43599", "Xpf7jRhHZ9" },
                    { new Guid("147fef06-4efe-4ae3-bd0a-0fc232d81dd9"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Warren.Bogisich95@hotmail.com", "Warren", "Bogisich", "421 Zboncak Loaf, South Anaistown, Saint Vincent and the Grenadines", "231.857.9933 x26689", "ZF_Tfwlinw" },
                    { new Guid("17a33985-357c-4698-b820-484f1e70cfd7"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Gilbert_Kessler@hotmail.com", "Gilbert", "Kessler", "4134 Rebeca Skyway, Electachester, Tonga", "457.584.1678 x692", "JEnr6l3bBO" },
                    { new Guid("182c27e0-53c2-441e-a462-3c1ec3bb848f"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Hubert38@yahoo.com", "Hubert", "Botsford", "142 Lynn Wells, Muellerfort, Croatia", "(537) 578-0200", "cB053UaUBN" },
                    { new Guid("18bfaa32-d8b4-4365-a901-bb8ba529a413"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Sadie.Simonis1@yahoo.com", "Sadie", "Simonis", "58773 Schumm Island, Demariomouth, Montenegro", "1-985-375-0555 x64695", "U2TUN9kjkK" },
                    { new Guid("1a2c4cf1-d146-462a-9c65-18557dfb88e2"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Darlene_Feil10@hotmail.com", "Darlene", "Feil", "620 Sheridan Springs, Eulaville, Mongolia", "1-979-775-9182 x65325", "uUJLrwN33j" },
                    { new Guid("1d730f4e-70b3-4938-b9b8-ad8eba50f069"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Cassandra.VonRueden@yahoo.com", "Cassandra", "VonRueden", "26226 Davis Ramp, O'Konview, Seychelles", "429.259.6622 x63512", "UC5Lz52EUM" },
                    { new Guid("1f9a2067-b3f0-4521-8454-282af11c2193"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Edwin_Kerluke@gmail.com", "Edwin", "Kerluke", "6568 Gladys Forge, Dickishire, Guinea", "1-297-353-5272", "CO7CtyXXoZ" },
                    { new Guid("21f2f1ee-cee8-444d-95cd-c5721ce5bda1"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Saul_Cassin@hotmail.com", "Saul", "Cassin", "243 Edythe Spurs, Kaitlynhaven, Democratic People's Republic of Korea", "1-732-350-0560", "fkBtn9EvLe" },
                    { new Guid("22f4ed27-c370-4152-a1cb-f006125f1022"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Neil.Dooley@yahoo.com", "Neil", "Dooley", "466 Ortiz Ramp, South Lydia, Georgia", "(729) 296-7001", "sL90R92sIR" },
                    { new Guid("24f4e729-2e2a-4687-aa1e-770feb474760"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Dustin72@yahoo.com", "Dustin", "O'Keefe", "9163 Hartmann Inlet, West Curt, Comoros", "1-854-676-3319 x931", "ZL80k5J506" },
                    { new Guid("263e6521-0e0d-4314-89b4-7a301b2139a6"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Noel20@hotmail.com", "Noel", "Schulist", "0649 Smith Curve, Gabriellaland, Seychelles", "(937) 432-3237 x7353", "O4TGqS4Dyj" },
                    { new Guid("299573d6-a13f-47a3-859d-95545559a160"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Benny.Hahn3@hotmail.com", "Benny", "Hahn", "185 Ilene Plain, Port Rex, Maldives", "(781) 473-8051 x4063", "qJ4Ydpnftw" },
                    { new Guid("2f8438fe-8db2-42db-b999-b41b0e3a2952"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Arlene76@hotmail.com", "Arlene", "O'Hara", "14639 Khalil Glens, North Kamren, Falkland Islands (Malvinas)", "1-884-514-9088", "77Usba6YYs" },
                    { new Guid("2fb274aa-2957-4b67-9449-e7cd568f3348"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Matthew44@yahoo.com", "Matthew", "Waelchi", "355 Bernier Summit, New Maegantown, Nicaragua", "720.524.3597", "kiwKtOQsW_" },
                    { new Guid("30c19ca0-6608-4b58-8f4b-30bdcd6f4d25"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Stewart_Macejkovic@hotmail.com", "Stewart", "Macejkovic", "43591 Cremin Plains, Port Stephanstad, Sri Lanka", "575.420.7440", "1w35VGaekV" },
                    { new Guid("31786c5a-c79d-4037-b8b8-c318a7a50819"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Byron_Huel@yahoo.com", "Byron", "Huel", "942 Upton Terrace, Kleintown, Cuba", "754.744.6630 x1264", "XkIYLSYJmO" },
                    { new Guid("3187855d-deea-4786-8ad8-fed8b6d03306"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Don.Ferry74@gmail.com", "Don", "Ferry", "6988 Deon Crest, Lake Brandtside, Nauru", "214-744-3146 x933", "kxBGS0jJce" },
                    { new Guid("33613afd-3879-4eec-a940-0134de6556d1"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Lamar.Sporer81@gmail.com", "Lamar", "Sporer", "48889 Lela Ramp, West Christopherton, Norway", "1-860-734-5343 x96171", "bGVQgm4KdR" },
                    { new Guid("344deb2d-d004-4398-b98f-03ac2c95831b"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Shirley_Hickle@yahoo.com", "Shirley", "Hickle", "7473 Beier Pass, Wilkinsonmouth, Uganda", "1-505-902-4849", "gIlcCo_XY0" },
                    { new Guid("35d49030-52ea-4d94-95b0-45dbbb3a67f9"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Jenna.Champlin@yahoo.com", "Jenna", "Champlin", "5657 Imani Ville, Caleighview, Peru", "(249) 338-2229 x9935", "17qc8A9Y8L" },
                    { new Guid("3651b3be-cb8a-4cd5-89c6-825da693769c"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Cody_Orn@hotmail.com", "Cody", "Orn", "780 Oswald Hill, Lake Catalinaborough, Romania", "727.485.7277", "DHwsPztwNW" },
                    { new Guid("373c10a4-7033-44a3-a7f1-53d29c301266"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Manuel_Witting38@yahoo.com", "Manuel", "Witting", "3117 Dach Street, Marlinbury, Syrian Arab Republic", "765-568-2792 x78823", "WkWA4Lk8ok" },
                    { new Guid("387c0c53-ea3a-4724-8a0f-543895fcdeb3"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Genevieve.Windler@hotmail.com", "Genevieve", "Windler", "53153 Brody Village, Leuschkeport, Senegal", "1-723-379-3360", "zWhUWmj1pW" },
                    { new Guid("397980a4-17c5-49e7-854d-908397640c8d"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Nichole_Pfeffer45@hotmail.com", "Nichole", "Pfeffer", "7951 Mayert Ford, Balistrerishire, United States Minor Outlying Islands", "479.969.8662", "Lf5wf0XHKv" },
                    { new Guid("3c2b0e85-8ec4-4c44-a9fa-108915ff6e95"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Ed_Abernathy@gmail.com", "Ed", "Abernathy", "69370 Hank Summit, Joanfurt, Botswana", "(963) 720-5041 x932", "izBaSM_QBP" },
                    { new Guid("3c82604e-35c8-48cb-9cf5-3adf95688758"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Micheal41@hotmail.com", "Micheal", "McGlynn", "669 Rosenbaum Divide, West Ayana, Niger", "(991) 817-0678", "a42FHzSFAs" },
                    { new Guid("3e1697cd-49a6-4971-8e04-8c8fb2202683"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Hugo.DAmore64@yahoo.com", "Hugo", "D'Amore", "18246 Alisha Stravenue, Lake Ivory, Solomon Islands", "1-523-672-1603", "Y8hlQ9S0uX" },
                    { new Guid("3eb4da70-d071-4a2b-b28a-ec81b5b5a7e9"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Ronnie.Dibbert26@yahoo.com", "Ronnie", "Dibbert", "653 Sauer Glens, Helenamouth, South Africa", "308.568.6409 x5698", "TVZsEGjXJX" },
                    { new Guid("427ca2b9-ed72-4f63-8df5-44653308fea8"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Taylor60@yahoo.com", "Taylor", "Witting", "2729 Milan Bridge, West Madisen, Dominica", "1-247-535-9866", "MC47YiAP8H" },
                    { new Guid("443dc73f-e1e0-41a6-abe3-e30bf214f25f"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Ben1@gmail.com", "Ben", "Berge", "913 Eloy Branch, North Elfriedahaven, Holy See (Vatican City State)", "380-946-8768", "xqgNamm5WW" },
                    { new Guid("48b8dc58-8c6b-4aa9-b42e-13cd2bb73725"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Isabel_Hackett30@gmail.com", "Isabel", "Hackett", "2427 Macejkovic Trail, Furmanside, Denmark", "1-635-261-8874 x18314", "nWM5Gw_75W" },
                    { new Guid("49648a9c-aa6a-468e-afd6-0342b3e5d79b"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Sergio11@yahoo.com", "Sergio", "Kohler", "66667 River Mission, Hamillberg, Canada", "224-926-3895 x53573", "bmwF1KiriB" },
                    { new Guid("4cb71a8b-c2fa-44eb-8855-44751f563056"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Wesley41@hotmail.com", "Wesley", "Weimann", "99632 Hartmann Ports, Jamirbury, Turks and Caicos Islands", "223.529.9653", "am5klLg8ry" },
                    { new Guid("4cf7d799-3ddb-40cf-9926-3f424fa33e78"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Teri_Purdy52@hotmail.com", "Teri", "Purdy", "70630 Marks Groves, New Shyannemouth, Ukraine", "301.427.4840", "rRNfklHZjY" },
                    { new Guid("4f10a319-197d-4c9a-afe1-f01ae00771c9"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Jeremy_Collins@yahoo.com", "Jeremy", "Collins", "1746 Murphy Divide, South Mya, Hungary", "1-459-854-5667 x55817", "n4RF217MJE" },
                    { new Guid("51a8a7b9-b52c-491c-b275-0131e9608b21"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Adam.Daniel@gmail.com", "Adam", "Daniel", "84955 Swift Parkways, Adamouth, Vanuatu", "211-473-0903 x944", "RGIBm6320T" },
                    { new Guid("52bade64-2d79-4967-a666-3a425d2c6a97"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Jeannie14@gmail.com", "Jeannie", "Pfannerstill", "85252 Lenora Trail, Wolfstad, Haiti", "384.853.1015 x51895", "0eLYP3wz5G" },
                    { new Guid("5405c00e-657d-4835-a212-bbb4694fe48e"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Angelo_King@hotmail.com", "Angelo", "King", "4475 Ernesto Manor, New Geraldland, Guam", "475.419.9711 x747", "dezdg0UN_8" },
                    { new Guid("54e25f24-5567-4613-882e-9c5f910737d1"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Clifton.Renner83@gmail.com", "Clifton", "Renner", "82525 Carolyne Glen, Port Jamelland, Bahamas", "399-241-6289", "V0k3oLPQrE" },
                    { new Guid("564a24fa-a42d-4993-9d69-c3b01a183be9"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Alice57@gmail.com", "Alice", "Schroeder", "657 Rohan Cliff, Jacobsonshire, Albania", "953.388.5537 x8163", "y78VJlx74X" },
                    { new Guid("59f0d7c8-2a80-4cd3-bcf3-039d8b3effa7"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Alexandra33@hotmail.com", "Alexandra", "Walsh", "8433 Fahey Circle, Fritzton, Tonga", "1-394-977-7071 x4466", "pt19H5Imk8" },
                    { new Guid("5d618fc4-0fa9-4b82-8745-1a7b52ed9702"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Rosemarie28@yahoo.com", "Rosemarie", "Willms", "017 O'Keefe Isle, Reichelport, Nepal", "1-281-494-6743 x13227", "fpdLt6qRPH" },
                    { new Guid("5d87e023-578f-4b42-8cd6-7a96589bdbe0"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Simon_Brakus36@gmail.com", "Simon", "Brakus", "1786 Joaquin Extension, Anjalistad, Oman", "279-935-3342", "HBbTjjqrx8" },
                    { new Guid("5f2d4af3-c279-4069-8cb8-11aba5d70f5e"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Terrance_McCullough97@gmail.com", "Terrance", "McCullough", "4392 Camryn Loaf, East Ilene, Slovakia (Slovak Republic)", "936.623.9367", "4gRGpBp7nh" },
                    { new Guid("62b29526-0262-4603-a695-574e736d0630"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Brendan43@hotmail.com", "Brendan", "Weimann", "4502 Jasmin Shoal, New Wilfredview, Honduras", "462-526-3184 x234", "t8UT540SGL" },
                    { new Guid("63532fd5-59cf-429a-8c5f-fb6fe8fe284d"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Kelley.Durgan@yahoo.com", "Kelley", "Durgan", "91298 Arianna Passage, Lake Aryanna, Pakistan", "514.441.2578 x337", "qA8fBED9Ou" },
                    { new Guid("6528b57e-6dd8-4b35-93dc-9ea6f16c785c"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Wilbert21@gmail.com", "Wilbert", "Jacobs", "6764 Bobbie Stravenue, Domenicohaven, Barbados", "1-485-365-1571", "p3UN01Niol" },
                    { new Guid("696d3f24-c5c9-4363-a15e-9f1a12607e0d"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Johnny15@yahoo.com", "Johnny", "Rogahn", "68767 Raphael Crest, New Theresia, Kiribati", "529-631-2411 x555", "8Azs7IIPi5" },
                    { new Guid("69d1df30-2daa-4985-b1fc-572c86baa7a3"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Terrell_Macejkovic36@gmail.com", "Terrell", "Macejkovic", "244 Volkman Well, Estefaniamouth, Taiwan", "1-678-970-9903 x1478", "_gMVeBXDqc" },
                    { new Guid("6a4fcac1-5e26-4539-8573-fadc92d4419a"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Violet.DuBuque85@yahoo.com", "Violet", "DuBuque", "374 Wolf Burg, Watsicaland, Equatorial Guinea", "1-521-201-6776", "9WrWII27fG" },
                    { new Guid("6a94fd40-e06d-435d-88f3-f9fc40c18ae0"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Cedric_Howell9@hotmail.com", "Cedric", "Howell", "141 Ullrich Ramp, Hunterfort, Cuba", "(494) 801-6094 x5293", "xUfKtYoYXh" },
                    { new Guid("6b8466dd-54d5-48fe-af16-1fa754cdd577"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Lynn.Lueilwitz@gmail.com", "Lynn", "Lueilwitz", "012 Stracke Crossing, North Keith, Dominica", "860-340-2996 x13727", "i3MrSkbCad" },
                    { new Guid("6f47b2af-3ec7-4d33-9297-7c0dc0d8e48a"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Isaac.Hoppe21@yahoo.com", "Isaac", "Hoppe", "581 Otho Rapid, Lemkeburgh, Belarus", "(688) 590-7240 x1135", "kphNxE5vkW" },
                    { new Guid("759ccbda-1a53-4755-96a3-8cfdc2fd2380"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Donnie96@hotmail.com", "Donnie", "Considine", "2745 Gleason Rest, Gusikowskihaven, French Polynesia", "951-581-8297 x07588", "fDpSqF_ZUP" },
                    { new Guid("7646e7c3-a14b-48f6-9fca-e962ab343207"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Ed90@gmail.com", "Ed", "Littel", "231 Maida Meadow, Quitzontown, Democratic People's Republic of Korea", "505.957.7207 x94129", "S6Ilt9Sys6" },
                    { new Guid("7a2d1846-a29f-4a52-9017-a5013097d15e"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Kim_Stehr62@gmail.com", "Kim", "Stehr", "45533 Kailyn Shores, North Mariettaport, Niger", "(805) 874-3127", "UqOLGEYZ7z" },
                    { new Guid("7b1c577c-b049-424f-a4a6-5c1b8757e8db"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Thomas_Jerde@gmail.com", "Thomas", "Jerde", "26161 Ward Road, East Alessandro, Qatar", "(539) 778-5443", "d5x5EV6RAZ" },
                    { new Guid("7c2c0001-3dc2-4a97-ab5a-2baf98bbc83d"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Wayne_Herman58@yahoo.com", "Wayne", "Herman", "0364 Damaris Lodge, South Diana, United Arab Emirates", "513-670-8315 x0875", "gEkf9p5w7C" },
                    { new Guid("7d17c73c-dc9f-4c43-88f6-ed397aa564c7"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Freddie.Pagac@hotmail.com", "Freddie", "Pagac", "12068 Bernhard Street, Lake Matildeview, Cote d'Ivoire", "404-216-5650", "H99oZASnHg" },
                    { new Guid("81eb56c6-bcb0-4354-bf8a-47436f5a6893"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Andrea_Moen@hotmail.com", "Andrea", "Moen", "2247 Corkery Estates, Mollyside, Belgium", "1-686-278-2931 x037", "TJqmAl5_Wc" },
                    { new Guid("82275817-cbf1-4b38-a37e-332a6a7ef772"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Cynthia9@gmail.com", "Cynthia", "Terry", "2363 Melany Cliff, North Verniceport, Equatorial Guinea", "1-310-728-2432", "NvWKWkiUT3" },
                    { new Guid("84ab81c0-33d3-4f02-87e1-6ddc3fcdf9a5"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Wm.Marks77@hotmail.com", "Wm", "Marks", "678 Konopelski Dam, New Melvintown, Sweden", "510.539.7922 x567", "YyL2ijBRGW" },
                    { new Guid("858612bd-20f4-4c42-a88a-ab4f705f31a8"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Pat_Wehner91@hotmail.com", "Pat", "Wehner", "8720 Levi Track, Port Floydberg, Yemen", "1-492-454-7698 x967", "lSD066IgW_" },
                    { new Guid("87762cf8-9b80-4283-a96e-44af311f4f36"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "June_Mills@gmail.com", "June", "Mills", "7322 Gabriel Stravenue, Yadiraton, Sierra Leone", "773-428-7515 x36196", "qreHxGgRUg" },
                    { new Guid("87d3af4d-a14d-42fc-89ad-2af927fb7562"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Melba.Feest5@yahoo.com", "Melba", "Feest", "528 Bogan Loaf, Torpmouth, Haiti", "(440) 211-7955 x386", "MzYUvL5hnD" },
                    { new Guid("891c63f0-c0e9-44f6-96ed-01c8494aa27b"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Shannon.Dare@gmail.com", "Shannon", "Dare", "13707 Moore Stream, Sallieport, British Indian Ocean Territory (Chagos Archipelago)", "789.575.6321 x60272", "FRuqCaMb4K" },
                    { new Guid("8a5c0132-d369-423a-85f9-438acbc9a4f9"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Alberto45@yahoo.com", "Alberto", "Kemmer", "020 Cormier Parkway, Halvorsonbury, South Georgia and the South Sandwich Islands", "1-783-597-8417 x61529", "fs3IlguEi5" },
                    { new Guid("8c1de5bb-b047-4089-87e2-3a3633078333"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Randall51@yahoo.com", "Randall", "Block", "4885 Gleichner Canyon, Kozeyshire, Mozambique", "1-689-522-7461 x948", "FV_4IxoUFn" },
                    { new Guid("8d88f3ba-1533-4875-a882-5dfe3dddbe48"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Tiffany55@gmail.com", "Tiffany", "Stiedemann", "93485 Francisca Locks, New Dane, Trinidad and Tobago", "1-585-603-1107 x95419", "0pUGWqETPt" },
                    { new Guid("8f4f1164-56e2-48a7-b79b-268442935922"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Caleb.Haley93@gmail.com", "Caleb", "Haley", "3562 Mraz Forge, Botsfordmouth, Denmark", "(621) 270-7552", "6x2JEUbXQF" },
                    { new Guid("904fc829-65d4-4499-a1d4-a03739435b61"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Vanessa.Hintz@gmail.com", "Vanessa", "Hintz", "26325 Roob Tunnel, Robelland, Iraq", "703.841.2263", "AWQsXstwhC" },
                    { new Guid("914e2a87-e2d9-4de9-aa9c-14b032c12b83"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Lyle.Bauch3@hotmail.com", "Lyle", "Bauch", "467 Funk Ranch, East Harleystad, French Southern Territories", "209.939.6262 x7823", "w9LU6y5jaJ" },
                    { new Guid("98a8f3c2-9aa1-4ae6-b053-a0a3267a96c6"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Brett.Waters@gmail.com", "Brett", "Waters", "382 Edmond Road, North Elveraton, Cook Islands", "(347) 232-8609", "iNJSQWTDkH" },
                    { new Guid("9bd365ed-64a8-4519-9c6a-e27de9654514"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Dixie_Rice37@hotmail.com", "Dixie", "Rice", "40191 Gregory Glens, East Rachael, Wallis and Futuna", "(768) 857-0556 x065", "kd9kLptGpV" },
                    { new Guid("9d1d01a4-b396-47c1-aa13-be2deddee168"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Andre_Daniel63@yahoo.com", "Andre", "Daniel", "772 Vilma Plaza, South Dallin, Isle of Man", "1-973-618-5124 x0216", "oPjxkk7eWu" },
                    { new Guid("9e409e88-4831-4244-9081-f8863f49966e"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Randall.Herman@hotmail.com", "Randall", "Herman", "4320 Feil Plain, New Cortezview, Taiwan", "737.505.0640", "j71hW09V3_" },
                    { new Guid("a0fc5659-b7f6-4377-a700-cb096a23ca11"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Blake95@yahoo.com", "Blake", "McKenzie", "41870 Rachelle Mews, Port Lisandroland, Lebanon", "421-331-8047 x66887", "Jt7l1lUlwJ" },
                    { new Guid("a1f48068-ee56-4305-9f7c-7d59cb68e829"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Jim_Braun@gmail.com", "Jim", "Braun", "7782 Diana Hollow, New Earnestine, Botswana", "(645) 252-9292", "4OStkdqtXm" },
                    { new Guid("a2886eb8-852a-47f0-b761-921d70b9d3d0"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Pablo.Hane1@hotmail.com", "Pablo", "Hane", "415 Morissette Station, Roobtown, Isle of Man", "(811) 412-5328 x79652", "gmI1_7nTTU" },
                    { new Guid("a60f234d-2079-416c-9fcd-2ce1f8447116"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Warren.Stanton@gmail.com", "Warren", "Stanton", "82908 Zulauf Overpass, Hayleebury, Bolivia", "710.764.3741 x60352", "g8OUvOrcN_" },
                    { new Guid("a6c8d078-69a7-48c3-9b54-0a120f990662"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Naomi.Botsford53@gmail.com", "Naomi", "Botsford", "031 Keshaun Forge, Lake Shany, Iran", "506.643.4260", "jjYc4u8Bfy" },
                    { new Guid("a6ebfea8-801a-443b-b8bd-763414b370f7"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Morris40@gmail.com", "Morris", "Leuschke", "0153 Walker Neck, West Daphneport, Guatemala", "(935) 476-2563", "IonqputO2P" },
                    { new Guid("a7426aaf-7b25-431e-b488-9d54e5e7ed85"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Troy.Brakus@gmail.com", "Troy", "Brakus", "8120 Schowalter Center, Lake Cora, French Southern Territories", "636.317.2804 x283", "3VmKM1cZ3m" },
                    { new Guid("a7f16c93-c67d-4ea8-9f2f-2fe32c851622"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Marsha86@yahoo.com", "Marsha", "Kuvalis", "90401 Virginie Locks, West Vincentton, Germany", "832-240-0117 x09751", "pJBsILlNf3" },
                    { new Guid("aa27053a-da7f-4bff-a961-27497885bdce"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Melinda.Hegmann@gmail.com", "Melinda", "Hegmann", "8549 Sven Lodge, Lake Alejandrastad, Oman", "(460) 766-5323", "qP5VxxqGCJ" },
                    { new Guid("ab29ae4a-2453-44d4-9930-8910cd6dd7eb"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Harold.Marks66@gmail.com", "Harold", "Marks", "676 Collier Union, Port Tyrique, China", "1-318-306-6578 x59124", "Fhf7kj_5_i" },
                    { new Guid("abe702d0-9fc5-4d0c-8bed-fc33ea76483f"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Harvey.Fay31@gmail.com", "Harvey", "Fay", "687 Rico Harbor, New Jacynthe, United States Minor Outlying Islands", "(415) 495-2318 x02567", "N6BRRYN7Eo" },
                    { new Guid("add0bcdc-3727-4c61-b8be-d63a9b2a3818"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Perry_Kautzer@hotmail.com", "Perry", "Kautzer", "6476 Legros Summit, Port Tatyanamouth, Macao", "(864) 490-9372 x2984", "qc4FF2TlZE" },
                    { new Guid("aed732b1-e34a-4a03-ac59-d09e09d061ad"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Evelyn_Swift51@gmail.com", "Evelyn", "Swift", "7029 Grady Isle, Howellchester, Palau", "415-394-2482 x59771", "wsuXwpE1sV" },
                    { new Guid("b20b5673-5236-471d-be3d-2e9e76f6503b"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Lucy91@gmail.com", "Lucy", "Murphy", "259 Bailey Forges, Dickimouth, Brunei Darussalam", "1-263-350-7969", "b6CNjT9VJR" },
                    { new Guid("b40b123e-bea6-4d84-ae9d-2e2a8b595d08"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Sara96@hotmail.com", "Sara", "Batz", "03125 Florida Valley, Krajcikton, Bhutan", "(299) 415-8936 x4113", "vsH3GbqaBm" },
                    { new Guid("b5084287-98ad-4aef-8260-45fa0d1ed221"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Rodney.Denesik18@hotmail.com", "Rodney", "Denesik", "48319 Louisa Corners, Jacobsmouth, Russian Federation", "(584) 759-8397 x95521", "uQoaEeGUUQ" },
                    { new Guid("b70bbec4-02f0-401f-a39e-adeb5483b2ea"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Margie.Stiedemann@gmail.com", "Margie", "Stiedemann", "0013 Sawayn Land, Krisport, Burkina Faso", "571-713-5651", "7wxe3kiXSP" },
                    { new Guid("bd394875-37fd-426e-80b9-f084f9db95da"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Loretta_Lynch63@yahoo.com", "Loretta", "Lynch", "3941 Tad Brooks, Terryfort, Marshall Islands", "570.864.4540 x4562", "pmm76CEx5E" },
                    { new Guid("be2c4a7b-f639-45d7-ac48-1088a3078d5a"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Kathryn_Nitzsche@gmail.com", "Kathryn", "Nitzsche", "15818 Christiansen Crossroad, Howellfort, Nicaragua", "(453) 741-5512 x58278", "LKxFDTXEtJ" },
                    { new Guid("bed3ff7d-8a6c-4ae4-9931-ffa71c59c60e"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Benjamin_Williamson48@yahoo.com", "Benjamin", "Williamson", "0488 Alejandra Inlet, South Reggie, Kyrgyz Republic", "955-377-0343 x4082", "VdtEWYZd5d" },
                    { new Guid("c208c68e-ca89-4ab5-b546-4a25ea6fae1b"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Meredith_Zemlak80@gmail.com", "Meredith", "Zemlak", "89279 Lane Springs, West Art, French Guiana", "322.879.9684 x072", "uC4ZbzXd7Z" },
                    { new Guid("c232ab4d-4964-4769-9761-8ef78c42020b"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Paula52@gmail.com", "Paula", "Hauck", "193 Isaac Cove, New Israel, Rwanda", "(541) 384-4823 x707", "3Hv2lrtcaB" },
                    { new Guid("c62df072-9f4a-43e5-bfe2-99f1f77605ea"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Tanya_Willms47@yahoo.com", "Tanya", "Willms", "098 Bailey Station, South Solonview, Uzbekistan", "488.780.9215 x33434", "fZLOYaezFX" },
                    { new Guid("c871d1a9-5dbe-4d70-82fb-79696afd83f5"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Sylvester57@hotmail.com", "Sylvester", "Koss", "3955 Kihn Wall, Gusikowskistad, Gabon", "768-610-4154", "bbVpXKAA5K" },
                    { new Guid("c91d6fe3-4a6a-45a9-a4bc-1e14f6788312"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Darrin.Reilly@gmail.com", "Darrin", "Reilly", "7284 Rempel Common, East Nathanael, Guinea-Bissau", "(314) 347-9249", "GRaOR79x5v" },
                    { new Guid("c96bb2ea-aab2-4def-8b4d-66834ac6b80c"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Jeffery59@gmail.com", "Jeffery", "Grimes", "454 Roberts Cape, West Ludieborough, Barbados", "(386) 901-2572", "6h198J4kpJ" },
                    { new Guid("c9a348d9-b5cf-473f-bcbd-6e4de8744ad3"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Lorenzo66@gmail.com", "Lorenzo", "Bechtelar", "131 Aufderhar Field, New Margarettatown, South Africa", "408.595.8881 x605", "dNIwr2VjTO" },
                    { new Guid("ca7fc90c-d334-4471-855e-5e594e72ecb7"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Courtney.Aufderhar@hotmail.com", "Courtney", "Aufderhar", "8095 Loyce Forks, North Graham, Spain", "1-710-237-9010 x1756", "PeEvYAo1Ht" },
                    { new Guid("ce539ec8-f04a-43f1-a38b-03a3c7ff612a"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Marguerite_Schoen@hotmail.com", "Marguerite", "Schoen", "697 Felipa Cliff, Walkerport, Senegal", "(258) 335-3724 x91755", "pjWbEAF4EO" },
                    { new Guid("ce6e1dc0-1efc-49b4-ad83-403128657b82"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Glenn.Thompson0@gmail.com", "Glenn", "Thompson", "22689 Emanuel Overpass, Elmoshire, Vanuatu", "1-583-736-0215", "B6WFoLbamw" },
                    { new Guid("cea1730d-813b-427c-90b5-b3e03e7b34a9"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Deanna.Veum1@hotmail.com", "Deanna", "Veum", "80055 Ratke Point, Waldofurt, Montenegro", "1-408-698-8389", "H2W97OdMuq" },
                    { new Guid("cf3e2b89-c20c-434e-b1fb-17441009bea5"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Tami0@yahoo.com", "Tami", "Hermiston", "430 Schoen Lakes, South Marty, Wallis and Futuna", "695.890.4138", "N3I2dAPW1l" },
                    { new Guid("cf73ad9a-73e6-4bb8-b1ee-7cad4d10655c"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Shannon.Heathcote23@yahoo.com", "Shannon", "Heathcote", "412 Wolff Coves, Elishaland, Malawi", "326.955.6758 x43810", "9RFsqxB4TV" },
                    { new Guid("d13cff65-0fce-4f3b-b3e6-6147ef5870e3"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Emma.Kilback@yahoo.com", "Emma", "Kilback", "28500 Raynor Springs, Starkborough, Singapore", "(694) 362-7013 x466", "CbKlQvmnRT" },
                    { new Guid("d1b92413-9e4b-44bf-88de-a6917f689345"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Colin.Hills69@hotmail.com", "Colin", "Hills", "2759 Javonte Canyon, New Nedraberg, Saint Pierre and Miquelon", "1-247-224-7421 x33263", "D_8hxVy3B2" },
                    { new Guid("d1e1a35a-6eea-4754-99cd-9a647fbd8f21"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Cindy42@hotmail.com", "Cindy", "Jaskolski", "4543 Charlotte Parkway, Maryammouth, Uruguay", "(753) 340-5014 x95207", "2O4MP7y7t0" },
                    { new Guid("d5040d0e-9864-420e-8a81-098040fc24ae"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Mable12@hotmail.com", "Mable", "Lueilwitz", "680 Kenton Falls, North Elzaborough, Ghana", "418-254-1931 x587", "2dfSqLQWyu" },
                    { new Guid("d6a3012c-3fb2-409a-a0d2-9d5e6bd6ce38"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Georgia_Ankunding@yahoo.com", "Georgia", "Ankunding", "52344 Ivy Isle, Lake Richie, Indonesia", "580.313.8512", "Rk1x8Bh3pi" },
                    { new Guid("d6bd267f-53db-4693-b4d7-78d550a86983"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Terry.Mitchell56@gmail.com", "Terry", "Mitchell", "283 Bergnaum Parks, Xzavierstad, Norway", "387.378.7757", "DQG9QwKoLW" },
                    { new Guid("d82c958a-0837-4e66-a4d3-08e2650de5f7"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Priscilla.Kuphal@gmail.com", "Priscilla", "Kuphal", "9579 McClure Ports, South Carletonshire, El Salvador", "(685) 690-4289", "_TgxkQ1j7i" },
                    { new Guid("d9b41fd6-cfa7-4479-a964-eb44928ed038"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Alvin.Pfannerstill67@hotmail.com", "Alvin", "Pfannerstill", "60075 Morissette Crest, Port Madie, Norway", "1-882-648-3077 x54256", "UerUiF_riK" },
                    { new Guid("dde14029-8183-4af8-bf20-f3c93eb9a592"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Lena_Hettinger@gmail.com", "Lena", "Hettinger", "66824 Jalon Fork, West Dejonstad, Switzerland", "(270) 698-9146 x8233", "sETksSQ7BL" },
                    { new Guid("de199f94-39e7-4e57-b9b7-a912925d7c44"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Mabel17@yahoo.com", "Mabel", "Schinner", "6110 Lubowitz Isle, Henriettefort, Lithuania", "(401) 425-0915", "x_5onL3ird" },
                    { new Guid("df8454fe-b559-4f5c-88a2-8017e9568b2c"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Ryan.Monahan@hotmail.com", "Ryan", "Monahan", "2242 Bogisich Avenue, Port Maceybury, Slovenia", "(503) 762-5776", "_ol5YZxnWh" },
                    { new Guid("e2bd7495-4465-454a-adca-2994804c4566"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Carl_Russel@gmail.com", "Carl", "Russel", "41350 Reichert Trail, Kathlynland, Madagascar", "(922) 832-6034 x8214", "_qvAw1ZM82" },
                    { new Guid("e7e13e4a-0bdc-46eb-b9e1-53607f524340"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "May.Davis@gmail.com", "May", "Davis", "22833 Nikko Key, Halvorsonmouth, Tuvalu", "(390) 625-7955 x4211", "fXPj03vINK" },
                    { new Guid("e819bb87-f985-4e62-ba92-0f531cd77ddf"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Elsie44@gmail.com", "Elsie", "Bartoletti", "7201 Lowe Fall, Stiedemannstad, Netherlands Antilles", "(968) 867-1449 x74587", "FoWQwCS6SU" },
                    { new Guid("e82ebe83-bb4b-471d-b59e-a179ba0da57a"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Yolanda_Conroy58@hotmail.com", "Yolanda", "Conroy", "049 Langworth Expressway, Draketon, Isle of Man", "1-257-847-9659 x39414", "kuxUQQCZoQ" },
                    { new Guid("eb90abef-1747-443c-82d1-2e2403b229a4"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Edith98@yahoo.com", "Edith", "Spinka", "77330 Pansy Springs, Kundemouth, Singapore", "453.911.6017 x087", "kCViJ3FS8P" },
                    { new Guid("ee724103-5afe-4b4e-b4d1-d8839911930b"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "James.Collier79@gmail.com", "James", "Collier", "7670 Hegmann Parkway, Rutherfordhaven, Christmas Island", "771.396.8455 x24949", "vOeLhXv3Nk" },
                    { new Guid("eed2952b-a95b-47df-a45a-40419a6ee9de"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Eugene23@hotmail.com", "Eugene", "Mante", "817 Graham Lock, Wilfredport, Guatemala", "1-269-305-9921 x494", "G5XDgyeWjv" },
                    { new Guid("eedf3a46-58b5-48bd-b939-ce27302f2896"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Laurence_Waelchi41@yahoo.com", "Laurence", "Waelchi", "225 Broderick Island, East Jensenmouth, Solomon Islands", "(401) 504-0517 x7479", "w30jq3JwQi" },
                    { new Guid("f03faec8-4357-4479-a362-d51c61285db5"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Alfredo_Toy@hotmail.com", "Alfredo", "Toy", "6717 Kreiger Ridge, Herzogfort, Macao", "731-326-0083", "NkbLpx3Fhn" },
                    { new Guid("f2ebc54f-cc45-4c14-92e9-83b74ff68ac3"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Bert.Brown60@yahoo.com", "Bert", "Brown", "6382 Steuber Camp, West Karine, Mauritania", "1-945-767-5160", "bZmU3CXkmX" },
                    { new Guid("f6b16114-341e-4f44-bf69-51ea35b549e4"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Lydia.Rempel14@yahoo.com", "Lydia", "Rempel", "61182 Vernon Lights, Port Pietro, Djibouti", "640.758.6366 x10027", "jLglP17R_P" },
                    { new Guid("f718c74c-b662-4627-85bc-fa7d0e051bcc"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Clarence.Emard79@yahoo.com", "Clarence", "Emard", "2146 Gideon Manor, West Jaspermouth, Dominica", "660.356.8866 x7061", "2bH8_nFUDx" },
                    { new Guid("f7a00963-1a2f-4811-978b-876e3ac20a86"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Caleb35@hotmail.com", "Caleb", "Herzog", "05817 Ziemann Islands, New Bridgette, Netherlands Antilles", "344-227-0392 x832", "9cVaf4ax3c" },
                    { new Guid("f8a66a17-1f0b-40bd-b1db-102dcf37275e"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Faye.Swaniawski22@hotmail.com", "Faye", "Swaniawski", "46524 Cody Fort, Havenfurt, Ethiopia", "583-973-2982 x295", "XWI2UG0nYr" },
                    { new Guid("fb200add-93d1-4bed-b893-7a97789c2408"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Domingo_Price77@gmail.com", "Domingo", "Price", "172 Swift Harbors, New Colt, Chad", "799-520-8897", "fe91WgUrmS" },
                    { new Guid("fbb5139f-7431-4096-aa6f-000de968ed1d"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Terrance.Mohr87@yahoo.com", "Terrance", "Mohr", "317 Moen Springs, Collinschester, Oman", "337-964-2183", "oqB_T4c4Ph" },
                    { new Guid("fe245078-fc6b-4d8b-b90c-1b443725c6bc"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Willie_Parker86@gmail.com", "Willie", "Parker", "60000 Stracke Valleys, North Lonzoside, Singapore", "(597) 726-5637 x133", "JbmYurwinS" }
                });

            migrationBuilder.InsertData(
                table: "Distributors-table",
                columns: new[] { "Id", "Address", "CountriesId", "Description", "Email", "Title" },
                values: new object[,]
                {
                    { new Guid("13119bc1-131d-4f03-9512-4003df8ad638"), "84154 Daphne Parkway, Conntown, Jamaica", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Operative mobile parallelism", "Medhurst-Cole_Daniel85@gmail.com", "Medhurst - Cole" },
                    { new Guid("16072186-e44c-4667-901d-7576ec5a2d09"), "36503 Brielle Cove, Luciusville, Poland", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Compatible asynchronous help-desk", "HammesOConnerandPrice81@hotmail.com", "Hammes, O'Conner and Price" },
                    { new Guid("1b79d868-9abd-49ed-a58c-20079af2882d"), "95206 Nitzsche Ferry, Stephanieshire, Tokelau", new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "Multi-channelled cohesive throughput", "FadelDouglasandGerhold9@gmail.com", "Fadel, Douglas and Gerhold" },
                    { new Guid("1cd06203-7731-415d-8373-fd185e2fb847"), "1342 Pouros Springs, Drakeland, Trinidad and Tobago", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Organic mission-critical Graphical User Interface", "LemkeBeierandBogan.Bode@hotmail.com", "Lemke, Beier and Bogan" },
                    { new Guid("21b368d8-5d81-4187-8db4-ae9d757fe0f0"), "889 Fritz Underpass, East Obiefort, Israel", new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Multi-layered context-sensitive function", "LangWillmsandStroman.Kris23@yahoo.com", "Lang, Willms and Stroman" },
                    { new Guid("274cafc9-5fbc-4360-9f27-2d27a8036f5d"), "61945 Brigitte Bypass, West Angelo, Australia", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Configurable bandwidth-monitored architecture", "Sauer-Kutch_Bernhard@gmail.com", "Sauer - Kutch" },
                    { new Guid("30395bf4-c7fc-4eb3-b3e2-78024218939e"), "373 Darren Row, Lake Octavia, Senegal", new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Cross-platform exuding middleware", "Wuckert-Grimes_Zieme21@yahoo.com", "Wuckert - Grimes" },
                    { new Guid("357b8a3e-d7aa-4a32-970b-2077b47d378a"), "174 Barton Ridge, North Emanuelfort, Rwanda", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Programmable high-level emulation", "Cassin-Williamson72@yahoo.com", "Cassin - Williamson" },
                    { new Guid("37edb6e2-019c-452c-887b-7b7eff41fea6"), "4236 Streich Cove, Lake Trudie, Bhutan", new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Upgradable zero administration knowledge base", "Considine-Legros.Bogisich8@hotmail.com", "Considine - Legros" },
                    { new Guid("391d302d-0521-48c3-a2d1-38c8f34ab56a"), "7082 Daniel Plaza, West Maximoburgh, Saint Pierre and Miquelon", new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Persistent incremental function", "SchimmelReynoldsandAnderson.Anderson19@yahoo.com", "Schimmel, Reynolds and Anderson" },
                    { new Guid("3b0cf59c-4e1b-41fc-b1aa-23efbe9b7a1c"), "43422 Gleichner Prairie, Lake Rhiannon, Russian Federation", new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Enterprise-wide mobile pricing structure", "BeahanMonahanandMitchell.Ferry@gmail.com", "Beahan, Monahan and Mitchell" },
                    { new Guid("3b92affc-555d-4d61-9816-9d941a0fc283"), "176 Heathcote Burg, Alexiestad, Monaco", new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Adaptive uniform hardware", "MooreBotsfordandHilpert.Bashirian@gmail.com", "Moore, Botsford and Hilpert" },
                    { new Guid("3c17b418-53c4-458e-9a05-acbbd6a30b1b"), "22892 Purdy Estate, Garfieldmouth, Argentina", new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Digitized systematic architecture", "DouglasSmithandWalter.Crist@gmail.com", "Douglas, Smith and Walter" },
                    { new Guid("3d4bb385-e809-4f17-a98e-561ba9be9a59"), "870 Jacobs Square, Corbinfurt, Japan", new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Triple-buffered zero administration frame", "KuvalisToyandDuBuque59@gmail.com", "Kuvalis, Toy and DuBuque" },
                    { new Guid("44aea045-c624-4a88-8a4c-16bf9a1f3a4d"), "22973 McDermott Shores, Gutmannburgh, Brunei Darussalam", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Monitored tertiary challenge", "Toy-Yundt_Mitchell28@yahoo.com", "Toy - Yundt" },
                    { new Guid("4d3e0d22-1a4b-47d9-8696-938e0352ffa6"), "8677 Kenny Island, Gloriaberg, Democratic People's Republic of Korea", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Profound discrete leverage", "CronaMillerandKuvalis86@hotmail.com", "Crona, Miller and Kuvalis" },
                    { new Guid("5d6db18a-423b-4fbf-a9db-1bb3c185b276"), "634 Ward Viaduct, Lake Jayden, Macedonia", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Sharable scalable hardware", "GrahamLLC48@gmail.com", "Graham LLC" },
                    { new Guid("5f6c182f-c84e-4cf3-a22b-60b0cdc2567b"), "265 Leannon Ranch, Aricland, Israel", new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Future-proofed object-oriented concept", "ThielLLC87@gmail.com", "Thiel LLC" },
                    { new Guid("655041ce-81e0-41c7-9986-3c5ce109b346"), "4533 Mitchel Via, Starkville, Congo", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Customizable content-based secured line", "ColeBinsandZemlak.Bergstrom@gmail.com", "Cole, Bins and Zemlak" },
                    { new Guid("6c28dccd-39fc-46b3-8a74-5e5852d89906"), "600 Kariane Corner, Volkmanbury, Austria", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Down-sized bandwidth-monitored process improvement", "GorczanyandSons_Lindgren36@yahoo.com", "Gorczany and Sons" },
                    { new Guid("6e7e13a1-7d46-47c9-ab61-858b5b4ee889"), "997 Odell Crossroad, Simoniston, Lithuania", new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Customer-focused analyzing time-frame", "DAmoreandSons_Gleason@gmail.com", "D'Amore and Sons" },
                    { new Guid("7f4e5c63-8c3f-418d-9ddd-393e12c514bd"), "117 Stokes Viaduct, Lake Adriannafort, Sweden", new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), "Pre-emptive value-added info-mediaries", "SawaynHoegerandBeahan_Rosenbaum82@gmail.com", "Sawayn, Hoeger and Beahan" },
                    { new Guid("8817b259-3ee6-492f-9f9f-b5195582e103"), "39533 Leonie Stream, North Bernadette, Venezuela", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Devolved system-worthy support", "SwaniawskiGroup.Lindgren@hotmail.com", "Swaniawski Group" },
                    { new Guid("88e04095-f893-4fec-aea7-da1ba130ffa1"), "0072 Janick Rest, New Laurianne, Zimbabwe", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Profit-focused demand-driven emulation", "WisokyandSons.Ondricka86@gmail.com", "Wisoky and Sons" },
                    { new Guid("8a410c18-846d-4a7f-9ce0-4fc3ed092608"), "014 Wilfrid Light, Port Judy, Antigua and Barbuda", new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Networked optimal data-warehouse", "JastKonopelskiandSpencer.Skiles@yahoo.com", "Jast, Konopelski and Spencer" },
                    { new Guid("8f448b41-1d1d-426b-80a5-4976c14e8b9f"), "0330 Quigley Turnpike, Lake Makennabury, Dominican Republic", new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Switchable 3rd generation strategy", "TremblayLLC.Flatley89@yahoo.com", "Tremblay LLC" },
                    { new Guid("8f71efd7-49c2-4995-b2da-dadc35659897"), "22349 Winston Spur, Marjolainemouth, Latvia", new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Expanded motivating standardization", "ErdmanInc37@yahoo.com", "Erdman Inc" },
                    { new Guid("8fa0db5e-a4e2-4372-b657-f7320d21fe1c"), "50458 Gunner Alley, Runolfsdottirfort, Tokelau", new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Switchable attitude-oriented methodology", "ReillyStrackeandHansen68@gmail.com", "Reilly, Stracke and Hansen" },
                    { new Guid("912f55ed-4196-40d0-8c18-93dedb0c6bdc"), "67419 Violet Isle, Uptonmouth, Madagascar", new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), "Ameliorated global pricing structure", "Stoltenberg-Wolff_Fisher27@gmail.com", "Stoltenberg - Wolff" },
                    { new Guid("9ab5f718-7d39-43b2-bc67-885e64773645"), "84703 Christ Brook, Estrellahaven, Indonesia", new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Configurable didactic policy", "CormierLLC98@yahoo.com", "Cormier LLC" },
                    { new Guid("9bc069ba-55f3-4f42-b4ec-4b8dfd14834b"), "079 Ebert Glens, North Reese, Benin", new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), "User-friendly local budgetary management", "Senger-Lebsack52@yahoo.com", "Senger - Lebsack" },
                    { new Guid("9bd828f7-a49c-46a5-87ee-65509e25c4e2"), "7181 Mills Forge, New Tillmanton, Bouvet Island (Bouvetoya)", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Self-enabling zero tolerance projection", "Emard-McKenzie_Erdman@gmail.com", "Emard - McKenzie" },
                    { new Guid("9e9c0e97-797b-4dcf-977a-dfb3e8c282fa"), "9300 Abernathy Land, Jarvisberg, Antarctica (the territory South of 60 deg S)", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Realigned interactive implementation", "EbertGroup.Kunze@gmail.com", "Ebert Group" },
                    { new Guid("a3738c1d-2606-42f9-adc3-1170db35949c"), "007 Cruz Valleys, Lindshire, Spain", new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Face to face bottom-line policy", "MillsSchowalterandErdman.Hettinger3@hotmail.com", "Mills, Schowalter and Erdman" },
                    { new Guid("a59122a9-b48c-47f3-b154-94762edcad63"), "26074 Thad Ports, Leannstad, San Marino", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Cross-platform disintermediate solution", "WittingTorphyandVeum.Erdman@gmail.com", "Witting, Torphy and Veum" },
                    { new Guid("ab1c0568-769f-4735-ade7-6ced8f2320e1"), "49778 Aurelie Curve, Chetville, United States of America", new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), "Face to face foreground benchmark", "WelchLLC_Weber@gmail.com", "Welch LLC" },
                    { new Guid("ac1e56a0-9c3b-4cbb-a2c1-b05dbb40ddf7"), "152 Ernser Garden, Alessandroview, Qatar", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Synergized logistical functionalities", "HandErnserandHarris_Greenfelder@hotmail.com", "Hand, Ernser and Harris" },
                    { new Guid("be862533-0dea-443a-9085-adc96203f798"), "2573 Koepp Squares, Smithamshire, South Africa", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Centralized systemic definition", "Herman-Kovacek_Auer@hotmail.com", "Herman - Kovacek" },
                    { new Guid("befa0905-8419-4339-a5db-be1ab6ef8df4"), "00801 Salma Valley, Gislasonmouth, Nicaragua", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Future-proofed 6th generation product", "SmithInc_Farrell@gmail.com", "Smith Inc" },
                    { new Guid("c0f28aee-1ac3-4087-9372-4a4a6b30cdbd"), "1858 Altenwerth Parkways, East Larissa, Zimbabwe", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "Reverse-engineered uniform throughput", "BergeRunolfssonandLebsack33@yahoo.com", "Berge, Runolfsson and Lebsack" },
                    { new Guid("c79f1e95-7683-48aa-954b-9eae9eca0ab9"), "94857 Elton Stream, Lake Spencerstad, Wallis and Futuna", new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), "Customer-focused intermediate neural-net", "GulgowskiandSons_Schneider0@gmail.com", "Gulgowski and Sons" },
                    { new Guid("d2ebbce2-9d37-4693-b5d2-1460bcf6c405"), "10885 Runte Camp, East Harveyview, Kyrgyz Republic", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Public-key empowering standardization", "Bogisich-Kertzmann90@yahoo.com", "Bogisich - Kertzmann" },
                    { new Guid("d4aba8e2-50f4-4060-bb57-7de145d66883"), "44527 Rebecca Canyon, West Ervinborough, Slovenia", new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), "Focused maximized implementation", "Auer-Volkman9@yahoo.com", "Auer - Volkman" },
                    { new Guid("d78d7e2f-d9f3-4067-86ab-782ac54591c4"), "497 Wolff Forge, Roslynberg, Isle of Man", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Cross-group coherent customer loyalty", "OKeefeLittleandWeber_Hudson27@gmail.com", "O'Keefe, Little and Weber" },
                    { new Guid("e3727897-7c0f-410f-b8da-3d1aba40ae41"), "109 Quitzon Ramp, East Maritza, Barbados", new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Future-proofed fresh-thinking hierarchy", "JohnstonLeschandMarvin41@yahoo.com", "Johnston, Lesch and Marvin" },
                    { new Guid("e485d3a9-db16-4da7-a7f3-2b760024bc92"), "80653 Blanda Lodge, Prohaskaburgh, Greenland", new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Inverse methodical open system", "Prosacco-Sauer.Vandervort@yahoo.com", "Prosacco - Sauer" },
                    { new Guid("f132e076-e52d-493c-ac2c-1f443eada908"), "43644 Jensen Forest, Destineyhaven, Germany", new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), "Decentralized cohesive superstructure", "OReilly-Wisoky_Kozey@gmail.com", "O'Reilly - Wisoky" },
                    { new Guid("f6a7bd26-f682-44dc-bf9a-bb7588f8e73e"), "53254 Renner Forks, North Olafchester, Samoa", new Guid("340d3762-4079-46be-a77b-81dba01107b6"), "User-centric responsive challenge", "Bogan-Durgan69@yahoo.com", "Bogan - Durgan" },
                    { new Guid("fba0ab8e-b1ff-409f-b0e9-cef18fc5c290"), "815 Marilyne Ports, North Kaleb, Virgin Islands, British", new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), "Total homogeneous challenge", "DaughertyInc_Lindgren@yahoo.com", "Daugherty Inc" },
                    { new Guid("fcc68519-b992-41a4-92f6-7c8b2ebf519b"), "971 Kathlyn Shores, Port Brainville, Timor-Leste", new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), "Pre-emptive foreground artificial intelligence", "GloverCronaandMacejkovic_Gislason72@gmail.com", "Glover, Crona and Macejkovic" }
                });

            migrationBuilder.InsertData(
                table: "Feedbacks-table",
                columns: new[] { "Id", "CustomersId", "Description", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("00d0324b-9380-4c28-8ebe-56a8a80d0e28"), new Guid("c871d1a9-5dbe-4d70-82fb-79696afd83f5"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("f65f4440-6f5f-4b63-9bf9-bfbb954e7f60") },
                    { new Guid("00ff5e0f-66e4-4d6a-9a17-922fd7ecf0f9"), new Guid("fe245078-fc6b-4d8b-b90c-1b443725c6bc"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("c82e9144-ee18-48e3-bec5-feca8a654e40") },
                    { new Guid("017dba00-6b20-4ffc-abe3-e92ed749ba18"), new Guid("5405c00e-657d-4835-a212-bbb4694fe48e"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("4566aa98-606b-45c2-809d-dc96adbc3f29") },
                    { new Guid("01fee026-6cab-42ad-babf-e9580e1acd98"), new Guid("d6bd267f-53db-4693-b4d7-78d550a86983"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("5fb21ed7-d4b7-45d5-9ecd-7ee6177537fe") },
                    { new Guid("0340fb46-1d20-4df0-aa6c-6ac8aa52dbb7"), new Guid("ab29ae4a-2453-44d4-9930-8910cd6dd7eb"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("3ad91fe1-7c02-49a4-a908-7eba00a54c51") },
                    { new Guid("049de238-2e50-4281-b314-b62b6970f103"), new Guid("a0fc5659-b7f6-4377-a700-cb096a23ca11"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("6f34af44-c1bb-41f8-b5ef-a4c85d8df5b5") },
                    { new Guid("08b99d17-52ea-4500-ba73-cae2cd6ea999"), new Guid("2fb274aa-2957-4b67-9449-e7cd568f3348"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("56a5a710-0a47-42c3-ac66-54730524330d") },
                    { new Guid("0a9456a8-5a16-43af-8dfe-0b4685c18cfa"), new Guid("9bd365ed-64a8-4519-9c6a-e27de9654514"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("03fd0d33-6852-40f9-9529-53edfeb980eb") },
                    { new Guid("0c65effc-881a-41dc-9e60-d607d3b6e2c0"), new Guid("3e1697cd-49a6-4971-8e04-8c8fb2202683"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("2657dae5-6e31-4bc3-8d93-1665e676d327") },
                    { new Guid("10cef452-43c7-4c80-b510-51501dec2747"), new Guid("e82ebe83-bb4b-471d-b59e-a179ba0da57a"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("3ad91fe1-7c02-49a4-a908-7eba00a54c51") },
                    { new Guid("11835a41-ae96-4ed9-baeb-f83f68ceff15"), new Guid("48b8dc58-8c6b-4aa9-b42e-13cd2bb73725"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12") },
                    { new Guid("11f4ad0c-dc38-4bd4-ba15-90d78be96a25"), new Guid("ce6e1dc0-1efc-49b4-ad83-403128657b82"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("4a245771-f443-4a92-8bb2-deb048473599") },
                    { new Guid("12cc4362-8da8-4135-a4d1-70d8267b3a48"), new Guid("a2886eb8-852a-47f0-b761-921d70b9d3d0"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("4ff9988b-8d64-413a-902f-b04c14710b30") },
                    { new Guid("155c6144-e37c-49b1-879f-08572890bf5f"), new Guid("a6c8d078-69a7-48c3-9b54-0a120f990662"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("2bc9534b-c854-4b54-b2ea-386a42447750") },
                    { new Guid("1bfc708e-6f7d-4a1d-a3a6-7609106c9be5"), new Guid("98a8f3c2-9aa1-4ae6-b053-a0a3267a96c6"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("e0edd8b6-a94e-48ca-b0ad-f68fdd80260c") },
                    { new Guid("1f8d1305-f037-4ab7-910e-596c72cb340d"), new Guid("01606516-fa32-46a7-b561-06a6f65f92b2"), "The Football Is Good For Training And Recreational Purposes", new Guid("ae2f87cd-8883-42dd-94c4-6c12b1515840") },
                    { new Guid("1fbbf324-4038-45ea-9e7a-b12fd588d6c1"), new Guid("344deb2d-d004-4398-b98f-03ac2c95831b"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("46bfe5e4-89e8-42b7-9b9e-2c8197e34f4f") },
                    { new Guid("27513822-e2b5-47cd-b89e-e7ad3ba9ec9f"), new Guid("17a33985-357c-4698-b820-484f1e70cfd7"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f") },
                    { new Guid("2cf94436-e83a-4c72-b357-edcd07df1ad3"), new Guid("8a5c0132-d369-423a-85f9-438acbc9a4f9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("500f60be-f942-4ad4-8109-2d28050bbfed") },
                    { new Guid("2ebebf57-8155-4cfe-8eac-79ec77f5162e"), new Guid("84ab81c0-33d3-4f02-87e1-6ddc3fcdf9a5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("4ff9988b-8d64-413a-902f-b04c14710b30") },
                    { new Guid("32e35b91-b9e0-4a87-b245-1fe5e07bcaf6"), new Guid("ee724103-5afe-4b4e-b4d1-d8839911930b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("b7e33c6c-1a5f-46ab-9e82-7cdfc74ac037") },
                    { new Guid("33de3a14-994e-47b7-a2f3-596716d2900e"), new Guid("759ccbda-1a53-4755-96a3-8cfdc2fd2380"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("c601d2b9-9a0d-4eef-af09-77f025fcbfe1") },
                    { new Guid("3457ca21-3b25-4370-9267-4643bb1e6379"), new Guid("f03faec8-4357-4479-a362-d51c61285db5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e") },
                    { new Guid("355c55b5-7a63-4468-be16-ab40051577b7"), new Guid("69d1df30-2daa-4985-b1fc-572c86baa7a3"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("568726fd-9699-4cd2-ad82-a09d68e35bfa") },
                    { new Guid("380eb32f-de6a-4e5d-9bed-3d7166590fac"), new Guid("d82c958a-0837-4e66-a4d3-08e2650de5f7"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("b35e2a5b-c070-45e3-9554-e42d66f9823d") },
                    { new Guid("3a4f03ac-d02e-4b50-aa5d-4dccf984798a"), new Guid("116c74c5-2362-47f9-a575-6a9c9d3bf2e5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("03fd0d33-6852-40f9-9529-53edfeb980eb") },
                    { new Guid("3afd80a6-2b85-4744-951d-84cf2cf98de9"), new Guid("1a2c4cf1-d146-462a-9c65-18557dfb88e2"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("8ec348e4-39d7-41f0-b130-26ea13df4cb5") },
                    { new Guid("3b95aed6-50ea-49b8-ab54-c84cecf60f29"), new Guid("ce6e1dc0-1efc-49b4-ad83-403128657b82"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1") },
                    { new Guid("3cb8ef58-a82d-4ca4-b256-90a89593c1df"), new Guid("6b8466dd-54d5-48fe-af16-1fa754cdd577"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("b16c1208-20a5-41b1-9a4b-4dc1adea2036") },
                    { new Guid("3e971b8b-2156-4ec7-8222-2299ee5b877d"), new Guid("aa27053a-da7f-4bff-a961-27497885bdce"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("052ce2b6-f4f9-45fc-a36b-fd871997cf47") },
                    { new Guid("3ed5d4f7-c91d-4a38-988f-780f26e2c022"), new Guid("cea1730d-813b-427c-90b5-b3e03e7b34a9"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("5d83ec35-d21e-4e1d-9d81-8e6a2052f162") },
                    { new Guid("3edfddc2-5045-4a82-b164-1564b1293dcf"), new Guid("d5040d0e-9864-420e-8a81-098040fc24ae"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("4ff9988b-8d64-413a-902f-b04c14710b30") },
                    { new Guid("4418e218-6b41-4545-80ae-32dcd5db98e3"), new Guid("a6c8d078-69a7-48c3-9b54-0a120f990662"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("5cde69d9-400d-465e-86ab-6476bad46875") },
                    { new Guid("47597535-7466-43e0-a9a2-c8b0ea859998"), new Guid("be2c4a7b-f639-45d7-ac48-1088a3078d5a"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("f44972c6-8fd5-49b4-8682-9fa87e1010fe") },
                    { new Guid("4c554212-9c88-48ba-b644-288090ac8dd0"), new Guid("3187855d-deea-4786-8ad8-fed8b6d03306"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("de545f40-b45f-432a-8aa9-b3832dd38122") },
                    { new Guid("522117eb-d7fc-4748-af95-8bcaeb872a05"), new Guid("6a4fcac1-5e26-4539-8573-fadc92d4419a"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("f65f4440-6f5f-4b63-9bf9-bfbb954e7f60") },
                    { new Guid("522433de-d283-49c3-ac38-785c2dee2a3c"), new Guid("01606516-fa32-46a7-b561-06a6f65f92b2"), "The Football Is Good For Training And Recreational Purposes", new Guid("7ad10cbc-6e7f-4c62-88d0-7844449ff012") },
                    { new Guid("548575ef-b532-4369-a9d4-d98fca5f72ce"), new Guid("373c10a4-7033-44a3-a7f1-53d29c301266"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("bfacd1cd-4524-4a7a-88d8-5ccfa95b9c43") },
                    { new Guid("54999c18-8496-45be-8bff-ac09446bad54"), new Guid("1087765e-6906-45f0-bb5b-6cb7b20b5bca"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("1f4720be-f37b-4941-ac7f-2785f1fa82e3") },
                    { new Guid("55d7853b-e470-4ee8-8749-187b3e9debf9"), new Guid("cea1730d-813b-427c-90b5-b3e03e7b34a9"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("ae2f87cd-8883-42dd-94c4-6c12b1515840") },
                    { new Guid("575a054d-9a36-45cc-ac92-9456750347ec"), new Guid("c91d6fe3-4a6a-45a9-a4bc-1e14f6788312"), "The Football Is Good For Training And Recreational Purposes", new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e") },
                    { new Guid("5bfefb98-0954-4615-8d9c-148b67b67c1a"), new Guid("6f47b2af-3ec7-4d33-9297-7c0dc0d8e48a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("0f4a9350-b921-4249-af70-22d73dffb2ba") },
                    { new Guid("5c0ddfe5-5b89-4228-a3f1-ac4f6ccaf5a9"), new Guid("69d1df30-2daa-4985-b1fc-572c86baa7a3"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("72003795-ec9a-4b02-98f5-ea1cc3e259e3") },
                    { new Guid("5c476589-b3b8-4f85-bd7f-b0ec1aba53d2"), new Guid("33613afd-3879-4eec-a940-0134de6556d1"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("cd9f6b17-67db-4a67-a837-addb6be95bfa") },
                    { new Guid("5c73638c-3449-4a27-a364-bfb8081c61a3"), new Guid("8a5c0132-d369-423a-85f9-438acbc9a4f9"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("2dcf78b0-b441-4445-a916-538bd1de8ee0") },
                    { new Guid("60f255fd-c754-4fcb-84ba-cc0816c4ce99"), new Guid("f03faec8-4357-4479-a362-d51c61285db5"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("b16c1208-20a5-41b1-9a4b-4dc1adea2036") },
                    { new Guid("611e020b-6e2c-457f-b71c-24dcb1752b93"), new Guid("07bb97cd-a5bb-4b92-ae2d-3d579e646cd6"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("7ad10cbc-6e7f-4c62-88d0-7844449ff012") },
                    { new Guid("639ca831-7fc2-41fd-aecc-152e99321fc5"), new Guid("51a8a7b9-b52c-491c-b275-0131e9608b21"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("5cde69d9-400d-465e-86ab-6476bad46875") },
                    { new Guid("704be42b-b5b7-425d-9a0c-d8f62b143320"), new Guid("84ab81c0-33d3-4f02-87e1-6ddc3fcdf9a5"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8") },
                    { new Guid("71953bbd-f7cd-4b95-b304-846e32c32ab5"), new Guid("cf3e2b89-c20c-434e-b1fb-17441009bea5"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("500f60be-f942-4ad4-8109-2d28050bbfed") },
                    { new Guid("74e4d85d-7ef5-4512-a14d-6883f46cf76d"), new Guid("397980a4-17c5-49e7-854d-908397640c8d"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("f44972c6-8fd5-49b4-8682-9fa87e1010fe") },
                    { new Guid("77bd2f6a-9d91-4458-a251-ca4bf739138e"), new Guid("d1e1a35a-6eea-4754-99cd-9a647fbd8f21"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("ae4df5c1-b4c5-4e29-bf37-62799c0923b1") },
                    { new Guid("79eac3fd-ba7a-47d7-a88b-c0b667875f8e"), new Guid("4cf7d799-3ddb-40cf-9926-3f424fa33e78"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("91ca4a95-aec9-4498-9f10-ad2825e2cdb5") },
                    { new Guid("7a3fa11a-b906-41c3-a8f2-a41e06407052"), new Guid("abe702d0-9fc5-4d0c-8bed-fc33ea76483f"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("0e94a252-bebc-4b90-a08c-71bd06bfe83a") },
                    { new Guid("7aab12d8-3ecf-4403-8aeb-0db913a94ee9"), new Guid("a0fc5659-b7f6-4377-a700-cb096a23ca11"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("925b1758-4588-4f53-a7d0-6f30808f8585") },
                    { new Guid("7be57a17-b619-4c0c-8d47-f833aa795ad7"), new Guid("18bfaa32-d8b4-4365-a901-bb8ba529a413"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("da25e087-14e2-4ede-84b1-6054195818b6") },
                    { new Guid("7c8d8807-8bee-4825-90fe-47292292522a"), new Guid("17a33985-357c-4698-b820-484f1e70cfd7"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("5d83ec35-d21e-4e1d-9d81-8e6a2052f162") },
                    { new Guid("7f41f47d-dc2b-437d-be95-e009e3405f62"), new Guid("abe702d0-9fc5-4d0c-8bed-fc33ea76483f"), "The Football Is Good For Training And Recreational Purposes", new Guid("56a5a710-0a47-42c3-ac66-54730524330d") },
                    { new Guid("802948e2-5448-462d-9ba4-b32ffd1f6e4e"), new Guid("5405c00e-657d-4835-a212-bbb4694fe48e"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("66e8ca49-e237-4521-99ab-e6845e9125b5") },
                    { new Guid("8581b22c-356c-4085-aea7-41cc0b150492"), new Guid("30c19ca0-6608-4b58-8f4b-30bdcd6f4d25"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("5d83ec35-d21e-4e1d-9d81-8e6a2052f162") },
                    { new Guid("86d24e32-bab0-4801-a533-e85815ea9b5a"), new Guid("6f47b2af-3ec7-4d33-9297-7c0dc0d8e48a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("cbd81ac2-af19-4668-a5fd-eeeabf4fe71b") },
                    { new Guid("8d7959ad-f24b-4238-b1e2-f88200206578"), new Guid("a2886eb8-852a-47f0-b761-921d70b9d3d0"), "The Football Is Good For Training And Recreational Purposes", new Guid("da25e087-14e2-4ede-84b1-6054195818b6") },
                    { new Guid("8fd5804e-831a-4fca-bd88-85284aef0cba"), new Guid("abe702d0-9fc5-4d0c-8bed-fc33ea76483f"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8") },
                    { new Guid("94b97ff0-23b7-4330-b3d9-67d302663e33"), new Guid("c208c68e-ca89-4ab5-b546-4a25ea6fae1b"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("99ac08d3-d873-4e45-aa85-df08f33a0db0") },
                    { new Guid("9616b6d9-17ea-4ab2-ab87-18c33805af45"), new Guid("59f0d7c8-2a80-4cd3-bcf3-039d8b3effa7"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("31010288-224c-4304-914d-6380bad1b4d7") },
                    { new Guid("98ec4d0f-5f72-40ac-a92c-af842c5e2593"), new Guid("54e25f24-5567-4613-882e-9c5f910737d1"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("568726fd-9699-4cd2-ad82-a09d68e35bfa") },
                    { new Guid("9bf237e2-9390-4ce1-b434-896806ca4973"), new Guid("c91d6fe3-4a6a-45a9-a4bc-1e14f6788312"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("d717e21d-2f19-41f7-b7c6-4d94bc2b6f95") },
                    { new Guid("9c274edc-7b8c-4ee3-973e-c7ea1aab500e"), new Guid("49648a9c-aa6a-468e-afd6-0342b3e5d79b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("f6e05e7d-51ff-465d-9b2d-29c3ff977562") },
                    { new Guid("9cc64ddc-ea09-476f-aa44-1c7d0f813e28"), new Guid("add0bcdc-3727-4c61-b8be-d63a9b2a3818"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", new Guid("0d424444-b16e-4095-a462-5e0df2b830b6") },
                    { new Guid("9d7feed2-cb9a-4dca-a355-2ed8cb4e86fe"), new Guid("d1b92413-9e4b-44bf-88de-a6917f689345"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("e0edd8b6-a94e-48ca-b0ad-f68fdd80260c") },
                    { new Guid("a367b4ef-f9ff-4380-927e-dec8bfe75bba"), new Guid("3c82604e-35c8-48cb-9cf5-3adf95688758"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("238fc4d2-7dae-46e8-a6a1-10348319d2c7") },
                    { new Guid("a652ec16-8967-4ba3-9f07-728581d8950d"), new Guid("2fb274aa-2957-4b67-9449-e7cd568f3348"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("c82e9144-ee18-48e3-bec5-feca8a654e40") },
                    { new Guid("af0c14b0-58c2-437e-bc75-d51fc1bb4cc4"), new Guid("085c9cd0-665b-4bbe-96a7-6f4ebfde37f5"), "The Football Is Good For Training And Recreational Purposes", new Guid("c601d2b9-9a0d-4eef-af09-77f025fcbfe1") },
                    { new Guid("b1846a28-aa89-4728-a48d-df844a0f50d7"), new Guid("6b8466dd-54d5-48fe-af16-1fa754cdd577"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("4566aa98-606b-45c2-809d-dc96adbc3f29") },
                    { new Guid("b240b4c3-f6f0-4b74-a7ea-01798561989e"), new Guid("b5084287-98ad-4aef-8260-45fa0d1ed221"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("8ec348e4-39d7-41f0-b130-26ea13df4cb5") },
                    { new Guid("bd43990f-5098-4350-9a58-9b1ccf4ae41b"), new Guid("904fc829-65d4-4499-a1d4-a03739435b61"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("dbf7a227-ad3c-41c6-a925-e1d99b3ebc92") },
                    { new Guid("be16ee13-eb5a-43a3-a542-342a1f5a3481"), new Guid("f718c74c-b662-4627-85bc-fa7d0e051bcc"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("2dcf78b0-b441-4445-a916-538bd1de8ee0") },
                    { new Guid("bf04fabd-7a13-4411-906e-eaf3755c31df"), new Guid("3eb4da70-d071-4a2b-b28a-ec81b5b5a7e9"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", new Guid("9590b338-faa6-497d-b86a-032436291832") },
                    { new Guid("bf65d04d-5608-4d20-8b8f-6961f25c1564"), new Guid("87762cf8-9b80-4283-a96e-44af311f4f36"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("0f3b1af9-cff3-4958-8d91-973db903e663") },
                    { new Guid("c767f10b-b69e-4a4a-8559-0fd08087038b"), new Guid("8f4f1164-56e2-48a7-b79b-268442935922"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("f6e05e7d-51ff-465d-9b2d-29c3ff977562") },
                    { new Guid("cd879833-34be-4c12-ba0e-b489da46e9f2"), new Guid("49648a9c-aa6a-468e-afd6-0342b3e5d79b"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", new Guid("f3c79597-d21d-4162-a023-aebae482889d") },
                    { new Guid("d0b386f6-9ce7-4a04-bf93-ffc4190e2f2b"), new Guid("81eb56c6-bcb0-4354-bf8a-47436f5a6893"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12") },
                    { new Guid("d27f3122-6bb6-49ff-b290-c467fceace84"), new Guid("443dc73f-e1e0-41a6-abe3-e30bf214f25f"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", new Guid("a8500346-4973-4a38-a803-5f544e093f75") },
                    { new Guid("d3b4b2f1-906c-4cdf-bd16-cf47aff33125"), new Guid("f7a00963-1a2f-4811-978b-876e3ac20a86"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("56a5a710-0a47-42c3-ac66-54730524330d") },
                    { new Guid("d3b57ba6-eb9c-4c64-b157-bb2116669a0f"), new Guid("c232ab4d-4964-4769-9761-8ef78c42020b"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1") },
                    { new Guid("d5638eac-301b-4d00-8a40-5c459ae334ec"), new Guid("0ed754ad-2c6a-4c74-9aac-1ab065f239f0"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("da25e087-14e2-4ede-84b1-6054195818b6") },
                    { new Guid("e06fb0e6-bfd4-4d01-a33d-036d79357215"), new Guid("cea1730d-813b-427c-90b5-b3e03e7b34a9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("7ad10cbc-6e7f-4c62-88d0-7844449ff012") },
                    { new Guid("e184b81f-32cc-4062-9ca5-dc484f824ffd"), new Guid("3c2b0e85-8ec4-4c44-a9fa-108915ff6e95"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", new Guid("29c110dd-5908-4da3-84ab-364d5d59a414") },
                    { new Guid("e2be4275-82fc-4f52-aea6-8d35dd28125e"), new Guid("30c19ca0-6608-4b58-8f4b-30bdcd6f4d25"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("cd9f6b17-67db-4a67-a837-addb6be95bfa") },
                    { new Guid("e51462d1-1a10-4ebf-8e72-500b4ce62208"), new Guid("182c27e0-53c2-441e-a462-3c1ec3bb848f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", new Guid("384bc094-7a1a-4388-8a4a-ed4f90363745") },
                    { new Guid("e57fcc93-54f0-4ff5-b05a-4e7e0b7c4980"), new Guid("01606516-fa32-46a7-b561-06a6f65f92b2"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8") },
                    { new Guid("eabe1219-121b-4e92-9c38-3fa305ea1944"), new Guid("87d3af4d-a14d-42fc-89ad-2af927fb7562"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", new Guid("66e8ca49-e237-4521-99ab-e6845e9125b5") },
                    { new Guid("ed83175b-71c2-4678-bfe3-b370948a5b7e"), new Guid("fe245078-fc6b-4d8b-b90c-1b443725c6bc"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e") },
                    { new Guid("eeb14daf-4d19-4ac3-9d0c-abfe114eb2eb"), new Guid("22f4ed27-c370-4152-a1cb-f006125f1022"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", new Guid("7c0abed5-11c6-4b13-b8d6-006e7e657532") },
                    { new Guid("f2849a10-8d83-4a67-b95c-de41e4a312c4"), new Guid("3c2b0e85-8ec4-4c44-a9fa-108915ff6e95"), "The Football Is Good For Training And Recreational Purposes", new Guid("e59bd4bf-bc3b-4cf4-a57c-1c74fd30350c") },
                    { new Guid("f6d3397f-7150-4714-bc09-b43152e9ec8a"), new Guid("6a94fd40-e06d-435d-88f3-f9fc40c18ae0"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("c29da83d-8034-4293-81ab-35d5750bf4bb") },
                    { new Guid("f77c760b-03c6-4655-b131-3efbffb1cea0"), new Guid("c232ab4d-4964-4769-9761-8ef78c42020b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8") },
                    { new Guid("f863feed-dde7-494e-87d7-f3007fcf2250"), new Guid("b20b5673-5236-471d-be3d-2e9e76f6503b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", new Guid("2bc9534b-c854-4b54-b2ea-386a42447750") },
                    { new Guid("fab1daab-d14b-472d-bbbe-5f1a21fde7ab"), new Guid("344deb2d-d004-4398-b98f-03ac2c95831b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f") },
                    { new Guid("fb6257ae-4507-4f64-9711-44c50b32c467"), new Guid("4f10a319-197d-4c9a-afe1-f01ae00771c9"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", new Guid("7249ea5c-ab2e-4f3f-a661-e78bcf0832b2") }
                });

            migrationBuilder.InsertData(
                table: "Ingredients-table",
                columns: new[] { "Id", "CountriesId", "DistributorsId", "Title" },
                values: new object[,]
                {
                    { new Guid("035682a6-0dcc-4331-b93a-20a68ffa09e1"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("f6a7bd26-f682-44dc-bf9a-bb7588f8e73e"), "Chair" },
                    { new Guid("0573d452-ad3f-4560-a570-943db74e05c8"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("655041ce-81e0-41c7-9986-3c5ce109b346"), "Bacon" },
                    { new Guid("06a0a4b1-6bd8-487b-9455-2124fc0fa42d"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("8f448b41-1d1d-426b-80a5-4976c14e8b9f"), "Sausages" },
                    { new Guid("0cf2573e-2ec9-4e9b-adf0-05a563be87ac"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("8a410c18-846d-4a7f-9ce0-4fc3ed092608"), "Table" },
                    { new Guid("10c0c660-e80e-4f78-8d01-5b2941ec348d"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("fba0ab8e-b1ff-409f-b0e9-cef18fc5c290"), "Keyboard" },
                    { new Guid("15598e0b-b21e-4976-bbe8-d29d1146bf6a"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("274cafc9-5fbc-4360-9f27-2d27a8036f5d"), "Cheese" },
                    { new Guid("1758b5f1-b9d0-40a5-bab8-fcf8ef7744ba"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("5f6c182f-c84e-4cf3-a22b-60b0cdc2567b"), "Towels" },
                    { new Guid("191765a5-6e5d-419d-9ac2-13951c1877a3"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("88e04095-f893-4fec-aea7-da1ba130ffa1"), "Chair" },
                    { new Guid("19572408-81c2-4c4f-949e-b3229b01ad69"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("befa0905-8419-4339-a5db-be1ab6ef8df4"), "Pizza" },
                    { new Guid("1980abbe-de67-47b4-9388-5124468bf770"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("d2ebbce2-9d37-4693-b5d2-1460bcf6c405"), "Tuna" },
                    { new Guid("19a49740-4c70-4146-b9a1-657a7659351c"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("44aea045-c624-4a88-8a4c-16bf9a1f3a4d"), "Computer" },
                    { new Guid("1d7e54dc-66bd-4825-a14d-1cd1e9b481a8"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("3d4bb385-e809-4f17-a98e-561ba9be9a59"), "Keyboard" },
                    { new Guid("1d9904ee-bfc8-4e00-a5e2-382f0accca10"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("16072186-e44c-4667-901d-7576ec5a2d09"), "Bacon" },
                    { new Guid("1df83556-926c-43c6-ae3c-ee6f9ac4c3b5"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("4d3e0d22-1a4b-47d9-8696-938e0352ffa6"), "Pants" },
                    { new Guid("25ffa090-a87a-4cff-817c-dd1f45d6ee93"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("d2ebbce2-9d37-4693-b5d2-1460bcf6c405"), "Hat" },
                    { new Guid("27b7b537-4a24-4d27-9396-582e9eabdede"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("8fa0db5e-a4e2-4372-b657-f7320d21fe1c"), "Car" },
                    { new Guid("2a4049be-81c4-4880-ba9a-a02b7a83e9ae"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("9bd828f7-a49c-46a5-87ee-65509e25c4e2"), "Sausages" },
                    { new Guid("2da7049a-5ff8-4340-88d8-9e7e4cfa22f4"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("13119bc1-131d-4f03-9512-4003df8ad638"), "Ball" },
                    { new Guid("2e48a9e0-52ca-4e3f-92fe-b934e0dff950"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("9e9c0e97-797b-4dcf-977a-dfb3e8c282fa"), "Ball" },
                    { new Guid("2f08c3ce-9027-47a9-a8c9-acb1022587e6"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("8f71efd7-49c2-4995-b2da-dadc35659897"), "Cheese" },
                    { new Guid("2f635021-a2a9-4aa8-bb43-9eb086d9220c"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("be862533-0dea-443a-9085-adc96203f798"), "Salad" },
                    { new Guid("37353970-be3a-4d04-a899-b2f0c38785be"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("d78d7e2f-d9f3-4067-86ab-782ac54591c4"), "Table" },
                    { new Guid("397a2e54-8e95-4482-81e4-f77ec229c573"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("44aea045-c624-4a88-8a4c-16bf9a1f3a4d"), "Cheese" },
                    { new Guid("406a7634-ed23-4648-b39e-0fd8fb84a4b4"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("3d4bb385-e809-4f17-a98e-561ba9be9a59"), "Pants" },
                    { new Guid("40bf1e2b-2f15-416d-8cbf-972ff2e37000"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("5f6c182f-c84e-4cf3-a22b-60b0cdc2567b"), "Ball" },
                    { new Guid("429ea034-a367-4840-80a3-2184932df7db"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("d2ebbce2-9d37-4693-b5d2-1460bcf6c405"), "Salad" },
                    { new Guid("4b70a0e5-fb60-4467-82e4-b7695341d9e7"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("655041ce-81e0-41c7-9986-3c5ce109b346"), "Salad" },
                    { new Guid("4d927529-1a47-4841-84ed-f99bdb13fc62"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("8f448b41-1d1d-426b-80a5-4976c14e8b9f"), "Keyboard" },
                    { new Guid("5325a35a-d28e-4933-a653-1b4b642adce6"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("befa0905-8419-4339-a5db-be1ab6ef8df4"), "Chair" },
                    { new Guid("53ecda36-7c77-4ecb-8e36-77b2b95c4ede"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("1cd06203-7731-415d-8373-fd185e2fb847"), "Salad" },
                    { new Guid("55e434b2-7e58-499c-865f-361bed170ad4"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("9ab5f718-7d39-43b2-bc67-885e64773645"), "Ball" },
                    { new Guid("56717064-ca25-488a-9dba-1dde380132d3"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("3d4bb385-e809-4f17-a98e-561ba9be9a59"), "Soap" },
                    { new Guid("56e44a81-a4c6-407f-895a-b72a7049e8ac"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("f6a7bd26-f682-44dc-bf9a-bb7588f8e73e"), "Hat" },
                    { new Guid("5705464e-3f97-4b2e-81c5-641e421059fd"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("37edb6e2-019c-452c-887b-7b7eff41fea6"), "Pants" },
                    { new Guid("591dcaeb-485a-45d2-8cfe-1162b19c08fa"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("274cafc9-5fbc-4360-9f27-2d27a8036f5d"), "Car" },
                    { new Guid("5b4eab27-2f73-485b-afc7-34103c8c4f0d"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("f6a7bd26-f682-44dc-bf9a-bb7588f8e73e"), "Computer" },
                    { new Guid("5f3a66c0-9111-4fe0-a6f3-d5b6f4ec53dc"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("c0f28aee-1ac3-4087-9372-4a4a6b30cdbd"), "Chair" },
                    { new Guid("670f4ff9-29c9-496c-b1e6-564538927c0e"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("1b79d868-9abd-49ed-a58c-20079af2882d"), "Cheese" },
                    { new Guid("6879eb45-11d3-48ac-8507-352d2121e5b5"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("1cd06203-7731-415d-8373-fd185e2fb847"), "Car" },
                    { new Guid("68b6dd9d-ce02-4b54-9a45-224a9f6ccb9f"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("8fa0db5e-a4e2-4372-b657-f7320d21fe1c"), "Fish" },
                    { new Guid("6b6036d0-c336-4751-a7bc-601732dd3ace"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("fcc68519-b992-41a4-92f6-7c8b2ebf519b"), "Keyboard" },
                    { new Guid("6d5074aa-cd26-426d-a070-5c6e1f8d932f"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("912f55ed-4196-40d0-8c18-93dedb0c6bdc"), "Pizza" },
                    { new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("88e04095-f893-4fec-aea7-da1ba130ffa1"), "Pizza" },
                    { new Guid("713667b9-1bc5-4777-b724-b671ce9545f5"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("3d4bb385-e809-4f17-a98e-561ba9be9a59"), "Pants" },
                    { new Guid("71ba9e3c-a266-41ad-b86f-7e8c4f6d38a3"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("30395bf4-c7fc-4eb3-b3e2-78024218939e"), "Chips" },
                    { new Guid("731ffd1f-cf9f-4259-b621-cd60a0cee24b"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("ab1c0568-769f-4735-ade7-6ced8f2320e1"), "Shirt" },
                    { new Guid("79f107c5-1cfd-42e0-aec2-efb1bb186d72"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("9ab5f718-7d39-43b2-bc67-885e64773645"), "Gloves" },
                    { new Guid("7c592de5-1db0-4646-9bbb-567089c076f2"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("357b8a3e-d7aa-4a32-970b-2077b47d378a"), "Mouse" },
                    { new Guid("7d0ef04a-276f-4ea4-8131-b9c8ba204e23"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("5d6db18a-423b-4fbf-a9db-1bb3c185b276"), "Fish" },
                    { new Guid("7e5f294c-b038-41a7-9d50-b1fc93c9b34c"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("6c28dccd-39fc-46b3-8a74-5e5852d89906"), "Pants" },
                    { new Guid("7f32b498-3e54-4cad-a0ff-591d88470d13"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("274cafc9-5fbc-4360-9f27-2d27a8036f5d"), "Fish" },
                    { new Guid("8092d9cf-232f-4f45-bf16-6a4bc7ec3222"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("a3738c1d-2606-42f9-adc3-1170db35949c"), "Soap" },
                    { new Guid("854e5f2b-2d7f-49ed-a7fc-204bebcbf737"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("9bc069ba-55f3-4f42-b4ec-4b8dfd14834b"), "Cheese" },
                    { new Guid("856f05c9-b30c-4c8b-8106-a7dbcbc1b5ad"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("be862533-0dea-443a-9085-adc96203f798"), "Ball" },
                    { new Guid("8742bff1-bade-4e36-8808-32fc11273a88"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("9bd828f7-a49c-46a5-87ee-65509e25c4e2"), "Hat" },
                    { new Guid("9223f2bd-68f1-45df-b2ab-72cde9d8831c"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("d78d7e2f-d9f3-4067-86ab-782ac54591c4"), "Soap" },
                    { new Guid("9310ad84-f875-48e0-bb88-b2230cf54eac"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("d2ebbce2-9d37-4693-b5d2-1460bcf6c405"), "Towels" },
                    { new Guid("93b3ea87-95d8-471b-8659-c181b688a47d"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("3b0cf59c-4e1b-41fc-b1aa-23efbe9b7a1c"), "Sausages" },
                    { new Guid("955f1f5c-aa26-4100-85d8-9c85ea0133bc"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("1b79d868-9abd-49ed-a58c-20079af2882d"), "Cheese" },
                    { new Guid("975b329e-45c3-4004-a049-490cd08199a2"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("16072186-e44c-4667-901d-7576ec5a2d09"), "Soap" },
                    { new Guid("9965e4ac-157e-43ef-8ac2-fa156c22e44f"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("be862533-0dea-443a-9085-adc96203f798"), "Shirt" },
                    { new Guid("9bcf1b9e-f005-4b15-867f-cf98cc05eef4"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("16072186-e44c-4667-901d-7576ec5a2d09"), "Gloves" },
                    { new Guid("9d522f5d-ce0f-471a-8cba-3fe0b13077f9"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("ac1e56a0-9c3b-4cbb-a2c1-b05dbb40ddf7"), "Gloves" },
                    { new Guid("a555bc0f-85c5-4ee3-b388-bfd5538a4e9b"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("13119bc1-131d-4f03-9512-4003df8ad638"), "Sausages" },
                    { new Guid("a9ec2377-8ff8-4289-8d3b-0641757dfb03"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("9ab5f718-7d39-43b2-bc67-885e64773645"), "Chair" },
                    { new Guid("aaaf96da-53c4-455d-ad1f-50a6fc8ba2e5"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("8f71efd7-49c2-4995-b2da-dadc35659897"), "Bike" },
                    { new Guid("ac4b2c6e-6e7f-4208-a3e4-08bec67157b2"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("7f4e5c63-8c3f-418d-9ddd-393e12c514bd"), "Towels" },
                    { new Guid("ac4e2ca8-0a2a-4716-b380-7d21c8d0c1c1"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("c79f1e95-7683-48aa-954b-9eae9eca0ab9"), "Car" },
                    { new Guid("b2647073-a963-436b-ba74-bfecda238ef9"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("be862533-0dea-443a-9085-adc96203f798"), "Pants" },
                    { new Guid("b87451b6-87b2-4b4e-a687-922a477d2688"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("f132e076-e52d-493c-ac2c-1f443eada908"), "Sausages" },
                    { new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("e485d3a9-db16-4da7-a7f3-2b760024bc92"), "Keyboard" },
                    { new Guid("b8f28185-1a1b-495d-a1ee-98d8aa575f48"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("391d302d-0521-48c3-a2d1-38c8f34ab56a"), "Chair" },
                    { new Guid("bbbffe12-c160-4e73-a05f-947d8c2a9126"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("16072186-e44c-4667-901d-7576ec5a2d09"), "Shoes" },
                    { new Guid("bc45d69e-9afa-420e-92fb-d358177ee9a7"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("d4aba8e2-50f4-4060-bb57-7de145d66883"), "Ball" },
                    { new Guid("c1d011b6-3dcd-46ff-8753-a91df742844e"), new Guid("e816c807-9c10-4487-85e3-5bc25dbe84d3"), new Guid("6e7e13a1-7d46-47c9-ab61-858b5b4ee889"), "Bacon" },
                    { new Guid("c2400c3d-971c-434e-9c6d-6d478f801fbc"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("1cd06203-7731-415d-8373-fd185e2fb847"), "Mouse" },
                    { new Guid("c333f336-9fe9-4e41-8772-6e710c9054e4"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("655041ce-81e0-41c7-9986-3c5ce109b346"), "Shoes" },
                    { new Guid("c37a7bd1-de55-46e6-bb94-d46523ef0be7"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("3b0cf59c-4e1b-41fc-b1aa-23efbe9b7a1c"), "Bacon" },
                    { new Guid("c4eab92a-1506-481a-a041-4ff0f6fbc5fe"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("1cd06203-7731-415d-8373-fd185e2fb847"), "Shoes" },
                    { new Guid("cb5b9bc7-5e86-447f-9ebc-9417f361e96f"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("8a410c18-846d-4a7f-9ce0-4fc3ed092608"), "Ball" },
                    { new Guid("cc05aa98-2949-440f-88f1-5b74f40db9c2"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("e3727897-7c0f-410f-b8da-3d1aba40ae41"), "Cheese" },
                    { new Guid("cc71fdd9-c538-41bd-9aa6-e42d31aa6569"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("16072186-e44c-4667-901d-7576ec5a2d09"), "Tuna" },
                    { new Guid("cca0e233-36ba-4d83-8173-f41e83dbddd7"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("9e9c0e97-797b-4dcf-977a-dfb3e8c282fa"), "Salad" },
                    { new Guid("ccd8816a-872d-4f3f-b4b5-2ef813c1e4bd"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("d78d7e2f-d9f3-4067-86ab-782ac54591c4"), "Salad" },
                    { new Guid("d0d5479f-16f2-4436-a712-7916957ad382"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("37edb6e2-019c-452c-887b-7b7eff41fea6"), "Shirt" },
                    { new Guid("d545a73b-b113-4e8d-94d1-ce5d71c29ce2"), new Guid("f9dd05f7-d5dd-418c-ae72-fd59d22f7777"), new Guid("5f6c182f-c84e-4cf3-a22b-60b0cdc2567b"), "Fish" },
                    { new Guid("d66a1e6d-9696-40f0-8992-50e3ef13065c"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("ac1e56a0-9c3b-4cbb-a2c1-b05dbb40ddf7"), "Gloves" },
                    { new Guid("d8387270-5685-4259-8f6e-931c4e044607"), new Guid("ca3a583a-bee7-443a-917c-2e77d9a5c061"), new Guid("8fa0db5e-a4e2-4372-b657-f7320d21fe1c"), "Car" },
                    { new Guid("d99c5bf2-f30e-4f61-bf96-1f5729123298"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("1b79d868-9abd-49ed-a58c-20079af2882d"), "Chips" },
                    { new Guid("e08fb3da-798b-4e05-acc7-87a1ba06088c"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("befa0905-8419-4339-a5db-be1ab6ef8df4"), "Computer" },
                    { new Guid("e255ae26-d072-4d6d-a32f-4fcdbea9c0f1"), new Guid("1c1a5321-8304-4863-aac2-761e6f6fe19d"), new Guid("88e04095-f893-4fec-aea7-da1ba130ffa1"), "Fish" },
                    { new Guid("e7f63bc3-41dc-42bd-9cc4-9976a2cddbf8"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("6e7e13a1-7d46-47c9-ab61-858b5b4ee889"), "Car" },
                    { new Guid("e9416994-0a57-4a54-a499-84eac735bea1"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("d4aba8e2-50f4-4060-bb57-7de145d66883"), "Ball" },
                    { new Guid("ecfeb743-ee84-4203-88d1-446408040849"), new Guid("340d3762-4079-46be-a77b-81dba01107b6"), new Guid("e485d3a9-db16-4da7-a7f3-2b760024bc92"), "Shoes" },
                    { new Guid("f0c9b2a6-ae8d-4e50-8c7d-6fcd2c735189"), new Guid("9b65837f-f455-4f36-8a88-a0aaf86f7ae5"), new Guid("8f448b41-1d1d-426b-80a5-4976c14e8b9f"), "Fish" },
                    { new Guid("f12f1dd7-3d69-45ea-8656-1750c5d5a4a0"), new Guid("c0c27883-1e6e-4758-ad6c-15acde0e4c3b"), new Guid("9bc069ba-55f3-4f42-b4ec-4b8dfd14834b"), "Hat" },
                    { new Guid("f4f6a022-7cf1-4380-9d37-00ef71bf27f1"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("6e7e13a1-7d46-47c9-ab61-858b5b4ee889"), "Table" },
                    { new Guid("f59ac6fd-8420-467b-86f1-c4f2b2c2c2c1"), new Guid("9c0d9393-30e4-48c1-a572-603d2032369e"), new Guid("befa0905-8419-4339-a5db-be1ab6ef8df4"), "Table" },
                    { new Guid("f6c04ca3-8007-4c8a-9cee-cddaa76d8912"), new Guid("6741a56f-2c6c-4174-869a-b081fba4b10b"), new Guid("5f6c182f-c84e-4cf3-a22b-60b0cdc2567b"), "Keyboard" },
                    { new Guid("f93623c2-5a9c-4136-b312-f140361d6165"), new Guid("49721270-21d3-4d26-8a36-a425e6c9a2f7"), new Guid("8817b259-3ee6-492f-9f9f-b5195582e103"), "Bike" }
                });

            migrationBuilder.InsertData(
                table: "IngredientsProducts-table",
                columns: new[] { "Id", "IngredientsId", "ProductsId" },
                values: new object[,]
                {
                    { new Guid("011e24f2-3058-439f-b4f7-70a5918cb381"), new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("5cde69d9-400d-465e-86ab-6476bad46875") },
                    { new Guid("025747d0-8287-4d45-b442-7e4841a4bbf3"), new Guid("aaaf96da-53c4-455d-ad1f-50a6fc8ba2e5"), new Guid("b18dce57-6361-43fd-af9c-c0353017140c") },
                    { new Guid("03b3c7c3-9e23-4ed6-9a48-8304b670e492"), new Guid("55e434b2-7e58-499c-865f-361bed170ad4"), new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12") },
                    { new Guid("04f5b332-7f20-4436-952a-efc8c6d97284"), new Guid("035682a6-0dcc-4331-b93a-20a68ffa09e1"), new Guid("cbaaed48-abad-449d-8cdf-cc2cf7098d3f") },
                    { new Guid("078f99d3-63c6-44d9-87b5-55b463c59fdb"), new Guid("429ea034-a367-4840-80a3-2184932df7db"), new Guid("f65f4440-6f5f-4b63-9bf9-bfbb954e7f60") },
                    { new Guid("09e7ed36-703c-4336-bceb-3d211d02f134"), new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("d717e21d-2f19-41f7-b7c6-4d94bc2b6f95") },
                    { new Guid("0a4ff2b7-19fe-4291-b2b1-6c067f518f9e"), new Guid("d0d5479f-16f2-4436-a712-7916957ad382"), new Guid("dbf7a227-ad3c-41c6-a925-e1d99b3ebc92") },
                    { new Guid("0b19eec1-dda5-496e-bc78-bf7c1436eeb0"), new Guid("ac4b2c6e-6e7f-4208-a3e4-08bec67157b2"), new Guid("2dcf78b0-b441-4445-a916-538bd1de8ee0") },
                    { new Guid("0bb24393-0049-41e2-9fad-94655421be65"), new Guid("71ba9e3c-a266-41ad-b86f-7e8c4f6d38a3"), new Guid("b7e33c6c-1a5f-46ab-9e82-7cdfc74ac037") },
                    { new Guid("0da687e9-2286-4f7f-8115-263fd4fdf186"), new Guid("035682a6-0dcc-4331-b93a-20a68ffa09e1"), new Guid("de545f40-b45f-432a-8aa9-b3832dd38122") },
                    { new Guid("0eb55b9e-b53a-4ca2-93e2-ee41f0bc132d"), new Guid("cb5b9bc7-5e86-447f-9ebc-9417f361e96f"), new Guid("99ac08d3-d873-4e45-aa85-df08f33a0db0") },
                    { new Guid("0ee0a950-1d00-4069-9541-b5f306fe5d33"), new Guid("a555bc0f-85c5-4ee3-b388-bfd5538a4e9b"), new Guid("7de88853-b8d3-44c2-9eb6-039c95d2e5a1") },
                    { new Guid("0efaa2e4-a037-4939-93ab-f2b640a6ea20"), new Guid("c1d011b6-3dcd-46ff-8753-a91df742844e"), new Guid("0f4a9350-b921-4249-af70-22d73dffb2ba") },
                    { new Guid("10d53100-7187-4054-8d4a-b67410e40ec1"), new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("cbaaed48-abad-449d-8cdf-cc2cf7098d3f") },
                    { new Guid("113abef4-b418-40b5-ba58-968f3e553304"), new Guid("f12f1dd7-3d69-45ea-8656-1750c5d5a4a0"), new Guid("e59bd4bf-bc3b-4cf4-a57c-1c74fd30350c") },
                    { new Guid("115a4361-118d-489c-974e-1afca5b62ea4"), new Guid("f6c04ca3-8007-4c8a-9cee-cddaa76d8912"), new Guid("9f11a0cc-f2d1-4aa3-9f25-a945122e053b") },
                    { new Guid("1b3a26b0-3bb4-49bd-bb9d-6b00072de41e"), new Guid("6d5074aa-cd26-426d-a070-5c6e1f8d932f"), new Guid("7c0abed5-11c6-4b13-b8d6-006e7e657532") },
                    { new Guid("201f66c2-8067-444c-8e3f-5fe2a2b85e94"), new Guid("5b4eab27-2f73-485b-afc7-34103c8c4f0d"), new Guid("4a245771-f443-4a92-8bb2-deb048473599") },
                    { new Guid("203307a2-28ba-46e2-8dbc-ca7a0b4038a7"), new Guid("19a49740-4c70-4146-b9a1-657a7659351c"), new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f") },
                    { new Guid("231adb08-0cc1-4a68-a724-6e04a581f796"), new Guid("55e434b2-7e58-499c-865f-361bed170ad4"), new Guid("fe79abf3-02a3-4a6b-8034-7f4b0886b10c") },
                    { new Guid("2325450a-c626-4cd9-ba9c-e7e506c635a9"), new Guid("19a49740-4c70-4146-b9a1-657a7659351c"), new Guid("e11404fa-ae62-452d-ad2d-bda60893e803") },
                    { new Guid("23efe030-4891-407b-9eb4-b09869cb7241"), new Guid("f59ac6fd-8420-467b-86f1-c4f2b2c2c2c1"), new Guid("925b1758-4588-4f53-a7d0-6f30808f8585") },
                    { new Guid("2a4311c6-2954-426f-b6b2-d8245300f927"), new Guid("f59ac6fd-8420-467b-86f1-c4f2b2c2c2c1"), new Guid("384bc094-7a1a-4388-8a4a-ed4f90363745") },
                    { new Guid("2b72c616-fd48-4a6c-a9e8-1541688f7e2b"), new Guid("a555bc0f-85c5-4ee3-b388-bfd5538a4e9b"), new Guid("de545f40-b45f-432a-8aa9-b3832dd38122") },
                    { new Guid("2c97a11e-d775-4966-8a67-92ca5a711033"), new Guid("429ea034-a367-4840-80a3-2184932df7db"), new Guid("f829e3a8-a969-4368-9891-785763f3bf67") },
                    { new Guid("30b768e2-efbf-4646-ad87-bc8d2b38ea80"), new Guid("b2647073-a963-436b-ba74-bfecda238ef9"), new Guid("1dcac742-c73a-469a-b8ea-7f16de87126e") },
                    { new Guid("35612296-def8-40b6-bf27-db025674945a"), new Guid("6d5074aa-cd26-426d-a070-5c6e1f8d932f"), new Guid("335ac5e5-0e96-409a-90a2-0b2bd42e0b31") },
                    { new Guid("381ff876-e48b-4b3f-9757-6b9b23c6a14d"), new Guid("d99c5bf2-f30e-4f61-bf96-1f5729123298"), new Guid("7de88853-b8d3-44c2-9eb6-039c95d2e5a1") },
                    { new Guid("3ac04c1e-aa6d-4f13-bafa-f516faab16a9"), new Guid("731ffd1f-cf9f-4259-b621-cd60a0cee24b"), new Guid("bb893e9f-024b-4b0d-8af3-8eb0aad9154f") },
                    { new Guid("3b3b1dea-7cd5-4f89-94ea-65c330e2935e"), new Guid("713667b9-1bc5-4777-b724-b671ce9545f5"), new Guid("7d4f838e-8531-4ffb-9951-5272da37f109") },
                    { new Guid("3d472569-5bfa-4e89-9d9e-20456788521b"), new Guid("10c0c660-e80e-4f78-8d01-5b2941ec348d"), new Guid("de545f40-b45f-432a-8aa9-b3832dd38122") },
                    { new Guid("3d95c322-742a-4b2b-8251-5fca6d806afb"), new Guid("7f32b498-3e54-4cad-a0ff-591d88470d13"), new Guid("e5764c37-03d5-4cb4-aaf8-c4458a0cbf55") },
                    { new Guid("3da2c62b-2d53-4261-8d9b-6441f57bf0d8"), new Guid("191765a5-6e5d-419d-9ac2-13951c1877a3"), new Guid("9590b338-faa6-497d-b86a-032436291832") },
                    { new Guid("3e649e7b-e80f-4765-9668-6849067982a3"), new Guid("56e44a81-a4c6-407f-895a-b72a7049e8ac"), new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e") },
                    { new Guid("3e774fbb-3384-4e55-bcd0-46cfce833247"), new Guid("9223f2bd-68f1-45df-b2ab-72cde9d8831c"), new Guid("5d61416b-363d-456a-9251-907fab5d8a14") },
                    { new Guid("41a628cc-d08e-4604-847a-584f5698c7b6"), new Guid("9965e4ac-157e-43ef-8ac2-fa156c22e44f"), new Guid("9590b338-faa6-497d-b86a-032436291832") },
                    { new Guid("44ac82aa-d0ba-44d5-8ed5-606ece7c9777"), new Guid("4b70a0e5-fb60-4467-82e4-b7695341d9e7"), new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8") },
                    { new Guid("466ecdba-3d44-4268-a8fc-96c8cc9294ea"), new Guid("b87451b6-87b2-4b4e-a687-922a477d2688"), new Guid("e59bd4bf-bc3b-4cf4-a57c-1c74fd30350c") },
                    { new Guid("472e7d7c-aecf-48c1-9659-1a875ae89990"), new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("c601d2b9-9a0d-4eef-af09-77f025fcbfe1") },
                    { new Guid("489009ed-53bc-4e31-aa96-77829a117d6a"), new Guid("429ea034-a367-4840-80a3-2184932df7db"), new Guid("e721335a-5a69-483c-abef-e6a8f7b327d3") },
                    { new Guid("48aaf975-b044-4b13-9b86-d08409ae222d"), new Guid("1df83556-926c-43c6-ae3c-ee6f9ac4c3b5"), new Guid("44bc5f98-1215-4619-8bb7-67c0793eb04a") },
                    { new Guid("5084894f-7835-4324-b245-f53859967db7"), new Guid("b2647073-a963-436b-ba74-bfecda238ef9"), new Guid("f44972c6-8fd5-49b4-8682-9fa87e1010fe") },
                    { new Guid("5119c26f-5e1d-47e1-8d56-81368a7506b0"), new Guid("b87451b6-87b2-4b4e-a687-922a477d2688"), new Guid("045969eb-e9bd-48c9-92a3-f0e50ca96e67") },
                    { new Guid("523edd63-5fa1-48e2-989a-59b5df882264"), new Guid("68b6dd9d-ce02-4b54-9a45-224a9f6ccb9f"), new Guid("cbd81ac2-af19-4668-a5fd-eeeabf4fe71b") },
                    { new Guid("53097637-8ee2-4d17-8634-bc8e326e119b"), new Guid("d545a73b-b113-4e8d-94d1-ce5d71c29ce2"), new Guid("b720a29d-da68-4da7-8fa4-751f879a186a") },
                    { new Guid("5406db09-c9e8-4c2a-9ed4-c7aed039e281"), new Guid("e7f63bc3-41dc-42bd-9cc4-9976a2cddbf8"), new Guid("0f3b1af9-cff3-4958-8d91-973db903e663") },
                    { new Guid("56f0a709-e278-4146-b95e-c3c0f03a55ff"), new Guid("5b4eab27-2f73-485b-afc7-34103c8c4f0d"), new Guid("9590b338-faa6-497d-b86a-032436291832") },
                    { new Guid("589aa02c-6c0f-45a9-921e-c14a18bb9e01"), new Guid("397a2e54-8e95-4482-81e4-f77ec229c573"), new Guid("f829e3a8-a969-4368-9891-785763f3bf67") },
                    { new Guid("59833ad6-5afd-4258-ae1e-18562dbc0df2"), new Guid("035682a6-0dcc-4331-b93a-20a68ffa09e1"), new Guid("052ce2b6-f4f9-45fc-a36b-fd871997cf47") },
                    { new Guid("5a3b875f-108f-4675-91d0-7c9edd8c5747"), new Guid("f59ac6fd-8420-467b-86f1-c4f2b2c2c2c1"), new Guid("b35e2a5b-c070-45e3-9554-e42d66f9823d") },
                    { new Guid("5b84e6fe-1d62-45f4-877e-90e4c0f67594"), new Guid("55e434b2-7e58-499c-865f-361bed170ad4"), new Guid("30253c1d-d45b-475e-9e4c-78d23f2fb8dc") },
                    { new Guid("5c890d25-e7ed-4362-a3ca-a3daa26c9a1e"), new Guid("9d522f5d-ce0f-471a-8cba-3fe0b13077f9"), new Guid("1dcac742-c73a-469a-b8ea-7f16de87126e") },
                    { new Guid("5e3b4dab-1251-4c83-abcf-ff066eea5402"), new Guid("27b7b537-4a24-4d27-9396-582e9eabdede"), new Guid("cbaaed48-abad-449d-8cdf-cc2cf7098d3f") },
                    { new Guid("5ec49f0b-46a8-49a1-8e2a-d6fc3cbd8c1c"), new Guid("56717064-ca25-488a-9dba-1dde380132d3"), new Guid("4ff9988b-8d64-413a-902f-b04c14710b30") },
                    { new Guid("6018dc83-24f7-4b9a-903a-fd576d727feb"), new Guid("8742bff1-bade-4e36-8808-32fc11273a88"), new Guid("4ff9988b-8d64-413a-902f-b04c14710b30") },
                    { new Guid("64138782-47d3-48f1-83b3-db74905c4204"), new Guid("d8387270-5685-4259-8f6e-931c4e044607"), new Guid("1641484a-2411-4e80-a25b-a8f82d4414e3") },
                    { new Guid("645f9357-83d6-49ef-ac7e-cd4fa9f1f137"), new Guid("4b70a0e5-fb60-4467-82e4-b7695341d9e7"), new Guid("d2bf338a-1bd2-41c8-b154-adc567aaebfa") },
                    { new Guid("64e75723-05d4-4d29-a797-743861d642ed"), new Guid("f4f6a022-7cf1-4380-9d37-00ef71bf27f1"), new Guid("925b1758-4588-4f53-a7d0-6f30808f8585") },
                    { new Guid("655c7137-8955-4e05-9d58-9289e1c33aa6"), new Guid("68b6dd9d-ce02-4b54-9a45-224a9f6ccb9f"), new Guid("e0edd8b6-a94e-48ca-b0ad-f68fdd80260c") },
                    { new Guid("6569ea8f-ae60-4831-be0c-f8ea3691d062"), new Guid("6b6036d0-c336-4751-a7bc-601732dd3ace"), new Guid("3ad91fe1-7c02-49a4-a908-7eba00a54c51") },
                    { new Guid("68a87363-5814-4f4d-92df-be776b641d40"), new Guid("27b7b537-4a24-4d27-9396-582e9eabdede"), new Guid("052ce2b6-f4f9-45fc-a36b-fd871997cf47") },
                    { new Guid("698ee203-f72d-48c8-be3a-d8ff0d0ce931"), new Guid("035682a6-0dcc-4331-b93a-20a68ffa09e1"), new Guid("7d2a2196-2c6e-4b0d-a190-fa766238b28c") },
                    { new Guid("6f4a3b7e-ecbf-4d86-aa6d-7a441cdfb121"), new Guid("713667b9-1bc5-4777-b724-b671ce9545f5"), new Guid("b35e2a5b-c070-45e3-9554-e42d66f9823d") },
                    { new Guid("70869ef6-e771-4039-8cfc-c65d44125e6f"), new Guid("b8f28185-1a1b-495d-a1ee-98d8aa575f48"), new Guid("238fc4d2-7dae-46e8-a6a1-10348319d2c7") },
                    { new Guid("71efdcc1-0627-411d-b064-3dac242a20f8"), new Guid("b2647073-a963-436b-ba74-bfecda238ef9"), new Guid("30253c1d-d45b-475e-9e4c-78d23f2fb8dc") },
                    { new Guid("7422d535-9b77-4fb5-9df9-691a213edde6"), new Guid("591dcaeb-485a-45d2-8cfe-1162b19c08fa"), new Guid("f3c79597-d21d-4162-a023-aebae482889d") },
                    { new Guid("77c985b9-01f3-4057-9f26-d95be8b229c6"), new Guid("e9416994-0a57-4a54-a499-84eac735bea1"), new Guid("500f60be-f942-4ad4-8109-2d28050bbfed") },
                    { new Guid("787a58b6-4001-41c1-97b6-8f7d180abb21"), new Guid("f59ac6fd-8420-467b-86f1-c4f2b2c2c2c1"), new Guid("e11404fa-ae62-452d-ad2d-bda60893e803") },
                    { new Guid("7c913521-ef7e-479b-8d76-876f44b8ea74"), new Guid("854e5f2b-2d7f-49ed-a7fc-204bebcbf737"), new Guid("d717e21d-2f19-41f7-b7c6-4d94bc2b6f95") },
                    { new Guid("7d6aa886-61af-4a9d-ae7d-5c8ec344fe9f"), new Guid("5705464e-3f97-4b2e-81c5-641e421059fd"), new Guid("b18dce57-6361-43fd-af9c-c0353017140c") },
                    { new Guid("7dd0a06b-d5fa-45f5-9a0b-cc381fe909f5"), new Guid("6b6036d0-c336-4751-a7bc-601732dd3ace"), new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1") },
                    { new Guid("882ed3f8-ecb5-4cda-8637-7c6a496aae52"), new Guid("ecfeb743-ee84-4203-88d1-446408040849"), new Guid("5cde69d9-400d-465e-86ab-6476bad46875") },
                    { new Guid("89edb9b8-a5f7-43d6-89d3-c6e77fab375f"), new Guid("5f3a66c0-9111-4fe0-a6f3-d5b6f4ec53dc"), new Guid("72003795-ec9a-4b02-98f5-ea1cc3e259e3") },
                    { new Guid("8af436f7-99c1-4140-bf12-9a74f8efcf18"), new Guid("79f107c5-1cfd-42e0-aec2-efb1bb186d72"), new Guid("fe79abf3-02a3-4a6b-8034-7f4b0886b10c") },
                    { new Guid("8cc94f03-e648-438f-b89e-5dd666cdb94a"), new Guid("d545a73b-b113-4e8d-94d1-ce5d71c29ce2"), new Guid("dbf7a227-ad3c-41c6-a925-e1d99b3ebc92") },
                    { new Guid("8cf022c7-7dcf-49ac-bf49-723c9c9dd4f1"), new Guid("56e44a81-a4c6-407f-895a-b72a7049e8ac"), new Guid("4ff9988b-8d64-413a-902f-b04c14710b30") },
                    { new Guid("8f72c289-ef13-4d8d-b8e4-89bd8e1769e0"), new Guid("93b3ea87-95d8-471b-8659-c181b688a47d"), new Guid("4a245771-f443-4a92-8bb2-deb048473599") },
                    { new Guid("8fb2102b-52e9-40b6-a368-ac6698d66b28"), new Guid("06a0a4b1-6bd8-487b-9455-2124fc0fa42d"), new Guid("5cde69d9-400d-465e-86ab-6476bad46875") },
                    { new Guid("911316e9-0952-4a44-9e8f-551f1572304a"), new Guid("5325a35a-d28e-4933-a653-1b4b642adce6"), new Guid("e5764c37-03d5-4cb4-aaf8-c4458a0cbf55") },
                    { new Guid("94cc263e-1218-43ad-a87e-54c4d2ad9910"), new Guid("9bcf1b9e-f005-4b15-867f-cf98cc05eef4"), new Guid("7ad10cbc-6e7f-4c62-88d0-7844449ff012") },
                    { new Guid("959b5573-82fa-4195-8e29-4f717c7b212c"), new Guid("25ffa090-a87a-4cff-817c-dd1f45d6ee93"), new Guid("e11404fa-ae62-452d-ad2d-bda60893e803") },
                    { new Guid("98424df2-a140-44b2-a25d-efbec814d74e"), new Guid("e7f63bc3-41dc-42bd-9cc4-9976a2cddbf8"), new Guid("0e94a252-bebc-4b90-a08c-71bd06bfe83a") },
                    { new Guid("9bca6e61-eaea-4231-b1cb-c533c235fa28"), new Guid("9bcf1b9e-f005-4b15-867f-cf98cc05eef4"), new Guid("7c0abed5-11c6-4b13-b8d6-006e7e657532") },
                    { new Guid("9c0d62cd-8694-4edb-ae96-4405dd4df113"), new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("0b217f79-749b-4bed-b984-eae29e896ab6") },
                    { new Guid("9e6e450a-0044-4126-9416-dadceb1b9654"), new Guid("6879eb45-11d3-48ac-8507-352d2121e5b5"), new Guid("766ad8b9-124f-47bf-81b4-183b60a7c21e") },
                    { new Guid("a2c6a6ff-5613-4ade-b35e-2a866697e24b"), new Guid("56717064-ca25-488a-9dba-1dde380132d3"), new Guid("c29da83d-8034-4293-81ab-35d5750bf4bb") },
                    { new Guid("a60a383b-0c9d-4a25-95b4-817f3c304cb6"), new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("2bc9534b-c854-4b54-b2ea-386a42447750") },
                    { new Guid("a71c3ad8-8ff9-44ca-9ade-e9a8b87c4afd"), new Guid("b8f28185-1a1b-495d-a1ee-98d8aa575f48"), new Guid("7dd3612b-1beb-453f-bbd4-4c9922bfe55c") },
                    { new Guid("a8bce10a-94b4-481f-967e-96560adea24f"), new Guid("a555bc0f-85c5-4ee3-b388-bfd5538a4e9b"), new Guid("e0edd8b6-a94e-48ca-b0ad-f68fdd80260c") },
                    { new Guid("a9c2052b-8f70-48a4-a1b7-2911ed331895"), new Guid("5705464e-3f97-4b2e-81c5-641e421059fd"), new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12") },
                    { new Guid("aa2d7f75-b468-42f8-b6fe-9d45bb811b10"), new Guid("f12f1dd7-3d69-45ea-8656-1750c5d5a4a0"), new Guid("44bc5f98-1215-4619-8bb7-67c0793eb04a") },
                    { new Guid("ae3765dd-2c6b-49d9-b4d0-4a738ff596d8"), new Guid("cc71fdd9-c538-41bd-9aa6-e42d31aa6569"), new Guid("4aac426e-97f0-4edf-8c5b-d9af506c8beb") },
                    { new Guid("ae3d48e1-26a9-4edd-bbab-40c751cd0a52"), new Guid("7e5f294c-b038-41a7-9d50-b1fc93c9b34c"), new Guid("03fd0d33-6852-40f9-9529-53edfeb980eb") },
                    { new Guid("b1e1f7d2-994e-4dec-8962-95022ac027aa"), new Guid("9310ad84-f875-48e0-bb88-b2230cf54eac"), new Guid("0e94a252-bebc-4b90-a08c-71bd06bfe83a") },
                    { new Guid("b1e62464-1f4c-4608-9a91-86f3d15814ea"), new Guid("5325a35a-d28e-4933-a653-1b4b642adce6"), new Guid("8d5476fc-d7a5-4f03-af2f-daa8b5b33188") },
                    { new Guid("b520bad0-483a-4291-a896-d579abcc1292"), new Guid("cca0e233-36ba-4d83-8173-f41e83dbddd7"), new Guid("56a5a710-0a47-42c3-ac66-54730524330d") },
                    { new Guid("b66c35fb-295f-4a24-9b5f-5c50f4cc4a3c"), new Guid("ac4b2c6e-6e7f-4208-a3e4-08bec67157b2"), new Guid("de545f40-b45f-432a-8aa9-b3832dd38122") },
                    { new Guid("b8b1d4f8-d8e7-44fe-ab80-d6224d9159b3"), new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("b720a29d-da68-4da7-8fa4-751f879a186a") },
                    { new Guid("bd12a949-ca14-4bf0-8977-99cd05b8ac6e"), new Guid("19a49740-4c70-4146-b9a1-657a7659351c"), new Guid("568726fd-9699-4cd2-ad82-a09d68e35bfa") },
                    { new Guid("be0962a1-3dc5-457b-92cd-cc92eef2d3bb"), new Guid("429ea034-a367-4840-80a3-2184932df7db"), new Guid("5d61416b-363d-456a-9251-907fab5d8a14") },
                    { new Guid("bf046f6e-bb7a-471a-a8f2-fd19b8f8d3fc"), new Guid("8742bff1-bade-4e36-8808-32fc11273a88"), new Guid("da25e087-14e2-4ede-84b1-6054195818b6") },
                    { new Guid("c03daeac-333a-4538-a1e5-7997e4830eda"), new Guid("d0d5479f-16f2-4436-a712-7916957ad382"), new Guid("7c0abed5-11c6-4b13-b8d6-006e7e657532") },
                    { new Guid("c0ab37e0-fbdf-4290-b951-dcc23d15e2ab"), new Guid("71ba9e3c-a266-41ad-b86f-7e8c4f6d38a3"), new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1") },
                    { new Guid("c352e9d7-21ab-410e-9680-ce78fbbfb320"), new Guid("9bcf1b9e-f005-4b15-867f-cf98cc05eef4"), new Guid("1bfdf0b1-cf83-4442-9f59-8f398227ea3d") },
                    { new Guid("c445ce73-5fe5-452f-a681-9c02cfcdd92c"), new Guid("856f05c9-b30c-4c8b-8106-a7dbcbc1b5ad"), new Guid("bb893e9f-024b-4b0d-8af3-8eb0aad9154f") },
                    { new Guid("c52a5cc3-c567-4242-bc90-a4e7e970c1f1"), new Guid("15598e0b-b21e-4976-bbe8-d29d1146bf6a"), new Guid("f3c79597-d21d-4162-a023-aebae482889d") },
                    { new Guid("c59f429d-2d83-4f7f-9511-d18d1fb53e95"), new Guid("5325a35a-d28e-4933-a653-1b4b642adce6"), new Guid("ae2f87cd-8883-42dd-94c4-6c12b1515840") },
                    { new Guid("c6ad1f11-bc50-439a-beff-59f43629fb38"), new Guid("4b70a0e5-fb60-4467-82e4-b7695341d9e7"), new Guid("5cde69d9-400d-465e-86ab-6476bad46875") },
                    { new Guid("c82717a3-881c-483a-98d9-44f695053395"), new Guid("a9ec2377-8ff8-4289-8d3b-0641757dfb03"), new Guid("c29da83d-8034-4293-81ab-35d5750bf4bb") },
                    { new Guid("c82aa705-6918-4803-a5d7-310b5be0a54c"), new Guid("c333f336-9fe9-4e41-8772-6e710c9054e4"), new Guid("0f3b1af9-cff3-4958-8d91-973db903e663") },
                    { new Guid("c844d53d-8146-4bc0-ab62-6978837ed480"), new Guid("ac4b2c6e-6e7f-4208-a3e4-08bec67157b2"), new Guid("da25e087-14e2-4ede-84b1-6054195818b6") },
                    { new Guid("ca67107b-295d-4464-8348-0daf92ffbbe1"), new Guid("7f32b498-3e54-4cad-a0ff-591d88470d13"), new Guid("2bc9534b-c854-4b54-b2ea-386a42447750") },
                    { new Guid("cdd8ca45-cbe7-42f7-b518-ca7e26f9e655"), new Guid("7d0ef04a-276f-4ea4-8131-b9c8ba204e23"), new Guid("72003795-ec9a-4b02-98f5-ea1cc3e259e3") },
                    { new Guid("ce83d41a-b085-494c-b5cf-c93225033b19"), new Guid("bbbffe12-c160-4e73-a05f-947d8c2a9126"), new Guid("b85dcf7d-9c65-47f0-9be1-62e0b1853b12") },
                    { new Guid("cf22217b-e2c0-42b3-bf43-d381da260c4a"), new Guid("e9416994-0a57-4a54-a499-84eac735bea1"), new Guid("9f11a0cc-f2d1-4aa3-9f25-a945122e053b") },
                    { new Guid("d2db96d5-49d9-485b-891f-557ac41b7c99"), new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("0f4a9350-b921-4249-af70-22d73dffb2ba") },
                    { new Guid("d588b3ba-5cd9-463b-8bb4-faadc9cb89d5"), new Guid("10c0c660-e80e-4f78-8d01-5b2941ec348d"), new Guid("fe79abf3-02a3-4a6b-8034-7f4b0886b10c") },
                    { new Guid("d6c6a2ad-624d-4c88-aaaa-02be330972d8"), new Guid("6879eb45-11d3-48ac-8507-352d2121e5b5"), new Guid("0d424444-b16e-4095-a462-5e0df2b830b6") },
                    { new Guid("d6f37c6a-f6d4-40dc-b355-0c4725b6c599"), new Guid("f6c04ca3-8007-4c8a-9cee-cddaa76d8912"), new Guid("75111d6d-06c0-4a4e-8c98-fc483eabef98") },
                    { new Guid("d87310ff-4106-4052-bc75-40c473e0494d"), new Guid("9d522f5d-ce0f-471a-8cba-3fe0b13077f9"), new Guid("c29da83d-8034-4293-81ab-35d5750bf4bb") },
                    { new Guid("d95ec1a9-c6d5-49f7-952d-bafe2286eda7"), new Guid("2da7049a-5ff8-4340-88d8-9e7e4cfa22f4"), new Guid("568726fd-9699-4cd2-ad82-a09d68e35bfa") },
                    { new Guid("da1f4bfd-3771-4a64-8485-c2148582e5d5"), new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("5fb21ed7-d4b7-45d5-9ecd-7ee6177537fe") },
                    { new Guid("dcb090b6-e188-4c97-b76f-c9fa8e96cc02"), new Guid("670f4ff9-29c9-496c-b1e6-564538927c0e"), new Guid("b7e33c6c-1a5f-46ab-9e82-7cdfc74ac037") },
                    { new Guid("dda66805-6081-4f22-8c7f-f7452db20b22"), new Guid("79f107c5-1cfd-42e0-aec2-efb1bb186d72"), new Guid("7d4f838e-8531-4ffb-9951-5272da37f109") },
                    { new Guid("de021198-2931-4726-9891-ad179efe0440"), new Guid("a555bc0f-85c5-4ee3-b388-bfd5538a4e9b"), new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f") },
                    { new Guid("df66a8f9-6957-41d3-b9bd-0d14d9f301b2"), new Guid("6f4d0913-7191-4c03-a8f7-11dc301021fb"), new Guid("56a5a710-0a47-42c3-ac66-54730524330d") },
                    { new Guid("e0884e60-0677-4602-a6b3-6d36a28fc3f2"), new Guid("406a7634-ed23-4648-b39e-0fd8fb84a4b4"), new Guid("d717e21d-2f19-41f7-b7c6-4d94bc2b6f95") },
                    { new Guid("e0cdbba3-e4a5-40a0-9e4d-226aa7ceec2f"), new Guid("731ffd1f-cf9f-4259-b621-cd60a0cee24b"), new Guid("03fd0d33-6852-40f9-9529-53edfeb980eb") },
                    { new Guid("e1890ad1-5411-4611-b326-e85c9c21fbf6"), new Guid("d66a1e6d-9696-40f0-8992-50e3ef13065c"), new Guid("5d61416b-363d-456a-9251-907fab5d8a14") },
                    { new Guid("e18c6cfe-eba5-44b4-9ab7-418e85d8e15d"), new Guid("40bf1e2b-2f15-416d-8cbf-972ff2e37000"), new Guid("045969eb-e9bd-48c9-92a3-f0e50ca96e67") },
                    { new Guid("e27fdeea-a46a-4302-a83a-de373a79a8cf"), new Guid("cca0e233-36ba-4d83-8173-f41e83dbddd7"), new Guid("283a9319-1c2a-4220-b31b-62f5b79aec26") },
                    { new Guid("e2987795-efab-469c-a965-27e2009e9b9a"), new Guid("191765a5-6e5d-419d-9ac2-13951c1877a3"), new Guid("fe79abf3-02a3-4a6b-8034-7f4b0886b10c") },
                    { new Guid("e6358d22-db2f-435b-9b33-36a81d6befa0"), new Guid("7f32b498-3e54-4cad-a0ff-591d88470d13"), new Guid("8baf567e-b6c0-4ee3-8deb-4c879eb7a1b8") },
                    { new Guid("e74914e1-2cc3-41e5-8ad0-2a3053f11acd"), new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("da25e087-14e2-4ede-84b1-6054195818b6") },
                    { new Guid("e787e06d-dd56-45bc-b259-39787a21779d"), new Guid("cc71fdd9-c538-41bd-9aa6-e42d31aa6569"), new Guid("7de88853-b8d3-44c2-9eb6-039c95d2e5a1") },
                    { new Guid("e7e5c36f-ef17-497a-9d27-01cc07bd5a74"), new Guid("191765a5-6e5d-419d-9ac2-13951c1877a3"), new Guid("62cb8aae-a816-4489-b096-f2eb402caaf1") },
                    { new Guid("e99c673d-08d3-43df-b127-643c819841c8"), new Guid("e08fb3da-798b-4e05-acc7-87a1ba06088c"), new Guid("1641484a-2411-4e80-a25b-a8f82d4414e3") },
                    { new Guid("ea239104-9815-4ee2-8850-4e1b2a0d64fc"), new Guid("6b6036d0-c336-4751-a7bc-601732dd3ace"), new Guid("dbf7a227-ad3c-41c6-a925-e1d99b3ebc92") },
                    { new Guid("eae5559a-8558-42b4-8c52-8ae76eb133c5"), new Guid("e255ae26-d072-4d6d-a32f-4fcdbea9c0f1"), new Guid("925b1758-4588-4f53-a7d0-6f30808f8585") },
                    { new Guid("eb21fa3d-eb02-427d-ae6b-6b218482a815"), new Guid("cca0e233-36ba-4d83-8173-f41e83dbddd7"), new Guid("d6f9b017-4069-4e9d-9f70-7f2bbcf400a9") },
                    { new Guid("ebddd949-5585-4d53-9b27-df82d6ae4e4b"), new Guid("ac4b2c6e-6e7f-4208-a3e4-08bec67157b2"), new Guid("a8500346-4973-4a38-a803-5f544e093f75") },
                    { new Guid("f0b6683d-aaa0-4199-92da-4d0f0c08946b"), new Guid("975b329e-45c3-4004-a049-490cd08199a2"), new Guid("2bc9534b-c854-4b54-b2ea-386a42447750") },
                    { new Guid("f5d59eb8-39bf-431b-8b94-3a2c9ae035ac"), new Guid("d545a73b-b113-4e8d-94d1-ce5d71c29ce2"), new Guid("0f3b1af9-cff3-4958-8d91-973db903e663") },
                    { new Guid("f60765e0-ea59-4b59-9454-db080a7c22cd"), new Guid("406a7634-ed23-4648-b39e-0fd8fb84a4b4"), new Guid("5d61416b-363d-456a-9251-907fab5d8a14") },
                    { new Guid("f8c9a304-ca98-460f-ba12-7414b7bcd54f"), new Guid("b88e09e7-4ec4-481a-a173-a013000d3e69"), new Guid("397e4333-672a-4908-ae48-5bfbbe70da30") },
                    { new Guid("f94fbed3-718b-415f-9008-250f081f2308"), new Guid("1d9904ee-bfc8-4e00-a5e2-382f0accca10"), new Guid("925b1758-4588-4f53-a7d0-6f30808f8585") },
                    { new Guid("fa435b9c-23ab-486d-b956-6a8e98549490"), new Guid("406a7634-ed23-4648-b39e-0fd8fb84a4b4"), new Guid("335ac5e5-0e96-409a-90a2-0b2bd42e0b31") },
                    { new Guid("facd9efa-b434-4fb1-ae64-68e8c64e03e7"), new Guid("b2647073-a963-436b-ba74-bfecda238ef9"), new Guid("4566aa98-606b-45c2-809d-dc96adbc3f29") },
                    { new Guid("fdba5093-f9ae-428c-bb0a-e202cb695f4f"), new Guid("1d7e54dc-66bd-4825-a14d-1cd1e9b481a8"), new Guid("045969eb-e9bd-48c9-92a3-f0e50ca96e67") },
                    { new Guid("fdfaad4a-d454-494d-a4f5-49e6150cd0d5"), new Guid("68b6dd9d-ce02-4b54-9a45-224a9f6ccb9f"), new Guid("5fb21ed7-d4b7-45d5-9ecd-7ee6177537fe") }
                });
        }
    }
}
