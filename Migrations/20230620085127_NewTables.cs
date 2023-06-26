using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BakeryManagementSystemAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Countries-table_Title",
                table: "Countries-table");

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("00766fd5-acaf-4d1c-be63-694ea6e55145"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("01354a06-c53c-4ab6-acb9-83b8f22b54f3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("02408cce-7e0b-428f-b9ab-d33103530ab8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("029c10cb-73bf-4089-8d30-e68652e18ce1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("02cfa5c6-3344-4158-a55d-a55728df8a2c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0301d73b-9f32-4083-8b75-0245f8f8c4b1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("03be8daf-00d4-4e74-ab49-8af0bed65fd4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("03e0d975-6646-4366-a2dd-7fbfe4ac302c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("06202539-0cd8-4cbe-aac3-07575b775869"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0c80f4a4-4bba-46f5-b512-1ac2adf254c4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0ec28871-83d4-49b9-a246-8fc1b7e2889c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("0ef098a2-42e9-4e33-bdd9-cf01bc5de532"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("15a7bfa1-e774-4467-8d48-9ba8185e99b1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("15e0b801-53c8-4ba9-b739-7d8c4df7b9fd"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("17923408-9491-4558-b411-fc72028c66b8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("180584e0-78fe-42be-b69e-489e983cc6c6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1a4a0361-5d37-4efc-8e42-41990555b848"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1a801d99-e1d2-4fe2-b837-58660bbb5efe"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1c01661e-8d0c-465f-905d-f415785bb45e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1c5b33b7-63f8-465f-8d5d-aefa4a7dff83"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1c8362ac-1014-467a-abc0-0341ae920ff0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1dcee12d-5fc9-4bcb-9529-2b98d87fb32d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1f9dced8-14b9-41bb-814e-1005ad1b7976"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("20817512-61d2-477c-bf0c-6e4993091dfd"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("217771bb-49b3-4237-8fba-f053922f8657"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("22d5cea6-f58e-4efa-a39f-3dc331f4e92a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2381b359-5bb3-4c64-ba36-589e1920f84a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("23cd36c0-b7d7-4085-bdf6-7ff15b172443"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("23fd637c-0498-43a8-8577-30256067a25e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("279de27e-6bfd-499e-a204-267eb870948c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2928fb17-0d7b-45eb-9b6d-6ccdcd9cff03"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2a66488e-c654-4b7c-a649-7fdf7faff515"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2c89fc76-c742-4bd4-8d95-59474ecac2f8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("2e90e9ef-a1d0-471b-adb7-bb5b969f5d42"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("30b5aeb3-542c-4198-9c8f-a5349d99f6a4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("31ec5904-6fa2-4cef-b65d-7df1d7f682b3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("323a34c5-fab2-4cdb-99f1-61a423584103"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("33abaf9f-3cbb-452f-9d3a-2f5fa8210ca9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("33b8ec3b-489a-488d-a603-ee7ee7d380fe"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3878c0cb-f287-4c1d-ab63-5bd29a52a8a6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("38e29a08-ccee-4d44-85ee-f08e8e91ca9f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3915c2dd-e70d-4e04-af3f-40e41810655b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("39b91aac-c25b-46a2-9eee-943eb3044879"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("419b14c5-b740-4f3c-9f62-2e45fae39657"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4238437e-e1b5-48e7-afc0-843da2bd3b78"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("42ea06a6-1bd3-4804-8090-21c60e177918"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("43c45693-448a-45dc-bfb1-b7ccaaf0f301"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4536b0bf-0cc0-45f3-9ce8-136324b46cfe"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("477a2cc2-f382-4ce5-8c84-d1ba69af5a2f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("488fbc58-bef9-4cca-8480-9b6217314fd1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("495a6e52-8079-4e58-94bd-bea2ae4efeb4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("49c78022-db4f-4997-b264-4446c54f1c7a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4a6be79c-1556-4117-a5fd-c1119aa97287"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4cb3164e-9e2d-41f7-ae66-dfabf8155f26"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("4ee33b3c-112b-4949-9f12-d9f1b2239835"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5071aeaf-6bb9-4b89-93d2-13321867d0d3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5460aa98-a8bf-4ce8-a24e-128e66a645a8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5762993e-ade8-4dd2-bf9d-d2f7520bb5b3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5a3d9b79-514e-4b0a-b26a-98b588b193c1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("5af6ef04-c3df-445a-a142-f9ee642e18a7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6104d358-f50b-4480-909b-fef3369d69ae"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6356bee1-437b-47d1-905d-86c8e27521b5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("642aa5a0-6910-4d93-9e3d-0aed72375be8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("66a70151-bed4-42ae-a59d-aa56dfb65ee2"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6b3e222e-8242-40bc-bc1c-fe2dc8318a1b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6d095460-9cab-461f-b389-7f8195b6f22d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6d690bbe-6ad8-4314-b6bd-3ee5088ed8a4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6ded9bd2-e8ac-4ae2-ac8e-6794816b85dc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("6f230800-de0f-4a77-a9ba-cb2cdd5cbee7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("736a6554-ed48-4651-9327-e792751883e9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("741c557c-c4e7-4cd0-844d-d43c7a7aa9cf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("76471559-cdd1-4c21-a817-21b0383b85e5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7c8ccd2d-dba5-4bae-af1d-7cc654b96211"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7e7b06a7-587e-4f2a-9b4c-0d9a513df6ca"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7e86f95c-4ac7-47d4-a459-9c0b7e26d97e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("7eb3850a-e85b-4e46-ae0f-7edde6856308"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("82fec5ec-67d4-4557-a977-c25d8f354c93"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8666cba7-58a3-4d8d-a8f2-d061b863604e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("87ad2176-038b-4db9-ac43-339d41537700"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("87c8d0d0-9fad-4aae-b284-da752c7ade1d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("89437952-348c-4f70-8f5c-123fe077fe18"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a0fc9ac-7abd-49ed-b9da-b9efd53e8d0f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a252b4d-3638-420e-aebe-9467e8f5883b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a5dd9fe-e7c6-42ec-8da1-5a3566197af1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a706266-ad41-4630-87c0-412a9d9c2e0f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a870aba-3606-4277-830c-ce24c0c46ac4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8af3a2f6-935a-4955-8913-5b5829a486ab"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8d3974da-1de1-4c54-b167-e85e7ee4069f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8dbf1c4a-e04c-422f-b595-1cc0eed8f927"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8e74f977-7e5d-4e2a-ac42-79f1df5d36dc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8fd80892-bfe0-4a39-9a7b-19388722db3e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("90c1888c-4b6e-479f-bf99-7b748748901e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("91f485ac-3956-46a2-bac5-701140f09a2b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("95732f6e-b1ea-4423-b039-76eea9d65229"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("95d91de4-49a7-4054-a0ff-6c6357496180"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("96d03091-f349-444b-8bc2-82346c1fdb17"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("97b5f8d2-7847-494c-ba48-7c5578a1958c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("988f5984-bdc5-4df7-96bc-3181ef1f8138"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9a0afdcf-e28f-44d3-b018-18d4dcd47332"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9de5d6d6-d6ea-407b-9aef-a89e320b372b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9fe2afa2-9acf-4404-bd38-3322d37fb7f2"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9fff0836-d806-4725-b0f3-714df9467b64"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a22a866b-3773-4944-a68c-1c53e00bf09d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a2a00955-7998-4218-b057-8d529f1b8146"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a3dc9797-8f2d-4216-bb85-4997f27628a6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a4645c96-6993-41a8-99f9-73d7060f40db"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a7826410-9933-46db-9f75-1759c24df647"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a87b5aed-2f7a-489f-9617-37998cfd83ef"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a917974e-575c-4dcd-934e-56ad5e7a50d3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("aafe087c-2d3d-4875-9868-5d4643368886"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ac0de5a6-a293-421f-a5cc-8a5c0809897d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("acb498ca-c8ab-43fc-9264-e26b12dbf6e8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ad0bfea3-0164-4e19-8119-b50aeaf67302"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b36ea917-6e43-49e7-afa5-0c9735dd29a3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b37e76ac-90a5-455b-b472-ceb6bbffdc5c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b7db1dd9-3963-43fb-ae12-2bced4443fde"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b866e89f-7694-43f0-bf3f-f2162fb287bb"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bae1838e-6b3a-4e65-bc7a-446a06578ce6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bc3ddbe0-0cd9-4bc0-a38a-bcb1b7fafc25"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bc8694cd-cf70-4157-8851-7c576948fd44"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bd2d744c-46e9-4d6b-87fb-594fe6ed757f"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("be3372bc-dee7-4d54-abfc-4bf33e874b04"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bfcb80e7-1a11-4688-9b65-469a332f9ff4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c88fa2d4-9b42-41d6-9975-448f27eadcd5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c963cc25-f665-4a19-a3f7-a9fd84c331b3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c973630e-79de-4ce6-bca8-fe705a36ce8e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c97e838d-8210-4215-b102-af4f893ab1cc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("c99aaa0e-9826-4b7a-a0b6-b0969c9395f3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ca742b5d-9cde-4203-8d6d-d136264e0865"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("cb003111-9a21-4a04-8f2b-7c73586af2cd"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ce7b5142-984b-442e-bd9f-0ae8788a7a08"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d5527260-b891-451d-a87b-1674a0589f35"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d5a438bd-d6cc-461d-9163-9d2cd2f8c5e5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d8e7c987-6934-4a8f-a428-f90db0e804cf"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("da7cdcbc-a36d-4031-b378-7cb2fd7c5d85"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("daa9f3f8-50e0-41ff-bc9a-1df85091d996"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("dbe6c0a6-0527-48fb-9847-6e6d6c6b9cf8"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("df4620a6-bbc5-4fe7-9239-35a7b8250f13"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("dfaacd7d-debf-42f3-aa55-42a2ae2408aa"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e4642183-0375-4871-9a73-c2ef6b1d50b7"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e753d7ed-81f2-43a7-b0a5-acfc390b37ce"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("e8d62e84-8ce7-4dda-a2a9-4e2f6a984363"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("eb55be35-7452-4a04-b6f0-6683f4589b29"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ed343fa7-a1c9-40ff-bbdb-1fc08a9653a9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ee920c98-3f59-4042-b701-ab504f7efdc6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f2e90a63-c92c-4952-b823-8cd71cec3d2d"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f3ea97e0-110a-4b0b-a0be-a622983211a3"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f61a5c41-c274-472e-bfa8-0a2abdcfacb1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fc45dbea-36fa-495f-8606-23b17ab1e7d0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fd16122e-d10a-4ab3-895d-9d683538a17d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("00523128-40e3-435e-ad43-70be69689dc3"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("1e2010f4-26d3-47d4-8c58-52202e3978e3"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("210ed0a7-31c3-4bc2-984c-4ad9e88832ff"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("218604f7-4739-47e8-8a25-d852b87fb718"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("2285bbc9-ca78-4107-af0c-2f5c2c92f39b"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("23892fe0-010d-4637-834e-206bbd081e27"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("29bc03ed-979b-4022-bb4a-8cca17bdcc34"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("310701a9-bdd1-44d4-bbe9-762b3cf2b248"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("35a83c61-b044-4e42-b1b0-d65fe7b23d56"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("36db4aef-06fa-44b6-b1d1-843826d460e8"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3f3c3ee8-61c1-46d6-9e70-007c79c51271"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("4afc189d-20d6-40b7-934d-f1c845648efc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("4ce4542a-2ee4-4832-821d-bc43538c648e"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("4dff1775-70bf-4986-8c17-5b3c33941349"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("4ed7bf43-96a2-48f8-8ae3-b28a4b5befb5"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("519b157c-8f9c-4bb6-800f-97414aa01d14"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("5843dbfa-978d-489c-b53b-293481b431ae"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("5a688e44-02a0-4856-8fff-d75f2a262593"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("606dff51-79b3-4d2c-8242-d873eaddf28a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("61adac8d-ba51-48a8-97bd-b1011776520a"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("620aa7cd-0e9c-4614-87b4-c60551a29c76"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("70694336-a703-4eb6-aa49-3f76d154a172"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("71f4dc3b-419d-4c2a-910d-e377fe005084"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("73ebd261-d2d4-4a8a-8e39-6d065d97a137"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("7e2804fc-8cc0-4bf8-8336-634352efdfe2"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("7e955e55-78b1-484f-b0eb-51d2c2425ca6"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("83a9a7fd-ce28-42db-893d-bd0b9350fdd9"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("84c87106-521a-4178-9e6b-5c49bd8bb946"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("87d6652d-6f9e-492e-99ec-2e7e8721299e"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8955d4a7-dc06-4c9c-8bc0-59368c0a04e0"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8a89db25-9122-420e-b921-7c4ebfe2d12f"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("8ff64eaa-bd00-4ee1-8471-54242a8d3429"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("923fd550-1b86-426b-9314-10eb5be90177"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("9259fbab-2b76-4a49-858c-4e4e031c9093"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("999a66fb-60b6-40bc-a5a3-b37441bfb789"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("9b58e0e9-5c6d-4930-9644-c39dfa3e0a32"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a4ed2ec3-45e5-4de1-8f1c-d3ccc229fb3f"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a9915dfd-6461-40c5-8b07-117055e19eb7"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("affe19f0-a5a4-4408-851b-6c3fe633e96d"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("b3429152-8d58-4321-bae5-f07f1d585973"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("b7e88a7b-27c8-4528-8a97-2d44eee83446"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("b84a0387-291b-47df-b27d-d77cf8039999"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("c5d4d71f-2352-4165-8458-a8ac8f6811df"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("cae173d9-9301-49af-b01a-0e98afd4bd93"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("cc1e1edd-5576-4f81-b7e7-893e49962abc"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("d6a31f2b-45f0-46ef-8379-9e3750dc0be7"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("e8547a7c-9360-43bd-9b28-a498f0acb496"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("ee618093-84f0-4355-964f-f95f6f95ed1f"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("fccd7c1c-74ce-4a20-b620-3f1f3d766f2c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("fdd7e026-301f-4866-a105-f5f41c73a4c6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("006778ee-b6c6-4a22-93d8-cc4c72df8926"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("00ddae5f-d375-451f-8e00-cbbecc242503"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("01bb525e-8b72-4d1f-a901-30a9c71dbb1c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0604ba22-a59e-49c2-a750-caec171d2377"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("06096154-7b1d-4c0d-9882-3ccbeb959918"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0622fb55-c096-4eab-9623-9a4740e27112"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("06609414-353b-4243-9b25-1a7f993f2972"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("06a2c046-96bc-4957-9215-999827cb7e09"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0778643c-c0ea-4428-aa95-f284081db81c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("089a4b3a-3d36-4fb4-a0be-89221f9c5fa2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("09b1610b-c9a0-48ee-bfb1-7673efa0c195"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0a14e1b5-919e-4981-85b0-2935a38a3b60"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0a575a7e-25c3-4d8e-8e80-fcfacf4c544e"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0d4c13d5-0159-4446-9ebc-3083fbeb8e35"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0e7fdb49-a06f-474f-99a2-b55149ec1286"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1139e5b1-bbb0-4ba6-98b0-dbd2bdb39771"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("122ae907-67a8-4ef8-8b3b-81d5e2900d7d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1243b994-1981-4632-9155-29479d3249e9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1463fdfe-30bb-4e69-bb12-2dfbfd1c95f9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("199930b8-74b8-4cf5-8faa-56671ed5d327"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("1d68ae53-385b-4f0d-b194-2c3cac52d2f6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("27339381-10b5-44b4-962a-1e5497b1cd7f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("29816c87-3bd3-475d-b037-e20de02f4341"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2ecd5e84-12c1-42ef-9e73-492f548524bc"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2edcf109-c736-4203-bbe5-b7a24f4c76f5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("2f0038a1-f111-4dc1-8342-6897a17a103c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("35fad48d-7871-4232-b80f-0222b72303b6"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("36c82abe-61be-4b68-beee-45c6b3f0dc3b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("3971f835-7ea7-40b0-8680-bbbc1b48fee4"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("3aad9893-027d-4823-8e8e-776fdfac26ee"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("40077f83-6f6f-4c54-ba9d-f8c37f245379"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("45f6e16b-8b95-4bb7-a973-462d24722416"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("4712a86b-1af5-4957-b860-cf26f3e397bb"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("47b90623-4516-4eda-b735-ae09eb897626"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("49eafd91-023a-4fba-af3f-39c06e1eb99c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("505a9cec-0b74-4001-bd43-589989c72bc0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("52a259c9-bcff-4679-9f6e-0f897ecabd89"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("581578ef-0b67-4289-8431-6e90aeb19022"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("59a56b29-4069-4841-a2d8-de8ab54ce947"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5c562e12-96f2-4ed6-a1b0-50f4ee97700a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5d6ed57a-e645-42ad-a557-7537f3664d07"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5dcd77e7-01f8-442a-ba42-7eee733b8d37"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5e95b224-e991-4042-97d2-28f4621d6d1f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5f5431de-d798-4dd6-af4e-db1cee42c3e5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5f771e80-9f23-4616-a2ce-f8d32012c56d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("5f910945-94c6-4ef1-b9cc-d794f72c6179"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("640a4c17-bf7b-4a64-a17c-cde8b6e3ae66"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("66dfb9c9-7a55-4d85-8665-c567009a33b2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6876e602-b75b-4126-a3c8-4eb68517fd33"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6ba4ce43-1037-4cae-829e-fbb06c72d4a0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6e5728e1-9b14-43d5-9192-b54d4f4a86f9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6f2a4d81-793d-4f84-8557-5a67b5399e20"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("6f92fe26-4db3-4e69-9587-7b390b985f80"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("70e87bf4-280f-429b-b84a-d49d59c7d156"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("719737bb-cf55-4409-baa7-595b8861fe69"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("730b6bc4-3b23-448b-b14c-451915afde7b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("77ec89b4-90c1-45b3-ab75-ce8d434b1d30"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("7927facb-3434-427f-880a-35a943d8a7ce"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("80c30b34-7412-4fbc-bf9d-0c3331495757"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8242b3a4-089c-4e96-b91a-5fe804cb6fc5"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("826b179c-ca4c-4f31-90a1-fce30d5af639"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("84a21d42-59d4-4ffd-87ca-ea5e4c6b3bae"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("8706ba2d-e067-48f9-a656-2a6a1271689a"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("87a92ed3-28ce-4c27-8ee8-6d31f5f8770b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("91452de0-7d9d-47ab-8e5c-50670bb48851"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("97cad5d5-96d1-4a60-8fde-01e342644e6f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("9fb19bff-3cec-4d1a-8bec-17ee154a32bd"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a054c7c8-b060-4b3c-a28e-4ab5b2a940c3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a1a92d48-9896-448b-a4ad-aa23edb405b4"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a6c96148-5ef1-4732-81d4-48126ecd2eca"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a6e00a50-492f-48da-9a7e-1d22b5ebd1a2"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("a928b174-d04e-4d40-b918-317e180c7a10"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b0752ced-8817-48c3-a220-f2b8c5d3a54b"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b0e6dd53-63e1-4045-9e15-ec8ce1b90cd9"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b40941dc-28f9-4b1c-b56d-bc5534c7ab7c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b4770c02-99a3-4a5a-b670-ba70f470eed3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b4804c36-1426-4cfd-90c2-bc0d3d3f8dfc"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b532e3f2-5c17-47a6-bd30-4e4b9b37bbfc"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("b7095135-72b6-4dd3-9f9d-c56e9536d5ad"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bb8b4fe4-194f-4619-ac48-668127b1ab91"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bda50be2-daa4-4bbf-af2a-fd8241a6ab5c"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("be03c8af-94cc-4555-b447-3ea199e8ac07"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("be1e13e4-c290-4bcc-ac6d-053588d166bf"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("bf3ef748-812a-4a54-a353-89df49369b36"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c2f3d53e-4ea5-455e-946e-bb3dc8377a38"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c385577a-2cba-4e60-afbc-80ab99a56c75"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("c6cca50b-f596-4233-9c8f-3d5ce7cdd158"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("cb51fc78-4c23-4b8a-a6f6-14b984ffa372"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d1b9d3b5-4378-4c0c-831d-edb21455fd17"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d63b3e06-eb86-4656-b1d2-4964653aa0b4"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("d7e4f64f-82f1-4edf-98dd-fea878778361"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("dec59db5-606f-4d7a-bc88-0488b1674d8d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("e9bbaf94-a887-45fe-97b1-e6eea63580e7"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("ed1aa020-ef8e-483d-8e33-ac87aa8c9437"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f2a724fa-6aab-4f96-b8d3-25d3ac33ebe3"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f40a6387-2e73-4c2e-98c9-4267edf7b9a0"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("f73609a3-f5a8-4f10-a431-64ea570972ac"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fc355f22-f110-4643-a030-3c5bfe48fe8d"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fcb4cb45-c29c-4da6-afc4-54c09c9c4257"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("fe5afa42-35f7-4190-a7f6-55dc8c56a8ee"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("15c71f15-626d-4f49-938e-72759216f866"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("3c52d94b-0068-4af7-8024-ac337169933b"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"));

            migrationBuilder.DeleteData(
                table: "Countries-table",
                keyColumn: "Id",
                keyValue: new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"));

            migrationBuilder.CreateTable(
                name: "Feedbacks-table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks-table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedbacks-table_Customers-table_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customers-table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedbacks-table_Products-table_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products-table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients-table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountriesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistributorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients-table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ingredients-table_Countries-table_CountriesId",
                        column: x => x.CountriesId,
                        principalTable: "Countries-table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ingredients-table_Distributors-table_DistributorsId",
                        column: x => x.DistributorsId,
                        principalTable: "Distributors-table",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IngredientsProducts-table",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IngredientsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IngredientsProducts-table", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IngredientsProducts-table_Ingredients-table_IngredientsId",
                        column: x => x.IngredientsId,
                        principalTable: "Ingredients-table",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IngredientsProducts-table_Products-table_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products-table",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks-table_CustomersId",
                table: "Feedbacks-table",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks-table_ProductsId",
                table: "Feedbacks-table",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients-table_CountriesId",
                table: "Ingredients-table",
                column: "CountriesId");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients-table_DistributorsId",
                table: "Ingredients-table",
                column: "DistributorsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsProducts-table_IngredientsId",
                table: "IngredientsProducts-table",
                column: "IngredientsId");

            migrationBuilder.CreateIndex(
                name: "IX_IngredientsProducts-table_ProductsId",
                table: "IngredientsProducts-table",
                column: "ProductsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks-table");

            migrationBuilder.DropTable(
                name: "IngredientsProducts-table");

            migrationBuilder.DropTable(
                name: "Ingredients-table");

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
                keyValue: new Guid("01606516-fa32-46a7-b561-06a6f65f92b2"));

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
                keyValue: new Guid("07bb97cd-a5bb-4b92-ae2d-3d579e646cd6"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("085c9cd0-665b-4bbe-96a7-6f4ebfde37f5"));

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
                keyValue: new Guid("0ed754ad-2c6a-4c74-9aac-1ab065f239f0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1087765e-6906-45f0-bb5b-6cb7b20b5bca"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("1146f334-1956-4be4-a5b7-542b911b68a1"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("116c74c5-2362-47f9-a575-6a9c9d3bf2e5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("147fef06-4efe-4ae3-bd0a-0fc232d81dd9"));

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
                keyValue: new Guid("22f4ed27-c370-4152-a1cb-f006125f1022"));

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
                keyValue: new Guid("2fb274aa-2957-4b67-9449-e7cd568f3348"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("30c19ca0-6608-4b58-8f4b-30bdcd6f4d25"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("31786c5a-c79d-4037-b8b8-c318a7a50819"));

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
                keyValue: new Guid("35d49030-52ea-4d94-95b0-45dbbb3a67f9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("3651b3be-cb8a-4cd5-89c6-825da693769c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("373c10a4-7033-44a3-a7f1-53d29c301266"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("387c0c53-ea3a-4724-8a0f-543895fcdeb3"));

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
                keyValue: new Guid("427ca2b9-ed72-4f63-8df5-44653308fea8"));

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
                keyValue: new Guid("4cb71a8b-c2fa-44eb-8855-44751f563056"));

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
                keyValue: new Guid("52bade64-2d79-4967-a666-3a425d2c6a97"));

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
                keyValue: new Guid("564a24fa-a42d-4993-9d69-c3b01a183be9"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("59f0d7c8-2a80-4cd3-bcf3-039d8b3effa7"));

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
                keyValue: new Guid("81eb56c6-bcb0-4354-bf8a-47436f5a6893"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("82275817-cbf1-4b38-a37e-332a6a7ef772"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("84ab81c0-33d3-4f02-87e1-6ddc3fcdf9a5"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("858612bd-20f4-4c42-a88a-ab4f705f31a8"));

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
                keyValue: new Guid("891c63f0-c0e9-44f6-96ed-01c8494aa27b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("8a5c0132-d369-423a-85f9-438acbc9a4f9"));

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
                keyValue: new Guid("8f4f1164-56e2-48a7-b79b-268442935922"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("904fc829-65d4-4499-a1d4-a03739435b61"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("914e2a87-e2d9-4de9-aa9c-14b032c12b83"));

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
                keyValue: new Guid("9d1d01a4-b396-47c1-aa13-be2deddee168"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("9e409e88-4831-4244-9081-f8863f49966e"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a0fc5659-b7f6-4377-a700-cb096a23ca11"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a1f48068-ee56-4305-9f7c-7d59cb68e829"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a2886eb8-852a-47f0-b761-921d70b9d3d0"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a60f234d-2079-416c-9fcd-2ce1f8447116"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("a6c8d078-69a7-48c3-9b54-0a120f990662"));

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
                keyValue: new Guid("aed732b1-e34a-4a03-ac59-d09e09d061ad"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b20b5673-5236-471d-be3d-2e9e76f6503b"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b40b123e-bea6-4d84-ae9d-2e2a8b595d08"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("b5084287-98ad-4aef-8260-45fa0d1ed221"));

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
                keyValue: new Guid("be2c4a7b-f639-45d7-ac48-1088a3078d5a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("bed3ff7d-8a6c-4ae4-9931-ffa71c59c60e"));

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
                keyValue: new Guid("c62df072-9f4a-43e5-bfe2-99f1f77605ea"));

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
                keyValue: new Guid("cf73ad9a-73e6-4bb8-b1ee-7cad4d10655c"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("d13cff65-0fce-4f3b-b3e6-6147ef5870e3"));

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
                keyValue: new Guid("d6a3012c-3fb2-409a-a0d2-9d5e6bd6ce38"));

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
                keyValue: new Guid("e82ebe83-bb4b-471d-b59e-a179ba0da57a"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("eb90abef-1747-443c-82d1-2e2403b229a4"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("ee724103-5afe-4b4e-b4d1-d8839911930b"));

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
                keyValue: new Guid("f03faec8-4357-4479-a362-d51c61285db5"));

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
                keyValue: new Guid("f718c74c-b662-4627-85bc-fa7d0e051bcc"));

            migrationBuilder.DeleteData(
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("f7a00963-1a2f-4811-978b-876e3ac20a86"));

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
                table: "Customers-table",
                keyColumn: "Id",
                keyValue: new Guid("fe245078-fc6b-4d8b-b90c-1b443725c6bc"));

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
                keyValue: new Guid("21b368d8-5d81-4187-8db4-ae9d757fe0f0"));

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
                keyValue: new Guid("357b8a3e-d7aa-4a32-970b-2077b47d378a"));

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
                keyValue: new Guid("3b92affc-555d-4d61-9816-9d941a0fc283"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("3c17b418-53c4-458e-9a05-acbbd6a30b1b"));

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
                keyValue: new Guid("8817b259-3ee6-492f-9f9f-b5195582e103"));

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
                keyValue: new Guid("a3738c1d-2606-42f9-adc3-1170db35949c"));

            migrationBuilder.DeleteData(
                table: "Distributors-table",
                keyColumn: "Id",
                keyValue: new Guid("a59122a9-b48c-47f3-b154-94762edcad63"));

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
                keyValue: new Guid("c79f1e95-7683-48aa-954b-9eae9eca0ab9"));

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
                keyValue: new Guid("e3727897-7c0f-410f-b8da-3d1aba40ae41"));

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
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("0008cfeb-7cac-4d22-b89a-e8234926b91f"));

            migrationBuilder.DeleteData(
                table: "Products-table",
                keyColumn: "Id",
                keyValue: new Guid("035f593d-eb78-4a43-a406-422e51fe284f"));

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
                keyValue: new Guid("17c89867-ed3a-40bd-aff0-8bc6085b0ee3"));

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
                keyValue: new Guid("36cf0e6a-a3f7-4284-9470-049c95e1a625"));

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
                keyValue: new Guid("a09a513b-cf49-41aa-843f-318aedab497a"));

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
                keyValue: new Guid("b58906ae-aca7-4e79-9bfa-8b9fad43e555"));

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
                keyValue: new Guid("c0b3b1fa-4d7b-456b-a923-7ade7f99326f"));

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
                keyValue: new Guid("e4b1dab0-0c3c-444d-b314-7f6f53d68516"));

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
                    { new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Russian Federation" },
                    { new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Saint Kitts and Nevis" },
                    { new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Dominica" },
                    { new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Heard Island and McDonald Islands" },
                    { new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Slovakia (Slovak Republic)" },
                    { new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Uganda" },
                    { new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Bahamas" },
                    { new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Papua New Guinea" },
                    { new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Indonesia" },
                    { new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Cyprus" }
                });

            migrationBuilder.InsertData(
                table: "Products-table",
                columns: new[] { "Id", "Description", "Price", "Recipe", "Title" },
                values: new object[,]
                {
                    { new Guid("006778ee-b6c6-4a22-93d8-cc4c72df8926"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 392.53m, "Concrete", "Salad" },
                    { new Guid("00ddae5f-d375-451f-8e00-cbbecc242503"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 726.35m, "Granite", "Car" },
                    { new Guid("01bb525e-8b72-4d1f-a901-30a9c71dbb1c"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 875.87m, "Wooden", "Pants" },
                    { new Guid("0604ba22-a59e-49c2-a750-caec171d2377"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 295.34m, "Concrete", "Gloves" },
                    { new Guid("06096154-7b1d-4c0d-9882-3ccbeb959918"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 774.42m, "Frozen", "Chicken" },
                    { new Guid("0622fb55-c096-4eab-9623-9a4740e27112"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 966.72m, "Granite", "Ball" },
                    { new Guid("06609414-353b-4243-9b25-1a7f993f2972"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 932.20m, "Fresh", "Ball" },
                    { new Guid("06a2c046-96bc-4957-9215-999827cb7e09"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 895.45m, "Granite", "Chips" },
                    { new Guid("0778643c-c0ea-4428-aa95-f284081db81c"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 280.84m, "Soft", "Gloves" },
                    { new Guid("089a4b3a-3d36-4fb4-a0be-89221f9c5fa2"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 464.99m, "Soft", "Bacon" },
                    { new Guid("09b1610b-c9a0-48ee-bfb1-7673efa0c195"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 473.07m, "Plastic", "Keyboard" },
                    { new Guid("0a14e1b5-919e-4981-85b0-2935a38a3b60"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 645.54m, "Soft", "Salad" },
                    { new Guid("0a575a7e-25c3-4d8e-8e80-fcfacf4c544e"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 810.87m, "Metal", "Chips" },
                    { new Guid("0d4c13d5-0159-4446-9ebc-3083fbeb8e35"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 333.14m, "Rubber", "Cheese" },
                    { new Guid("0e7fdb49-a06f-474f-99a2-b55149ec1286"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 288.29m, "Fresh", "Tuna" },
                    { new Guid("1139e5b1-bbb0-4ba6-98b0-dbd2bdb39771"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 341.41m, "Granite", "Computer" },
                    { new Guid("122ae907-67a8-4ef8-8b3b-81d5e2900d7d"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 180.77m, "Wooden", "Shoes" },
                    { new Guid("1243b994-1981-4632-9155-29479d3249e9"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 293.35m, "Granite", "Keyboard" },
                    { new Guid("1463fdfe-30bb-4e69-bb12-2dfbfd1c95f9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 655.87m, "Steel", "Chicken" },
                    { new Guid("199930b8-74b8-4cf5-8faa-56671ed5d327"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 604.27m, "Plastic", "Pants" },
                    { new Guid("1d68ae53-385b-4f0d-b194-2c3cac52d2f6"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 246.10m, "Metal", "Gloves" },
                    { new Guid("27339381-10b5-44b4-962a-1e5497b1cd7f"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 35.01m, "Steel", "Chicken" },
                    { new Guid("29816c87-3bd3-475d-b037-e20de02f4341"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 809.69m, "Plastic", "Keyboard" },
                    { new Guid("2ecd5e84-12c1-42ef-9e73-492f548524bc"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 321.33m, "Plastic", "Towels" },
                    { new Guid("2edcf109-c736-4203-bbe5-b7a24f4c76f5"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 780.85m, "Plastic", "Soap" },
                    { new Guid("2f0038a1-f111-4dc1-8342-6897a17a103c"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 530.29m, "Cotton", "Pizza" },
                    { new Guid("35fad48d-7871-4232-b80f-0222b72303b6"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 14.83m, "Granite", "Cheese" },
                    { new Guid("36c82abe-61be-4b68-beee-45c6b3f0dc3b"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 334.85m, "Cotton", "Table" },
                    { new Guid("3971f835-7ea7-40b0-8680-bbbc1b48fee4"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 244.71m, "Metal", "Bacon" },
                    { new Guid("3aad9893-027d-4823-8e8e-776fdfac26ee"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 820.63m, "Steel", "Soap" },
                    { new Guid("40077f83-6f6f-4c54-ba9d-f8c37f245379"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 555.91m, "Rubber", "Salad" },
                    { new Guid("45f6e16b-8b95-4bb7-a973-462d24722416"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 438.45m, "Steel", "Ball" },
                    { new Guid("4712a86b-1af5-4957-b860-cf26f3e397bb"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 833.96m, "Fresh", "Tuna" },
                    { new Guid("47b90623-4516-4eda-b735-ae09eb897626"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 363.44m, "Fresh", "Tuna" },
                    { new Guid("49eafd91-023a-4fba-af3f-39c06e1eb99c"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 809.54m, "Frozen", "Towels" },
                    { new Guid("505a9cec-0b74-4001-bd43-589989c72bc0"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 530.99m, "Frozen", "Soap" },
                    { new Guid("52a259c9-bcff-4679-9f6e-0f897ecabd89"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 299.17m, "Steel", "Shoes" },
                    { new Guid("581578ef-0b67-4289-8431-6e90aeb19022"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 458.40m, "Wooden", "Keyboard" },
                    { new Guid("59a56b29-4069-4841-a2d8-de8ab54ce947"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 171.99m, "Steel", "Car" },
                    { new Guid("5c562e12-96f2-4ed6-a1b0-50f4ee97700a"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 1.14m, "Plastic", "Chips" },
                    { new Guid("5d6ed57a-e645-42ad-a557-7537f3664d07"), "The Football Is Good For Training And Recreational Purposes", 475.32m, "Steel", "Cheese" },
                    { new Guid("5dcd77e7-01f8-442a-ba42-7eee733b8d37"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 19.25m, "Fresh", "Salad" },
                    { new Guid("5e95b224-e991-4042-97d2-28f4621d6d1f"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 892.15m, "Metal", "Bacon" },
                    { new Guid("5f5431de-d798-4dd6-af4e-db1cee42c3e5"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 547.91m, "Cotton", "Hat" },
                    { new Guid("5f771e80-9f23-4616-a2ce-f8d32012c56d"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 30.85m, "Granite", "Soap" },
                    { new Guid("5f910945-94c6-4ef1-b9cc-d794f72c6179"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 318.97m, "Rubber", "Chair" },
                    { new Guid("640a4c17-bf7b-4a64-a17c-cde8b6e3ae66"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 471.64m, "Cotton", "Chips" },
                    { new Guid("66dfb9c9-7a55-4d85-8665-c567009a33b2"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 897.87m, "Steel", "Computer" },
                    { new Guid("6876e602-b75b-4126-a3c8-4eb68517fd33"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 103.53m, "Plastic", "Salad" },
                    { new Guid("6ba4ce43-1037-4cae-829e-fbb06c72d4a0"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 63.93m, "Granite", "Salad" },
                    { new Guid("6e5728e1-9b14-43d5-9192-b54d4f4a86f9"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 477.97m, "Granite", "Towels" },
                    { new Guid("6f2a4d81-793d-4f84-8557-5a67b5399e20"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 338.66m, "Frozen", "Cheese" },
                    { new Guid("6f92fe26-4db3-4e69-9587-7b390b985f80"), "The Football Is Good For Training And Recreational Purposes", 322.79m, "Metal", "Pizza" },
                    { new Guid("70e87bf4-280f-429b-b84a-d49d59c7d156"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 569.93m, "Steel", "Towels" },
                    { new Guid("719737bb-cf55-4409-baa7-595b8861fe69"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 491.29m, "Fresh", "Ball" },
                    { new Guid("730b6bc4-3b23-448b-b14c-451915afde7b"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 266.86m, "Concrete", "Tuna" },
                    { new Guid("77ec89b4-90c1-45b3-ab75-ce8d434b1d30"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 985.97m, "Plastic", "Pizza" },
                    { new Guid("7927facb-3434-427f-880a-35a943d8a7ce"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 451.27m, "Wooden", "Keyboard" },
                    { new Guid("80c30b34-7412-4fbc-bf9d-0c3331495757"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 995.25m, "Granite", "Tuna" },
                    { new Guid("8242b3a4-089c-4e96-b91a-5fe804cb6fc5"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 834.65m, "Steel", "Hat" },
                    { new Guid("826b179c-ca4c-4f31-90a1-fce30d5af639"), "The Football Is Good For Training And Recreational Purposes", 983.56m, "Granite", "Salad" },
                    { new Guid("84a21d42-59d4-4ffd-87ca-ea5e4c6b3bae"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 773.66m, "Wooden", "Chicken" },
                    { new Guid("8706ba2d-e067-48f9-a656-2a6a1271689a"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 181.98m, "Granite", "Chips" },
                    { new Guid("87a92ed3-28ce-4c27-8ee8-6d31f5f8770b"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 682.84m, "Plastic", "Tuna" },
                    { new Guid("91452de0-7d9d-47ab-8e5c-50670bb48851"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 230.19m, "Soft", "Gloves" },
                    { new Guid("97cad5d5-96d1-4a60-8fde-01e342644e6f"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 166.18m, "Wooden", "Soap" },
                    { new Guid("9fb19bff-3cec-4d1a-8bec-17ee154a32bd"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 693.38m, "Frozen", "Bike" },
                    { new Guid("a054c7c8-b060-4b3c-a28e-4ab5b2a940c3"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 836.45m, "Frozen", "Bacon" },
                    { new Guid("a1a92d48-9896-448b-a4ad-aa23edb405b4"), "The Football Is Good For Training And Recreational Purposes", 220.59m, "Plastic", "Ball" },
                    { new Guid("a6c96148-5ef1-4732-81d4-48126ecd2eca"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 34.59m, "Rubber", "Hat" },
                    { new Guid("a6e00a50-492f-48da-9a7e-1d22b5ebd1a2"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 903.05m, "Granite", "Bike" },
                    { new Guid("a928b174-d04e-4d40-b918-317e180c7a10"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 780.09m, "Plastic", "Pizza" },
                    { new Guid("b0752ced-8817-48c3-a220-f2b8c5d3a54b"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 338.08m, "Plastic", "Towels" },
                    { new Guid("b0e6dd53-63e1-4045-9e15-ec8ce1b90cd9"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 301.57m, "Granite", "Hat" },
                    { new Guid("b40941dc-28f9-4b1c-b56d-bc5534c7ab7c"), "The Football Is Good For Training And Recreational Purposes", 286.02m, "Metal", "Bacon" },
                    { new Guid("b4770c02-99a3-4a5a-b670-ba70f470eed3"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 598.64m, "Metal", "Sausages" },
                    { new Guid("b4804c36-1426-4cfd-90c2-bc0d3d3f8dfc"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 7.09m, "Cotton", "Fish" },
                    { new Guid("b532e3f2-5c17-47a6-bd30-4e4b9b37bbfc"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 634.26m, "Steel", "Ball" },
                    { new Guid("b7095135-72b6-4dd3-9f9d-c56e9536d5ad"), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 631.92m, "Metal", "Table" },
                    { new Guid("bb8b4fe4-194f-4619-ac48-668127b1ab91"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 849.96m, "Rubber", "Fish" },
                    { new Guid("bda50be2-daa4-4bbf-af2a-fd8241a6ab5c"), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 956.13m, "Metal", "Tuna" },
                    { new Guid("be03c8af-94cc-4555-b447-3ea199e8ac07"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 477.34m, "Concrete", "Cheese" },
                    { new Guid("be1e13e4-c290-4bcc-ac6d-053588d166bf"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 441.22m, "Steel", "Keyboard" },
                    { new Guid("bf3ef748-812a-4a54-a353-89df49369b36"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 177.73m, "Metal", "Fish" },
                    { new Guid("c2f3d53e-4ea5-455e-946e-bb3dc8377a38"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 768.44m, "Fresh", "Salad" },
                    { new Guid("c385577a-2cba-4e60-afbc-80ab99a56c75"), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 61.19m, "Plastic", "Chips" },
                    { new Guid("c6cca50b-f596-4233-9c8f-3d5ce7cdd158"), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 102.95m, "Rubber", "Bacon" },
                    { new Guid("cb51fc78-4c23-4b8a-a6f6-14b984ffa372"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 780.51m, "Fresh", "Salad" },
                    { new Guid("d1b9d3b5-4378-4c0c-831d-edb21455fd17"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 793.06m, "Wooden", "Chicken" },
                    { new Guid("d63b3e06-eb86-4656-b1d2-4964653aa0b4"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 553.50m, "Plastic", "Sausages" },
                    { new Guid("d7e4f64f-82f1-4edf-98dd-fea878778361"), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 506.98m, "Metal", "Car" },
                    { new Guid("dec59db5-606f-4d7a-bc88-0488b1674d8d"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 243.68m, "Wooden", "Soap" },
                    { new Guid("e9bbaf94-a887-45fe-97b1-e6eea63580e7"), "New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart", 782.23m, "Fresh", "Sausages" },
                    { new Guid("ed1aa020-ef8e-483d-8e33-ac87aa8c9437"), "The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients", 920.22m, "Wooden", "Pants" },
                    { new Guid("f2a724fa-6aab-4f96-b8d3-25d3ac33ebe3"), "The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design", 246.23m, "Plastic", "Chair" },
                    { new Guid("f40a6387-2e73-4c2e-98c9-4267edf7b9a0"), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 218.30m, "Wooden", "Salad" },
                    { new Guid("f73609a3-f5a8-4f10-a431-64ea570972ac"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 89.77m, "Soft", "Chair" },
                    { new Guid("fc355f22-f110-4643-a030-3c5bfe48fe8d"), "The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive", 5.02m, "Frozen", "Pizza" },
                    { new Guid("fcb4cb45-c29c-4da6-afc4-54c09c9c4257"), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 246.09m, "Fresh", "Towels" },
                    { new Guid("fe5afa42-35f7-4190-a7f6-55dc8c56a8ee"), "The Football Is Good For Training And Recreational Purposes", 674.48m, "Plastic", "Fish" }
                });

            migrationBuilder.InsertData(
                table: "Customers-table",
                columns: new[] { "Id", "CountriesId", "Email", "FirstName", "LastName", "Locations", "Mobile", "Password" },
                values: new object[,]
                {
                    { new Guid("00766fd5-acaf-4d1c-be63-694ea6e55145"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Lucia.Hickle24@gmail.com", "Lucia", "Hickle", "6618 Jakubowski Point, Langoshchester, India", "1-811-739-7746 x465", "cG9UoSECEd" },
                    { new Guid("01354a06-c53c-4ab6-acb9-83b8f22b54f3"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Cecilia.Fadel93@yahoo.com", "Cecilia", "Fadel", "5141 Nienow Ford, East Sammychester, Aruba", "1-964-364-1985", "URg2aDjZbe" },
                    { new Guid("02408cce-7e0b-428f-b9ab-d33103530ab8"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Fredrick_Ratke86@yahoo.com", "Fredrick", "Ratke", "621 Marlen Brooks, Brigitteview, Czech Republic", "(784) 610-5944 x0364", "frHnHIvSuF" },
                    { new Guid("029c10cb-73bf-4089-8d30-e68652e18ce1"), new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Jacquelyn.Murphy@gmail.com", "Jacquelyn", "Murphy", "96671 Borer Vista, Port Delphine, Montenegro", "795.422.8153 x0731", "ORFvW5CuVx" },
                    { new Guid("02cfa5c6-3344-4158-a55d-a55728df8a2c"), new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Noah47@yahoo.com", "Noah", "Hessel", "481 Dickens Plaza, Bernhardhaven, French Guiana", "291.372.2828", "OBxSzSIP6I" },
                    { new Guid("0301d73b-9f32-4083-8b75-0245f8f8c4b1"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Mindy_Doyle@gmail.com", "Mindy", "Doyle", "512 Queenie Prairie, Lefflermouth, Panama", "(785) 477-9420", "o2d04pmAw8" },
                    { new Guid("03be8daf-00d4-4e74-ab49-8af0bed65fd4"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Randy_Bernier@yahoo.com", "Randy", "Bernier", "1441 Garry Streets, Monroeville, Hong Kong", "645.308.4947 x77282", "ey6i6Xvk5D" },
                    { new Guid("03e0d975-6646-4366-a2dd-7fbfe4ac302c"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Henry.Lehner@hotmail.com", "Henry", "Lehner", "148 Ferry Plain, North Lornaville, Bahamas", "598-333-4648", "HyUsSvrhzI" },
                    { new Guid("06202539-0cd8-4cbe-aac3-07575b775869"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Beth74@hotmail.com", "Beth", "Lynch", "0180 Damion Plains, South Luciousfurt, Antarctica (the territory South of 60 deg S)", "830-439-1578", "fx4NaBUB0x" },
                    { new Guid("0c80f4a4-4bba-46f5-b512-1ac2adf254c4"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Frances_Ratke@hotmail.com", "Frances", "Ratke", "60623 Hassan Underpass, New Haylie, Bahrain", "683.343.5399 x35535", "jMRjouqpMa" },
                    { new Guid("0ec28871-83d4-49b9-a246-8fc1b7e2889c"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Hope93@yahoo.com", "Hope", "Bartoletti", "6421 Breitenberg Squares, New Kendrickbury, Holy See (Vatican City State)", "1-461-460-5786", "fdIfGUop_c" },
                    { new Guid("0ef098a2-42e9-4e33-bdd9-cf01bc5de532"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Kristine21@yahoo.com", "Kristine", "Fahey", "2765 Brooklyn Meadows, South Aleen, Trinidad and Tobago", "388-700-4787", "sIMe8xrFlY" },
                    { new Guid("15a7bfa1-e774-4467-8d48-9ba8185e99b1"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Nick_Nikolaus87@gmail.com", "Nick", "Nikolaus", "391 Jade Brooks, South Leopoldostad, Jersey", "407.475.8464", "jfFKa9WzsH" },
                    { new Guid("15e0b801-53c8-4ba9-b739-7d8c4df7b9fd"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Jose52@hotmail.com", "Jose", "Funk", "49026 Clare Field, South Conner, Japan", "(648) 597-2880", "_MGHlSbS6Z" },
                    { new Guid("17923408-9491-4558-b411-fc72028c66b8"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Lyle73@hotmail.com", "Lyle", "Lakin", "375 Eliseo Green, Cassieville, Gabon", "(822) 890-2227", "32LUCwSnyN" },
                    { new Guid("180584e0-78fe-42be-b69e-489e983cc6c6"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Isabel_Hills@yahoo.com", "Isabel", "Hills", "72038 McGlynn Skyway, Port Elian, Latvia", "465-627-1592 x61141", "H_OgXJ_9Kp" },
                    { new Guid("1a4a0361-5d37-4efc-8e42-41990555b848"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Patti_Ankunding86@yahoo.com", "Patti", "Ankunding", "933 Jett Centers, Angelinaberg, Afghanistan", "258-317-7399", "mcCHbDIzNB" },
                    { new Guid("1a801d99-e1d2-4fe2-b837-58660bbb5efe"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Arnold_Huel35@gmail.com", "Arnold", "Huel", "4920 Marilyne Wells, New Vivaberg, Colombia", "(663) 415-5333", "9L_LELs4XB" },
                    { new Guid("1c01661e-8d0c-465f-905d-f415785bb45e"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Henry_King@hotmail.com", "Henry", "King", "678 Sporer Springs, New Ceceliaton, New Zealand", "1-357-526-2847 x887", "X3grSM5rgg" },
                    { new Guid("1c5b33b7-63f8-465f-8d5d-aefa4a7dff83"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Ivan86@yahoo.com", "Ivan", "Keeling", "6954 Mozell Parkways, Larkinhaven, Egypt", "(273) 601-0032 x16708", "jHPgWEkXWP" },
                    { new Guid("1c8362ac-1014-467a-abc0-0341ae920ff0"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Mack_Zulauf@yahoo.com", "Mack", "Zulauf", "935 Kelsi Squares, South Emiliano, Kenya", "453.742.4059 x19081", "7IJgqlVinM" },
                    { new Guid("1dcee12d-5fc9-4bcb-9529-2b98d87fb32d"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Ricardo.Langworth@yahoo.com", "Ricardo", "Langworth", "5829 Jenkins Point, Huelfort, Liechtenstein", "1-521-225-5788", "JEse4jXohm" },
                    { new Guid("1f9dced8-14b9-41bb-814e-1005ad1b7976"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Lucy_Predovic29@yahoo.com", "Lucy", "Predovic", "607 Major Squares, North Evan, French Polynesia", "871-727-5752", "aYlCm0SlOO" },
                    { new Guid("20817512-61d2-477c-bf0c-6e4993091dfd"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Isabel_Mitchell90@yahoo.com", "Isabel", "Mitchell", "905 Aufderhar Meadows, Danport, Bulgaria", "447.467.0436 x0572", "B1rXSuVMWo" },
                    { new Guid("217771bb-49b3-4237-8fba-f053922f8657"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Laurie.Larkin93@gmail.com", "Laurie", "Larkin", "894 Anderson Gateway, Moenstad, Estonia", "(646) 605-4408 x0688", "DYgYLt51Jn" },
                    { new Guid("22d5cea6-f58e-4efa-a39f-3dc331f4e92a"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Christie8@yahoo.com", "Christie", "Jast", "13529 Ferne Isle, Jedview, Argentina", "(551) 377-9961", "cmHYzMQA8J" },
                    { new Guid("2381b359-5bb3-4c64-ba36-589e1920f84a"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Bonnie92@gmail.com", "Bonnie", "Berge", "4240 Reid Turnpike, Port Misael, El Salvador", "516.403.6855", "eTraSIhgmz" },
                    { new Guid("23cd36c0-b7d7-4085-bdf6-7ff15b172443"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Laurie_Lakin@gmail.com", "Laurie", "Lakin", "04226 Legros Mountains, Zellaborough, Sao Tome and Principe", "777-558-4067 x94544", "pNj5L_drL3" },
                    { new Guid("23fd637c-0498-43a8-8577-30256067a25e"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Janie_Turner60@yahoo.com", "Janie", "Turner", "304 McDermott Springs, South Eva, Cyprus", "1-250-330-2975", "CkMSsJe9Me" },
                    { new Guid("279de27e-6bfd-499e-a204-267eb870948c"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Kendra_Daugherty11@hotmail.com", "Kendra", "Daugherty", "530 Fay Hollow, South Neomastad, Cook Islands", "867.826.5037 x07663", "3WOokQFobu" },
                    { new Guid("2928fb17-0d7b-45eb-9b6d-6ccdcd9cff03"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Leland18@yahoo.com", "Leland", "Padberg", "07773 Ansley Loaf, Murphyburgh, Romania", "1-456-254-8070 x3805", "BCHiP2Q7Yc" },
                    { new Guid("2a66488e-c654-4b7c-a649-7fdf7faff515"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Guy.Luettgen57@gmail.com", "Guy", "Luettgen", "929 Rowena Locks, North Vidal, Iraq", "(302) 477-8159 x525", "YBVDeqm5Cp" },
                    { new Guid("2c89fc76-c742-4bd4-8d95-59474ecac2f8"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Stacy24@yahoo.com", "Stacy", "Crooks", "96522 Rodriguez Expressway, Danahaven, Botswana", "1-592-836-0941", "xstmrdbeLF" },
                    { new Guid("2e90e9ef-a1d0-471b-adb7-bb5b969f5d42"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Doyle.Crist56@yahoo.com", "Doyle", "Crist", "3979 Chelsey Plain, East Yasmine, Serbia", "950.968.2094", "2eUvrlBEFR" },
                    { new Guid("30b5aeb3-542c-4198-9c8f-a5349d99f6a4"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Juanita54@yahoo.com", "Juanita", "Langosh", "199 Lebsack Cove, Hankhaven, Mexico", "(959) 784-5436 x2329", "741jA0s1V0" },
                    { new Guid("31ec5904-6fa2-4cef-b65d-7df1d7f682b3"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Ray.Carroll80@hotmail.com", "Ray", "Carroll", "24533 Hubert Club, Romaineside, Serbia", "205-979-5808", "O4esLsvduJ" },
                    { new Guid("323a34c5-fab2-4cdb-99f1-61a423584103"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Delia_Hilll26@yahoo.com", "Delia", "Hilll", "09468 Polly Motorway, North Zacharyport, India", "1-396-615-8245 x86648", "uPHvwtcCcU" },
                    { new Guid("33abaf9f-3cbb-452f-9d3a-2f5fa8210ca9"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Clark_Larkin@hotmail.com", "Clark", "Larkin", "81059 Hyatt Courts, West Angelitashire, Anguilla", "380-478-5623 x54989", "__Ub6fmx0n" },
                    { new Guid("33b8ec3b-489a-488d-a603-ee7ee7d380fe"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Blanca_Grady77@hotmail.com", "Blanca", "Grady", "36253 Earlene Highway, Port Karleeton, Timor-Leste", "591.417.4273 x8091", "yHnu9F0vVH" },
                    { new Guid("3878c0cb-f287-4c1d-ab63-5bd29a52a8a6"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Erick.Stehr@yahoo.com", "Erick", "Stehr", "51128 Allen Lodge, East Matteoview, Vietnam", "1-999-558-1928", "QutxXQH8go" },
                    { new Guid("38e29a08-ccee-4d44-85ee-f08e8e91ca9f"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Josephine.Hilll55@yahoo.com", "Josephine", "Hilll", "1317 Flatley Isle, Hattiefurt, Slovakia (Slovak Republic)", "724-497-2036 x95348", "iH4npI49y_" },
                    { new Guid("3915c2dd-e70d-4e04-af3f-40e41810655b"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Joan_Smitham75@gmail.com", "Joan", "Smitham", "336 Rippin Port, Lake Harleyshire, Central African Republic", "218.710.3329 x206", "Hy4SrICFwJ" },
                    { new Guid("39b91aac-c25b-46a2-9eee-943eb3044879"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Laurie86@gmail.com", "Laurie", "Keeling", "05939 Mayer Crescent, Nicolasberg, Virgin Islands, U.S.", "725-982-6462", "o20cq8pTkg" },
                    { new Guid("419b14c5-b740-4f3c-9f62-2e45fae39657"), new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Susan.Prosacco24@yahoo.com", "Susan", "Prosacco", "573 Ankunding Curve, Hertaview, Cuba", "(910) 490-2626 x9316", "ffhnuGcn6k" },
                    { new Guid("4238437e-e1b5-48e7-afc0-843da2bd3b78"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Faye.Bartoletti@yahoo.com", "Faye", "Bartoletti", "94952 Koch Passage, West Janelleshire, Ethiopia", "(438) 519-8495", "Amio4qaf9t" },
                    { new Guid("42ea06a6-1bd3-4804-8090-21c60e177918"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Amelia.Krajcik47@hotmail.com", "Amelia", "Krajcik", "6539 Jaskolski Isle, East Christinafurt, Christmas Island", "(839) 700-1828", "CmL1e4aAF1" },
                    { new Guid("43c45693-448a-45dc-bfb1-b7ccaaf0f301"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Frances3@yahoo.com", "Frances", "Welch", "964 Lehner Village, Port Gabriel, Nepal", "590.278.1024", "5_SyyL1Erx" },
                    { new Guid("4536b0bf-0cc0-45f3-9ce8-136324b46cfe"), new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Preston_Shields0@yahoo.com", "Preston", "Shields", "973 Heller Brook, South Griffin, Somalia", "(605) 786-2697", "OPnjrSnxgn" },
                    { new Guid("477a2cc2-f382-4ce5-8c84-d1ba69af5a2f"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Jan_Veum54@hotmail.com", "Jan", "Veum", "4371 Alene Valley, Prohaskaside, Liberia", "908.416.3311 x35954", "kOvtMGuRrU" },
                    { new Guid("488fbc58-bef9-4cca-8480-9b6217314fd1"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Sophie.Pfannerstill@gmail.com", "Sophie", "Pfannerstill", "3300 O'Hara Branch, Haleyport, Azerbaijan", "1-341-942-8317", "YdOKs_wDNe" },
                    { new Guid("495a6e52-8079-4e58-94bd-bea2ae4efeb4"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Delia59@gmail.com", "Delia", "White", "50394 Aisha Street, Novellatown, Rwanda", "591-419-4994", "xeWGIArN7R" },
                    { new Guid("49c78022-db4f-4997-b264-4446c54f1c7a"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Sean.Kris@gmail.com", "Sean", "Kris", "0089 Natasha Cliff, Ryleyborough, Yemen", "206-831-0974", "k8gXFyuy0q" },
                    { new Guid("4a6be79c-1556-4117-a5fd-c1119aa97287"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Willie_Berge@hotmail.com", "Willie", "Berge", "19222 Spencer Burg, New Ronfurt, Guinea", "(957) 657-3960", "r6eHMlIHlV" },
                    { new Guid("4cb3164e-9e2d-41f7-ae66-dfabf8155f26"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Desiree_Senger88@yahoo.com", "Desiree", "Senger", "8946 Kassulke Spring, Lake Raul, Costa Rica", "662.798.4693", "UvetyIkB7Y" },
                    { new Guid("4ee33b3c-112b-4949-9f12-d9f1b2239835"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Levi.Flatley@hotmail.com", "Levi", "Flatley", "444 Elisa Meadows, Schultzberg, Sweden", "(683) 360-8893 x6194", "47iB0XyL0l" },
                    { new Guid("5071aeaf-6bb9-4b89-93d2-13321867d0d3"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Allen.Nienow98@yahoo.com", "Allen", "Nienow", "4910 Dion Brook, Jasthaven, Peru", "508-931-5740 x7067", "MIHSFnt8Ip" },
                    { new Guid("5460aa98-a8bf-4ce8-a24e-128e66a645a8"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Alma48@hotmail.com", "Alma", "Crist", "42964 Emard Crescent, Eleonorefurt, Armenia", "1-265-999-5160 x647", "4dFLYUMcxH" },
                    { new Guid("5762993e-ade8-4dd2-bf9d-d2f7520bb5b3"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Israel11@gmail.com", "Israel", "McClure", "627 Alvina Forges, New Koby, Mongolia", "(996) 368-1444 x43906", "wbFCGarMN8" },
                    { new Guid("5a3d9b79-514e-4b0a-b26a-98b588b193c1"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Eunice94@gmail.com", "Eunice", "McCullough", "4334 Carmine Inlet, McCulloughfurt, Brazil", "1-394-516-9534 x2864", "IxhqEzE3cE" },
                    { new Guid("5af6ef04-c3df-445a-a142-f9ee642e18a7"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Yvette56@gmail.com", "Yvette", "Powlowski", "922 Mayert Drive, West Jennings, Brazil", "720.914.7388", "QWhC_oFAEm" },
                    { new Guid("6104d358-f50b-4480-909b-fef3369d69ae"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Greg53@yahoo.com", "Greg", "Reynolds", "9493 Nadia Mountains, West Jayceeside, Samoa", "578-853-9357 x6854", "VDxxGsyOyG" },
                    { new Guid("6356bee1-437b-47d1-905d-86c8e27521b5"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Marlon.Bayer@gmail.com", "Marlon", "Bayer", "660 Jefferey Fort, West Lucile, Libyan Arab Jamahiriya", "1-595-876-6155 x45393", "R2tMqCgK5S" },
                    { new Guid("642aa5a0-6910-4d93-9e3d-0aed72375be8"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Wallace36@yahoo.com", "Wallace", "Nikolaus", "828 Bogisich Lodge, Port Delta, Swaziland", "207-248-1838 x0821", "OLYxqHACuv" },
                    { new Guid("66a70151-bed4-42ae-a59d-aa56dfb65ee2"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Alyssa.Bruen@hotmail.com", "Alyssa", "Bruen", "340 Abelardo Trail, Schoenbury, Falkland Islands (Malvinas)", "(353) 771-5527", "vvbOxvd90p" },
                    { new Guid("6b3e222e-8242-40bc-bc1c-fe2dc8318a1b"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Jennifer10@hotmail.com", "Jennifer", "Hayes", "733 Sierra Village, Wymanberg, Namibia", "965.522.3536", "MSXV5eSk9Y" },
                    { new Guid("6d095460-9cab-461f-b389-7f8195b6f22d"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Derek_Runte96@hotmail.com", "Derek", "Runte", "8668 Davis Shoal, Deckowville, French Southern Territories", "691-928-2647", "Xlpd0NIgr2" },
                    { new Guid("6d690bbe-6ad8-4314-b6bd-3ee5088ed8a4"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Hattie.Tremblay60@hotmail.com", "Hattie", "Tremblay", "6020 Sporer Fords, West Jarod, Chad", "1-477-398-9723 x761", "NzkTUtajQV" },
                    { new Guid("6ded9bd2-e8ac-4ae2-ac8e-6794816b85dc"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Virginia.Pfannerstill73@gmail.com", "Virginia", "Pfannerstill", "187 Felix Point, Hauckbury, New Caledonia", "(725) 350-8754", "ExHUwH_3Zr" },
                    { new Guid("6f230800-de0f-4a77-a9ba-cb2cdd5cbee7"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Lorene_Gerhold@yahoo.com", "Lorene", "Gerhold", "945 Olin Causeway, Feestmouth, China", "1-879-824-5060", "NLxEy16i5z" },
                    { new Guid("736a6554-ed48-4651-9327-e792751883e9"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Phillip.Harvey43@hotmail.com", "Phillip", "Harvey", "01045 Nikita Vista, Dickihaven, Niue", "1-643-346-2500", "RvR3AuLUTH" },
                    { new Guid("741c557c-c4e7-4cd0-844d-d43c7a7aa9cf"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Eugene14@gmail.com", "Eugene", "Zulauf", "056 Leonardo Circle, New Uriel, Ireland", "780-804-3315", "03k19tY5jL" },
                    { new Guid("76471559-cdd1-4c21-a817-21b0383b85e5"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Jennifer.Koss@yahoo.com", "Jennifer", "Koss", "58253 Luettgen Cliffs, Port Bellshire, Spain", "645.425.6505", "WGhiuWCGMZ" },
                    { new Guid("7c8ccd2d-dba5-4bae-af1d-7cc654b96211"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Richard.Gutmann@hotmail.com", "Richard", "Gutmann", "50093 Bennie Rapid, Schmidtton, Serbia", "506-798-1016 x853", "rodRFnsm10" },
                    { new Guid("7e7b06a7-587e-4f2a-9b4c-0d9a513df6ca"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Cornelius.Wehner@gmail.com", "Cornelius", "Wehner", "5353 Barrett Ports, West Cristalshire, Indonesia", "(687) 403-5025", "x1JrtbIoqY" },
                    { new Guid("7e86f95c-4ac7-47d4-a459-9c0b7e26d97e"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Garrett.Schneider1@gmail.com", "Garrett", "Schneider", "16072 Pearlie Canyon, Feeneyfurt, Finland", "955.300.9787", "GS9Cjc8eNI" },
                    { new Guid("7eb3850a-e85b-4e46-ae0f-7edde6856308"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Tim.Hansen96@gmail.com", "Tim", "Hansen", "4628 Balistreri Roads, Enochland, South Africa", "(478) 552-9397 x1150", "itVKW4akk8" },
                    { new Guid("82fec5ec-67d4-4557-a977-c25d8f354c93"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Robin94@hotmail.com", "Robin", "Doyle", "0544 Marks Parkways, Nitzscheland, Northern Mariana Islands", "348.253.6848", "bxEn7zNDnW" },
                    { new Guid("8666cba7-58a3-4d8d-a8f2-d061b863604e"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Dewey_Schoen@gmail.com", "Dewey", "Schoen", "72145 Kuhic Prairie, North Jonatanport, Slovakia (Slovak Republic)", "1-864-893-8380", "QVumvwWjEF" },
                    { new Guid("87ad2176-038b-4db9-ac43-339d41537700"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Anna_Kozey39@yahoo.com", "Anna", "Kozey", "2645 Kihn Manor, Uptonfort, Anguilla", "323.594.6879 x7227", "22pAV39Nju" },
                    { new Guid("87c8d0d0-9fad-4aae-b284-da752c7ade1d"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Rex.Lebsack78@yahoo.com", "Rex", "Lebsack", "092 Murphy Road, South Doloresburgh, Germany", "986-351-1126", "dUW6s_jhHM" },
                    { new Guid("89437952-348c-4f70-8f5c-123fe077fe18"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Tommie_Lueilwitz70@gmail.com", "Tommie", "Lueilwitz", "96049 Jast Village, North Lucioport, Heard Island and McDonald Islands", "1-555-254-8958 x75449", "aRWWza7iF3" },
                    { new Guid("8a0fc9ac-7abd-49ed-b9da-b9efd53e8d0f"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Alberto_Hoeger82@hotmail.com", "Alberto", "Hoeger", "6586 Turner Mission, Santiagoberg, Seychelles", "668.421.9856 x23444", "BJTWBA5c8y" },
                    { new Guid("8a252b4d-3638-420e-aebe-9467e8f5883b"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Olive_Kuhn@hotmail.com", "Olive", "Kuhn", "6325 Ferry Estate, East Elmerville, Chad", "801.531.8467", "BKTyjFVIpL" },
                    { new Guid("8a5dd9fe-e7c6-42ec-8da1-5a3566197af1"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Alex82@gmail.com", "Alex", "Bogisich", "190 Kling Lake, North Glenna, Marshall Islands", "(416) 559-2375 x847", "xeUvcnmjGZ" },
                    { new Guid("8a706266-ad41-4630-87c0-412a9d9c2e0f"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Terrence.Cummerata73@hotmail.com", "Terrence", "Cummerata", "656 Rickie Via, New Rahul, San Marino", "525-548-9024 x2260", "VrmtRlD5e9" },
                    { new Guid("8a870aba-3606-4277-830c-ce24c0c46ac4"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Juana_Hirthe85@hotmail.com", "Juana", "Hirthe", "818 Fahey Neck, Tryciaberg, Malta", "429-223-4599", "JY1zcGcm_j" },
                    { new Guid("8af3a2f6-935a-4955-8913-5b5829a486ab"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Shelly_Tromp54@yahoo.com", "Shelly", "Tromp", "455 Clare Landing, Addisonville, Ethiopia", "1-653-282-4499 x624", "HIm6LDqbd9" },
                    { new Guid("8d3974da-1de1-4c54-b167-e85e7ee4069f"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Martin.Crona72@yahoo.com", "Martin", "Crona", "275 Jakubowski Stravenue, New Oleta, Faroe Islands", "512-758-0790 x6391", "2WdObTFmoC" },
                    { new Guid("8dbf1c4a-e04c-422f-b595-1cc0eed8f927"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Ralph_Rohan@hotmail.com", "Ralph", "Rohan", "35033 Howell Place, North Alphonso, Saint Helena", "415.267.9432 x55181", "wofwgYpEji" },
                    { new Guid("8e74f977-7e5d-4e2a-ac42-79f1df5d36dc"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Domingo.Nitzsche@gmail.com", "Domingo", "Nitzsche", "230 Simonis Camp, Farrellview, Mauritius", "1-583-474-8735 x25324", "b4YeliERLU" },
                    { new Guid("8fd80892-bfe0-4a39-9a7b-19388722db3e"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Johnnie10@gmail.com", "Johnnie", "Jacobson", "4770 Hoeger Stream, Keeblerville, Saint Kitts and Nevis", "406-602-4537", "kUuaUe9Ahc" },
                    { new Guid("90c1888c-4b6e-479f-bf99-7b748748901e"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Ralph_Shanahan@hotmail.com", "Ralph", "Shanahan", "7612 Lockman Motorway, Murrayborough, Romania", "1-842-888-9178 x68253", "bK6XK0xBhq" },
                    { new Guid("91f485ac-3956-46a2-bac5-701140f09a2b"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Pete_Cremin@gmail.com", "Pete", "Cremin", "66036 Lubowitz Land, West Everette, Haiti", "(531) 716-3954 x3373", "VpaD5uzsP_" },
                    { new Guid("95732f6e-b1ea-4423-b039-76eea9d65229"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Constance_Douglas@yahoo.com", "Constance", "Douglas", "7444 Braden Overpass, Lake Katelinton, Belarus", "703-558-0758 x2768", "QChaVfEDrK" },
                    { new Guid("95d91de4-49a7-4054-a0ff-6c6357496180"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Phyllis.Medhurst@yahoo.com", "Phyllis", "Medhurst", "714 Ruby Loaf, Nedrahaven, Namibia", "1-815-449-5856 x46413", "toAhGkZWxb" },
                    { new Guid("96d03091-f349-444b-8bc2-82346c1fdb17"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Bessie.Bernhard@hotmail.com", "Bessie", "Bernhard", "13147 Fay Tunnel, Kundeport, Liberia", "1-723-534-5962 x20683", "i7li8lJDaE" },
                    { new Guid("97b5f8d2-7847-494c-ba48-7c5578a1958c"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Ernestine.Schmeler91@hotmail.com", "Ernestine", "Schmeler", "966 Predovic Unions, East Soledadhaven, Moldova", "981.355.4024 x687", "N0uIo4ppCE" },
                    { new Guid("988f5984-bdc5-4df7-96bc-3181ef1f8138"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Jimmie_Stanton@yahoo.com", "Jimmie", "Stanton", "8747 Jannie Crossing, Samantaberg, Nicaragua", "302-621-0534 x12886", "FiLgjVuA8c" },
                    { new Guid("9a0afdcf-e28f-44d3-b018-18d4dcd47332"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Forrest_Nitzsche42@gmail.com", "Forrest", "Nitzsche", "335 Jayme Ferry, North Kaden, Tanzania", "1-423-668-0404 x58882", "OsovxQbfFi" },
                    { new Guid("9de5d6d6-d6ea-407b-9aef-a89e320b372b"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Sally56@gmail.com", "Sally", "Luettgen", "428 Caleigh Passage, Watsicaberg, Solomon Islands", "1-715-218-3696", "yErGYEwvgC" },
                    { new Guid("9fe2afa2-9acf-4404-bd38-3322d37fb7f2"), new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Melody39@yahoo.com", "Melody", "Mitchell", "777 Jaskolski Square, East Nasir, Lithuania", "(661) 677-3216", "KWncU4b7SY" },
                    { new Guid("9fff0836-d806-4725-b0f3-714df9467b64"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Randolph50@hotmail.com", "Randolph", "Pagac", "16247 Fabian Plaza, Flatleyborough, Nigeria", "280.411.2932", "C1EQcEzr1k" },
                    { new Guid("a22a866b-3773-4944-a68c-1c53e00bf09d"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Noah.Corkery48@yahoo.com", "Noah", "Corkery", "3921 Hyman Spurs, Maximemouth, Russian Federation", "1-871-808-9597 x556", "jsT4SAMf0m" },
                    { new Guid("a2a00955-7998-4218-b057-8d529f1b8146"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Emmett_Lind@yahoo.com", "Emmett", "Lind", "387 Kiara Manor, Camrynbury, Guinea-Bissau", "993-559-8169", "G2vwh9GBLb" },
                    { new Guid("a3dc9797-8f2d-4216-bb85-4997f27628a6"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Christopher_Weissnat93@gmail.com", "Christopher", "Weissnat", "917 Alex Creek, West Dasia, Uganda", "1-290-674-7080", "U9n6bHtEFo" },
                    { new Guid("a4645c96-6993-41a8-99f9-73d7060f40db"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Sheryl_Nikolaus@gmail.com", "Sheryl", "Nikolaus", "257 Schumm Stravenue, Ewellhaven, French Polynesia", "1-332-922-0879 x9945", "9zDgzopYnH" },
                    { new Guid("a7826410-9933-46db-9f75-1759c24df647"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Earnest_Emmerich63@gmail.com", "Earnest", "Emmerich", "8087 Aufderhar Wells, East Allan, Lao People's Democratic Republic", "1-252-206-9635", "EYIQK4lQTR" },
                    { new Guid("a87b5aed-2f7a-489f-9617-37998cfd83ef"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Charlotte.Hand@yahoo.com", "Charlotte", "Hand", "084 Guadalupe Glens, Walshland, Puerto Rico", "499.218.7659 x160", "UNpI2JbNIG" },
                    { new Guid("a917974e-575c-4dcd-934e-56ad5e7a50d3"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Kate44@yahoo.com", "Kate", "Leannon", "7873 Lind Vista, New Santinoton, Sierra Leone", "755.320.5128", "YpnPFDrYRA" },
                    { new Guid("aafe087c-2d3d-4875-9868-5d4643368886"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Rhonda47@yahoo.com", "Rhonda", "Mueller", "6443 Homenick Islands, Lake Rociostad, Brunei Darussalam", "757.483.8472 x27006", "w0syF6uj7e" },
                    { new Guid("ac0de5a6-a293-421f-a5cc-8a5c0809897d"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Gilberto_Rogahn40@hotmail.com", "Gilberto", "Rogahn", "285 Emelia Summit, West Mathildetown, South Georgia and the South Sandwich Islands", "(554) 853-1699 x447", "YERAg_Irjw" },
                    { new Guid("acb498ca-c8ab-43fc-9264-e26b12dbf6e8"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Billie_Cummings96@hotmail.com", "Billie", "Cummings", "3294 Prosacco Radial, East Novellastad, Chile", "(803) 217-6952 x865", "jDS2TeyR_U" },
                    { new Guid("ad0bfea3-0164-4e19-8119-b50aeaf67302"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Saul0@yahoo.com", "Saul", "Pfannerstill", "7239 Davin Plaza, Vernaland, United States of America", "438.672.5856 x370", "cxsjTHu05l" },
                    { new Guid("b36ea917-6e43-49e7-afa5-0c9735dd29a3"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Luis_West92@gmail.com", "Luis", "West", "530 Kunde Ramp, Strosinburgh, Isle of Man", "(404) 212-1020", "cdRQXE7_FE" },
                    { new Guid("b37e76ac-90a5-455b-b472-ceb6bbffdc5c"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Neal.Rath41@yahoo.com", "Neal", "Rath", "069 Jakubowski Knolls, Gutmannborough, Argentina", "553-883-4664 x918", "r0HD1Me8Sm" },
                    { new Guid("b7db1dd9-3963-43fb-ae12-2bced4443fde"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Linda_Powlowski@yahoo.com", "Linda", "Powlowski", "4167 Bernhard Skyway, Port Rosetta, Namibia", "395-414-9706 x21569", "muVSsDIxZB" },
                    { new Guid("b866e89f-7694-43f0-bf3f-f2162fb287bb"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Paula_OHara@hotmail.com", "Paula", "O'Hara", "9747 Grimes Stravenue, Lake Josephine, Ireland", "1-440-543-5986", "G6ESVsEX7S" },
                    { new Guid("bae1838e-6b3a-4e65-bc7a-446a06578ce6"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Earl34@gmail.com", "Earl", "Jacobs", "8031 Wuckert Road, East Cecilside, Estonia", "743-719-3718 x82654", "p9NGE_2jTB" },
                    { new Guid("bc3ddbe0-0cd9-4bc0-a38a-bcb1b7fafc25"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Lynne98@yahoo.com", "Lynne", "Kihn", "64968 Chelsey Loop, West Rivermouth, Somalia", "1-280-742-6935 x58144", "pyQ2iqVHJH" },
                    { new Guid("bc8694cd-cf70-4157-8851-7c576948fd44"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Faye9@gmail.com", "Faye", "Strosin", "8984 Brekke Squares, South Nicolasfort, Lebanon", "868.776.2907 x1554", "WShrJ6U5BQ" },
                    { new Guid("bd2d744c-46e9-4d6b-87fb-594fe6ed757f"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Ronald.Kozey@gmail.com", "Ronald", "Kozey", "60246 Mills Shore, Goyetteburgh, Anguilla", "(607) 348-9351", "cezGGhDoFB" },
                    { new Guid("be3372bc-dee7-4d54-abfc-4bf33e874b04"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Kathy.Johnson@hotmail.com", "Kathy", "Johnson", "73227 Metz Ranch, Daughertyberg, Mozambique", "(496) 898-4927 x90233", "Owp5LIQ4xy" },
                    { new Guid("bfcb80e7-1a11-4688-9b65-469a332f9ff4"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Felix_Kemmer@yahoo.com", "Felix", "Kemmer", "68599 Wiegand Roads, Oberbrunnerchester, Cameroon", "1-278-207-0423", "X9joNsamIK" },
                    { new Guid("c88fa2d4-9b42-41d6-9975-448f27eadcd5"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Christina6@gmail.com", "Christina", "Cartwright", "801 Farrell Street, Homenickchester, Belarus", "1-954-414-6697 x3693", "v5Bm7TA_e3" },
                    { new Guid("c963cc25-f665-4a19-a3f7-a9fd84c331b3"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Angela.Koch@hotmail.com", "Angela", "Koch", "189 Kub Fork, Sophiatown, Brunei Darussalam", "(460) 625-4672 x0175", "Mz1XnDuqKY" },
                    { new Guid("c973630e-79de-4ce6-bca8-fe705a36ce8e"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Nettie35@hotmail.com", "Nettie", "Hauck", "18266 Hermann Locks, Bartville, Netherlands", "(691) 626-1163 x30361", "vXSJleuBrc" },
                    { new Guid("c97e838d-8210-4215-b102-af4f893ab1cc"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Javier32@gmail.com", "Javier", "Harber", "46527 Abshire Junctions, Wehnertown, Austria", "1-623-702-5448", "fLfiwelmkY" },
                    { new Guid("c99aaa0e-9826-4b7a-a0b6-b0969c9395f3"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Gordon_Boehm15@hotmail.com", "Gordon", "Boehm", "516 Barton Causeway, West Unique, Zambia", "1-575-380-4359", "W9r_oT8mUz" },
                    { new Guid("ca742b5d-9cde-4203-8d6d-d136264e0865"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Cathy.Blanda@gmail.com", "Cathy", "Blanda", "5952 Nitzsche Rapid, Rosarioshire, Saint Pierre and Miquelon", "1-270-394-4070", "lR5eVNYvky" },
                    { new Guid("cb003111-9a21-4a04-8f2b-7c73586af2cd"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Alberta_Stokes99@yahoo.com", "Alberta", "Stokes", "6617 Kuhlman Courts, Lake Lina, Kuwait", "414-261-8405 x731", "BZn0OKbvVw" },
                    { new Guid("ce7b5142-984b-442e-bd9f-0ae8788a7a08"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Hazel.Mraz39@yahoo.com", "Hazel", "Mraz", "200 Novella Forks, New Allie, India", "1-333-784-5994 x78856", "S66mPEDxmm" },
                    { new Guid("d5527260-b891-451d-a87b-1674a0589f35"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Roland_Ryan@gmail.com", "Roland", "Ryan", "847 Federico Green, Gorczanymouth, Grenada", "1-466-774-6045 x873", "6Suv0T4ozG" },
                    { new Guid("d5a438bd-d6cc-461d-9163-9d2cd2f8c5e5"), new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Bert_Casper67@hotmail.com", "Bert", "Casper", "8384 Shields Flats, South Rachael, United Arab Emirates", "1-668-497-6104", "zLYC2IJXvx" },
                    { new Guid("d8e7c987-6934-4a8f-a428-f90db0e804cf"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Brent.Ankunding@hotmail.com", "Brent", "Ankunding", "7454 Kozey Mill, North Houston, Fiji", "1-564-372-6739 x3126", "9LGAUQ9PcA" },
                    { new Guid("da7cdcbc-a36d-4031-b378-7cb2fd7c5d85"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Margarita.Altenwerth67@yahoo.com", "Margarita", "Altenwerth", "0965 Dach Route, Lake Felixmouth, Monaco", "(309) 837-9607", "NzRgRuqb8i" },
                    { new Guid("daa9f3f8-50e0-41ff-bc9a-1df85091d996"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Dean.Bechtelar27@gmail.com", "Dean", "Bechtelar", "504 Hermiston Road, Kovacekbury, Uganda", "988.309.5144", "ZzIBFKY8J0" },
                    { new Guid("dbe6c0a6-0527-48fb-9847-6e6d6c6b9cf8"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Fernando.Schamberger@yahoo.com", "Fernando", "Schamberger", "3464 Gail Dam, Raynorside, Bangladesh", "1-422-955-8740 x30548", "EfNiCrtuQT" },
                    { new Guid("df4620a6-bbc5-4fe7-9239-35a7b8250f13"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Chad29@hotmail.com", "Chad", "Kuphal", "95220 Runte Mount, Starkside, Russian Federation", "741.708.9899 x383", "mohyu1cRqB" },
                    { new Guid("dfaacd7d-debf-42f3-aa55-42a2ae2408aa"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Marsha.Jerde94@yahoo.com", "Marsha", "Jerde", "410 Kenyatta Ports, Torpberg, San Marino", "804.484.7332", "aQ1UF5RTSy" },
                    { new Guid("e4642183-0375-4871-9a73-c2ef6b1d50b7"), new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Juana_Rath@yahoo.com", "Juana", "Rath", "19150 Winona Manor, North Hobart, Iceland", "(897) 322-7226", "JtYthwd_3Q" },
                    { new Guid("e753d7ed-81f2-43a7-b0a5-acfc390b37ce"), new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Karl_Murphy@yahoo.com", "Karl", "Murphy", "891 Sporer Loop, McCulloughview, Brunei Darussalam", "1-758-303-8148", "fRUIqWuLkC" },
                    { new Guid("e8d62e84-8ce7-4dda-a2a9-4e2f6a984363"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Pearl_Hermann21@yahoo.com", "Pearl", "Hermann", "033 Gunnar Burgs, Schroederhaven, Morocco", "876-812-9640", "Is6ye9z9MA" },
                    { new Guid("eb55be35-7452-4a04-b6f0-6683f4589b29"), new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Stewart44@yahoo.com", "Stewart", "Langosh", "8597 Durgan Station, Cyrusshire, South Africa", "(961) 428-2764 x00063", "aPZeCvkrO9" },
                    { new Guid("ed343fa7-a1c9-40ff-bbdb-1fc08a9653a9"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Jessie_Yundt93@hotmail.com", "Jessie", "Yundt", "4828 Brenden Parkway, Lake Judsonhaven, Cote d'Ivoire", "737.624.4577 x08145", "mOHnb7Vedc" },
                    { new Guid("ee920c98-3f59-4042-b701-ab504f7efdc6"), new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Jordan.Streich@gmail.com", "Jordan", "Streich", "972 Gottlieb Locks, Evelyntown, Oman", "(264) 454-4009 x7718", "HaYPdkGG4r" },
                    { new Guid("f2e90a63-c92c-4952-b823-8cd71cec3d2d"), new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Joey.Runte@gmail.com", "Joey", "Runte", "944 Olga Cove, New Ibrahim, Latvia", "627-294-1046", "pgYjD9gj2J" },
                    { new Guid("f3ea97e0-110a-4b0b-a0be-a622983211a3"), new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Bertha.Roberts43@gmail.com", "Bertha", "Roberts", "350 Brendan Lake, Prohaskaborough, Virgin Islands, U.S.", "511.895.5363 x49202", "gJsihqfucX" },
                    { new Guid("f61a5c41-c274-472e-bfa8-0a2abdcfacb1"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Nicolas.Littel@hotmail.com", "Nicolas", "Littel", "8324 Laila Plaza, South Dominicbury, Tanzania", "370.704.6160 x6663", "hG3T7cyr86" },
                    { new Guid("fc45dbea-36fa-495f-8606-23b17ab1e7d0"), new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Lorenzo_Hoeger@hotmail.com", "Lorenzo", "Hoeger", "1321 Koepp Knoll, Lake Bruce, Pakistan", "1-532-933-7935 x39969", "6Nb6r9uo2B" },
                    { new Guid("fd16122e-d10a-4ab3-895d-9d683538a17d"), new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Wendell_Jakubowski@gmail.com", "Wendell", "Jakubowski", "78989 Oren Plaza, Mayerbury, Serbia", "1-679-676-0000 x9393", "geLFQkIr0R" }
                });

            migrationBuilder.InsertData(
                table: "Distributors-table",
                columns: new[] { "Id", "Address", "CountriesId", "Description", "Email", "Title" },
                values: new object[,]
                {
                    { new Guid("00523128-40e3-435e-ad43-70be69689dc3"), "350 Maiya Road, Adolfport, Ghana", new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Persistent high-level encryption", "BrekkeGroup_Batz53@gmail.com", "Brekke Group" },
                    { new Guid("1e2010f4-26d3-47d4-8c58-52202e3978e3"), "5178 Kessler Plains, Zolamouth, Sudan", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Managed tertiary alliance", "Smitham-Schneider_Bashirian28@yahoo.com", "Smitham - Schneider" },
                    { new Guid("210ed0a7-31c3-4bc2-984c-4ad9e88832ff"), "1861 Lambert Gardens, Hamillchester, Samoa", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Decentralized 4th generation workforce", "JohnsLLC.Yundt@yahoo.com", "Johns LLC" },
                    { new Guid("218604f7-4739-47e8-8a25-d852b87fb718"), "60512 Alta Valleys, Kayceeville, Christmas Island", new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Exclusive 24/7 moderator", "Zulauf-Walker48@gmail.com", "Zulauf - Walker" },
                    { new Guid("2285bbc9-ca78-4107-af0c-2f5c2c92f39b"), "50822 Grimes Passage, Croninfurt, Comoros", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Focused well-modulated initiative", "Sauer-Shields.Boyer@yahoo.com", "Sauer - Shields" },
                    { new Guid("23892fe0-010d-4637-834e-206bbd081e27"), "596 Sienna Points, Haleystad, Lithuania", new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Extended discrete hub", "RobelGroup24@hotmail.com", "Robel Group" },
                    { new Guid("29bc03ed-979b-4022-bb4a-8cca17bdcc34"), "0430 Alford Rapid, East Martinabury, Malaysia", new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Intuitive executive groupware", "Johns-Harris_Gerhold65@gmail.com", "Johns - Harris" },
                    { new Guid("310701a9-bdd1-44d4-bbe9-762b3cf2b248"), "1964 Imelda Summit, Lake Antonina, Pakistan", new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Grass-roots uniform solution", "HarveyInc56@yahoo.com", "Harvey Inc" },
                    { new Guid("35a83c61-b044-4e42-b1b0-d65fe7b23d56"), "99729 Marion Ports, West Rossiestad, Costa Rica", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Fundamental full-range secured line", "Abshire-Daniel_King@hotmail.com", "Abshire - Daniel" },
                    { new Guid("36db4aef-06fa-44b6-b1d1-843826d460e8"), "4347 Willard Circle, Lueilwitzbury, Guam", new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Adaptive empowering utilisation", "HodkiewiczRyanandHaley.Dickinson@hotmail.com", "Hodkiewicz, Ryan and Haley" },
                    { new Guid("3f3c3ee8-61c1-46d6-9e70-007c79c51271"), "75678 Melissa Spring, Lorineview, Northern Mariana Islands", new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Multi-layered tangible core", "RennerLLC.Lakin45@hotmail.com", "Renner LLC" },
                    { new Guid("4afc189d-20d6-40b7-934d-f1c845648efc"), "576 Prince Pike, New Israel, Niue", new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Balanced zero tolerance customer loyalty", "PowlowskiReingerandChristiansen.Towne52@gmail.com", "Powlowski, Reinger and Christiansen" },
                    { new Guid("4ce4542a-2ee4-4832-821d-bc43538c648e"), "2778 Mraz Landing, East Delphia, Papua New Guinea", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Upgradable dynamic monitoring", "CorkeryJenkinsandMcKenzie.Christiansen98@hotmail.com", "Corkery, Jenkins and McKenzie" },
                    { new Guid("4dff1775-70bf-4986-8c17-5b3c33941349"), "764 Block Shore, Borerland, Gabon", new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Persevering actuating definition", "GusikowskiBrakusandPollich.Welch91@gmail.com", "Gusikowski, Brakus and Pollich" },
                    { new Guid("4ed7bf43-96a2-48f8-8ae3-b28a4b5befb5"), "393 Kaitlin Station, Lake Reese, Spain", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Balanced background challenge", "DouglasBoyleandJacobs54@hotmail.com", "Douglas, Boyle and Jacobs" },
                    { new Guid("519b157c-8f9c-4bb6-800f-97414aa01d14"), "0362 Ondricka Valleys, East Vergiefort, Mauritius", new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Vision-oriented even-keeled definition", "WiegandandSons81@gmail.com", "Wiegand and Sons" },
                    { new Guid("5843dbfa-978d-489c-b53b-293481b431ae"), "3930 Howell Courts, New Vickyfurt, Netherlands", new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Profit-focused 4th generation analyzer", "FeilRunolfsdottirandKutch69@gmail.com", "Feil, Runolfsdottir and Kutch" },
                    { new Guid("5a688e44-02a0-4856-8fff-d75f2a262593"), "2662 Gleichner Corner, Mertzside, Angola", new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Proactive explicit standardization", "EbertFeeneyandSchmeler_Marquardt@yahoo.com", "Ebert, Feeney and Schmeler" },
                    { new Guid("606dff51-79b3-4d2c-8242-d873eaddf28a"), "044 Barton Overpass, New Darby, Iraq", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Phased exuding help-desk", "VonRuedenSpencerandYundt_Kertzmann@hotmail.com", "VonRueden, Spencer and Yundt" },
                    { new Guid("61adac8d-ba51-48a8-97bd-b1011776520a"), "918 Bergnaum Vista, North Calista, Malaysia", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Function-based systematic firmware", "MohrGroup.Marks@hotmail.com", "Mohr Group" },
                    { new Guid("620aa7cd-0e9c-4614-87b4-c60551a29c76"), "40850 Johnson Views, Haroldmouth, Equatorial Guinea", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Reverse-engineered upward-trending circuit", "Jast-Pagac.Balistreri@yahoo.com", "Jast - Pagac" },
                    { new Guid("70694336-a703-4eb6-aa49-3f76d154a172"), "0640 Mohr Street, New Mckenzie, Liechtenstein", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Pre-emptive exuding framework", "DavisGroup_Bednar@yahoo.com", "Davis Group" },
                    { new Guid("71f4dc3b-419d-4c2a-910d-e377fe005084"), "447 Winston Islands, Johnsonmouth, Trinidad and Tobago", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Polarised bifurcated secured line", "Frami-Grant_Spinka@gmail.com", "Frami - Grant" },
                    { new Guid("73ebd261-d2d4-4a8a-8e39-6d065d97a137"), "12552 Luz Walks, Tianahaven, Niue", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Cross-group dedicated access", "LeschSchmittandAnderson99@hotmail.com", "Lesch, Schmitt and Anderson" },
                    { new Guid("7e2804fc-8cc0-4bf8-8336-634352efdfe2"), "702 Schimmel Parkway, Bauchport, Guadeloupe", new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Automated optimizing focus group", "Reynolds-Mosciski_Turner@hotmail.com", "Reynolds - Mosciski" },
                    { new Guid("7e955e55-78b1-484f-b0eb-51d2c2425ca6"), "134 Runolfsdottir Islands, West Jessica, Dominica", new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Polarised directional flexibility", "Beier-Pfeffer63@yahoo.com", "Beier - Pfeffer" },
                    { new Guid("83a9a7fd-ce28-42db-893d-bd0b9350fdd9"), "118 Carrie Lodge, Brakusmouth, Russian Federation", new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Diverse modular internet solution", "KuhnSchimmelandUllrich_Rohan70@yahoo.com", "Kuhn, Schimmel and Ullrich" },
                    { new Guid("84c87106-521a-4178-9e6b-5c49bd8bb946"), "529 Schaden Stravenue, Gaylordtown, Madagascar", new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Managed reciprocal strategy", "WolffGoldnerandBartoletti43@gmail.com", "Wolff, Goldner and Bartoletti" },
                    { new Guid("87d6652d-6f9e-492e-99ec-2e7e8721299e"), "18680 Lurline Meadow, Blandaport, Russian Federation", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Universal scalable concept", "SchillerInc_Wehner@hotmail.com", "Schiller Inc" },
                    { new Guid("8955d4a7-dc06-4c9c-8bc0-59368c0a04e0"), "6354 Alanna Village, Lake Fannie, Paraguay", new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Ameliorated scalable pricing structure", "WeimannBechtelarandBeatty42@gmail.com", "Weimann, Bechtelar and Beatty" },
                    { new Guid("8a89db25-9122-420e-b921-7c4ebfe2d12f"), "37641 Lexus Tunnel, East Amelie, Marshall Islands", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Integrated reciprocal leverage", "MillsKozeyandKing7@gmail.com", "Mills, Kozey and King" },
                    { new Guid("8ff64eaa-bd00-4ee1-8471-54242a8d3429"), "96302 Laurine Vista, New Jordiberg, Dominican Republic", new Guid("0926655a-2467-47c4-99a7-07769c3b6e08"), "Optional national customer loyalty", "RosenbaumBernhardandHartmann_Bashirian56@hotmail.com", "Rosenbaum, Bernhard and Hartmann" },
                    { new Guid("923fd550-1b86-426b-9314-10eb5be90177"), "947 Crooks Overpass, Myrnaberg, Somalia", new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Decentralized leading edge neural-net", "Heaney-OKon_Yost@gmail.com", "Heaney - O'Kon" },
                    { new Guid("9259fbab-2b76-4a49-858c-4e4e031c9093"), "70758 Madison Plaza, Ashleightown, Oman", new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Horizontal fresh-thinking circuit", "OKonInc_Schinner@yahoo.com", "O'Kon Inc" },
                    { new Guid("999a66fb-60b6-40bc-a5a3-b37441bfb789"), "4323 Davis Court, Laneyside, Saint Vincent and the Grenadines", new Guid("1b40d223-75e2-44f2-b03e-3a9ae1fb4203"), "Cloned holistic application", "Spencer-Pagac_Weimann@hotmail.com", "Spencer - Pagac" },
                    { new Guid("9b58e0e9-5c6d-4930-9644-c39dfa3e0a32"), "865 Trace Lodge, Lake Lola, Norfolk Island", new Guid("430171d8-9b2b-45ab-8c09-6c6365c2daac"), "Customizable discrete superstructure", "TorphyKlingandOkuneva.Stoltenberg@yahoo.com", "Torphy, Kling and Okuneva" },
                    { new Guid("a4ed2ec3-45e5-4de1-8f1c-d3ccc229fb3f"), "185 Kevon Corner, North Heloiseview, Liberia", new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Open-source web-enabled database", "Mraz-Mann_Abernathy17@hotmail.com", "Mraz - Mann" },
                    { new Guid("a9915dfd-6461-40c5-8b07-117055e19eb7"), "61054 Marie Dale, South Rasheed, Cook Islands", new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Enterprise-wide demand-driven moderator", "SchmittColeandKoelpin94@yahoo.com", "Schmitt, Cole and Koelpin" },
                    { new Guid("affe19f0-a5a4-4408-851b-6c3fe633e96d"), "7368 Lesch Corners, South Lilianport, Western Sahara", new Guid("6c59e9ad-3ceb-438c-a75b-7b10d1d23cf1"), "Business-focused multimedia pricing structure", "HettingerTreutelandGerhold.Schuppe@yahoo.com", "Hettinger, Treutel and Gerhold" },
                    { new Guid("b3429152-8d58-4321-bae5-f07f1d585973"), "23225 Tromp Walk, North Johanna, Brazil", new Guid("15c71f15-626d-4f49-938e-72759216f866"), "Visionary object-oriented product", "ZulaufInc.Grady87@yahoo.com", "Zulauf Inc" },
                    { new Guid("b7e88a7b-27c8-4528-8a97-2d44eee83446"), "69516 Myah Creek, Nicholausland, Guatemala", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Centralized methodical moderator", "Cummings-Hackett.Bechtelar53@yahoo.com", "Cummings - Hackett" },
                    { new Guid("b84a0387-291b-47df-b27d-d77cf8039999"), "94498 Reginald Stravenue, Elsaberg, Jordan", new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Integrated static service-desk", "RyanLLC_Beahan@yahoo.com", "Ryan LLC" },
                    { new Guid("c5d4d71f-2352-4165-8458-a8ac8f6811df"), "95344 Baby Mountain, Blickland, Bahrain", new Guid("99b8607f-1ad3-4015-aaca-d1e20ef0b072"), "Focused cohesive complexity", "GradyInc_Lind@yahoo.com", "Grady Inc" },
                    { new Guid("cae173d9-9301-49af-b01a-0e98afd4bd93"), "203 Nienow Tunnel, Haneborough, Isle of Man", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Team-oriented grid-enabled secured line", "Dicki-Bruen.Rice88@gmail.com", "Dicki - Bruen" },
                    { new Guid("cc1e1edd-5576-4f81-b7e7-893e49962abc"), "484 Lesch Corners, Joannehaven, Slovakia (Slovak Republic)", new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Object-based attitude-oriented groupware", "Spencer-Lockman_Price@hotmail.com", "Spencer - Lockman" },
                    { new Guid("d6a31f2b-45f0-46ef-8379-9e3750dc0be7"), "00891 DuBuque Canyon, Port Arlene, Somalia", new Guid("3c52d94b-0068-4af7-8024-ac337169933b"), "Optimized contextually-based forecast", "BraunInc_Stamm@gmail.com", "Braun Inc" },
                    { new Guid("e8547a7c-9360-43bd-9b28-a498f0acb496"), "092 Frederique Highway, West Taylorville, Luxembourg", new Guid("9ff1e265-4e95-4d15-b719-cf48e4d07e5a"), "Fundamental hybrid Graphic Interface", "GorczanySatterfieldandStrosin.Sawayn@hotmail.com", "Gorczany, Satterfield and Strosin" },
                    { new Guid("ee618093-84f0-4355-964f-f95f6f95ed1f"), "3309 Smith Village, Lemuelton, Tunisia", new Guid("b98f1e5d-346c-4ec9-a2a7-f3b27e24ad6a"), "Quality-focused solution-oriented database", "LemkeLLC59@gmail.com", "Lemke LLC" },
                    { new Guid("fccd7c1c-74ce-4a20-b620-3f1f3d766f2c"), "6580 Keely Ridges, Port Sisterton, Bouvet Island (Bouvetoya)", new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Progressive clear-thinking middleware", "SchneiderandSons.Greenholt61@yahoo.com", "Schneider and Sons" },
                    { new Guid("fdd7e026-301f-4866-a105-f5f41c73a4c6"), "9697 Akeem Rue, O'Haramouth, Costa Rica", new Guid("4d1755c7-b19a-41f7-abe1-04273d90163a"), "Cross-group user-facing complexity", "SchultzLLC_Bernier44@yahoo.com", "Schultz LLC" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Countries-table_Title",
                table: "Countries-table",
                column: "Title",
                unique: true);
        }
    }
}
