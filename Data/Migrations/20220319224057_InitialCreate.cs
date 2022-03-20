using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Resume",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resume", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Techniques",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Techniques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Techniques_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgSrc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeId = table.Column<int>(type: "int", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artists_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artists_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Milestone",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResumeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Milestone", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Milestone_Resume_ResumeId",
                        column: x => x.ResumeId,
                        principalTable: "Resume",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artworks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgSource = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artworks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artworks_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesArtists",
                columns: table => new
                {
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesArtists", x => new { x.ArtistId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoriesArtists_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesArtists_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SocialMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtistId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SocialMedia_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesArtwork",
                columns: table => new
                {
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesArtwork", x => new { x.ArtworkId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CategoriesArtwork_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoriesArtwork_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hashtag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtworkId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hashtag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hashtag_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TechniquesArtwork",
                columns: table => new
                {
                    ArtworkId = table.Column<int>(type: "int", nullable: false),
                    TechniqueId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechniquesArtwork", x => new { x.ArtworkId, x.TechniqueId });
                    table.ForeignKey(
                        name: "FK_TechniquesArtwork_Artworks_ArtworkId",
                        column: x => x.ArtworkId,
                        principalTable: "Artworks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechniquesArtwork_Techniques_TechniqueId",
                        column: x => x.TechniqueId,
                        principalTable: "Techniques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Dziedzina sztuki wizualnej.", "Malarstwo" },
                    { 2, "Dziedzina sztuki wizualnej.", "Grafika" },
                    { 3, "Dziedzina sztuki wizualnej.", "Rzeźba" },
                    { 4, "Dziedzina sztuki wizualnej.", "Rysunek" },
                    { 5, "Dziedzina sztuki wizualnej.", "Inne" }
                });

            migrationBuilder.InsertData(
                table: "Location",
                columns: new[] { "Id", "City", "Country" },
                values: new object[,]
                {
                    { 1, "Malaga", "Hiszpania" },
                    { 2, "Kraków", "Polska" },
                    { 3, "Warszawa", "Polska" },
                    { 4, "Wrocław", "Polska" },
                    { 5, "Poznań", "Polska" },
                    { 6, "Łódź", "Polska" },
                    { 7, "Gdańsk", "Polska" }
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "Description", "Email", "ImgSrc", "LocationId", "Name", "Phone", "ResumeId" },
                values: new object[,]
                {
                    { 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed posuere nisl tristique purus volutpat sagittis. Cras suscipit placerat varius. Aenean fermentum metus ut iaculis ultrices. Nullam semper sollicitudin faucibus. Nam vel bibendum justo. Cras mollis ex odio, at iaculis nunc iaculis eget. Nullam volutpat bibendum tincidunt. Vestibulum aliquam risus quis hendrerit tempor. Suspendisse ut ex in arcu convallis gravida. In venenatis feugiat posuere. Duis ac aliquam odio. Vestibulum sit amet volutpat erat, in elementum tortor. Phasellus malesuada ipsum id velit viverra elementum. Nulla eleifend sem sed nunc facilisis venenatis. Cras pellentesque quam sit amet urna convallis scelerisque.", "beksinski-zdzislaw@xxx.com", "https://lh3.googleusercontent.com/jJlkVuK17yo7d276rsJXENi73l1TGhPyfJaGbf1Ndk83kbI5gZbMfPIlnnmR1fjVTmU5MEJQ0smqg1LJt5VLFPH3NVLieeQkpjrtdIKmPKNYzyucf24puAzAVIQZfbNzEk1yvoBV7L3VDWhsxXb65lxYa449RT3rkghD8d54OJARr4kYLeGjQu2TvLj85-BCq_LR8hn3Uk1v_gHNWFj_PgGfiG6Jq3IapONqroJFO4ng-XSOLj4EEIMzaan3vNaHhn8hBLbc8Q6Tkkvx6Olt9FJNbVebahI5bU7Z9SP-DznGUiFYV9Gim4TO4HCf2pyPVzxIQ7spEtGl96vanwL_RaRul3lvRJHsT68zv_ou2H8bLZGZPifdXRNBnfR7BmLJOnV8vL9Hu-efx9VMLTl05O3mekQ3eNfeOz-WDAtMDSinYnLkjmq5SBjesXFMj6PZFg41qGsfX6Bfi2gbwuMJBVXDkQsIyZoU7egfRJw96ziBrp9_MED0m1PD2eqEqbEoTXMFLnmnaJiV8lKfDKp9RjNP6X1A-htynZEutJDHnLH9EZUbD5z1mpx6we5NxLISoqNsyOA7fVgLWH11s39DK3Ru0fLsJOs_Lerkb0qB257HYDzcmDa7zzXmfWQy5485U1K2quLFdiPMtKP1-q_fPqDYbkhRtMuEjRPa-b7TuZhRP_ebJdmoMBRoFrRYvFzeiOhkfCJAbDUl5HRPKEpcV0npnZwI8emiFj3xAlvSU-hmi1vgZ63UDIF9_mKNF0pEx1RrS7Qs92b07LzvsirzWtvw3KB1VSKTSBJP=w819-h649-no?authuser=0", 3, "Zdzisław Beksiński", null, null },
                    { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed posuere nisl tristique purus volutpat sagittis. Cras suscipit placerat varius. Aenean fermentum metus ut iaculis ultrices. Nullam semper sollicitudin faucibus. Nam vel bibendum justo. Cras mollis ex odio, at iaculis nunc iaculis eget. Nullam volutpat bibendum tincidunt. Vestibulum aliquam risus quis hendrerit tempor. Suspendisse ut ex in arcu convallis gravida. In venenatis feugiat posuere. Duis ac aliquam odio. Vestibulum sit amet volutpat erat, in elementum tortor. Phasellus malesuada ipsum id velit viverra elementum. Nulla eleifend sem sed nunc facilisis venenatis. Cras pellentesque quam sit amet urna convallis scelerisque.", "picasso-pablo@xxx.com", "https://lh3.googleusercontent.com/TmD9WKyVaYAeahGuyOu4Dri9G6bPGBCX1cECtvv1Re9Wwkq-I9dFravaTqvqowg0XFQ6o2gFoZBRMfGbqmiD9HUAajcSnw1r1ZPuB86roSZ-bJUzJIe7he3S8fonHXrlqgBHG1dT-B75hYxouqAO0OQ8K8rpSAtU4_0aR31nMvilf5-OYPQAWYdk0HQ7prFez5BJAQqQfQ_2OETZZTlnSrl69178R1hnx4h5F0izDxCq9-BXneYjz0Epa6fU1b7FcuZEvUQgmXzlm3mfywn6O2DfsFijw4aQZ0gzc4JXO5dfx7lKA-ncb69MxL7-hHOOaAMosYvnGhU6XCJAIgxT_XkzRJRQ19yP1t4UKF5fvkD76XMPF6Qng7LSnzFGEjyBF5LVQG5OmJAB3Nqweq8J-ac-GD0N-3WKFn9ofZazUNdqbUe7cDzuRaagsY0UipeF8yNh7jVLZdgMOxn5UaRTQqTjfZ43Y9bJfxTZJFDxJT3vJ-0q3_LhHBze63dwoqupZTMttcVpdmU695V5Tm_JsQfuTBtfyOANIByZ_fLd-43FPvvMBPDlKKVh5mBgF1xz8L1-MO2nETJbnDNg8xcw5nEY4Idc7Q6EXOXfkTpLcBTHKcpHgbiruQGuRUNLJe0g_kOeQr7OR-lokrI_aoTDqNBQjnZrms7WZ2RGI0WWexdLeF_280iVN5B735OnhfRVuiVDPJ2qtt3M_DqiI0yrlatNzO9FkR2hV8eK5JP6WbvF9LllkXiPMwmifvYw6GsoJAtbT6Ah6zNsi0aY7Cm02cizTjNo3RnuQVi_=w752-h830-no?authuser=0", 1, "Pablo Picasso", null, null },
                    { 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed posuere nisl tristique purus volutpat sagittis. Cras suscipit placerat varius. Aenean fermentum metus ut iaculis ultrices. Nullam semper sollicitudin faucibus. Nam vel bibendum justo. Cras mollis ex odio, at iaculis nunc iaculis eget. Nullam volutpat bibendum tincidunt. Vestibulum aliquam risus quis hendrerit tempor. Suspendisse ut ex in arcu convallis gravida. In venenatis feugiat posuere. Duis ac aliquam odio. Vestibulum sit amet volutpat erat, in elementum tortor. Phasellus malesuada ipsum id velit viverra elementum. Nulla eleifend sem sed nunc facilisis venenatis. Cras pellentesque quam sit amet urna convallis scelerisque.", "panek-jerzy@xxx.com", "https://lh3.googleusercontent.com/ccL6CWavQz5f-p7P2n2Jxv5EUiGvKxDFoU5pAlqhYJQ-yG8gv1sFq3zzECP-_QOBDuEgLrlfKA6ZFs1ezDy7oWDHv7gt8cXkGBOJDJJ5gzNvvU4LqmLHXPFxzEPTYmKo6yv8vaJAJdukr7CQ7MGkxZ0QFcVntEKoyz8rzQlqd_Smh6sUFgwFolSc2_Sz3Kr5wShkezcVupRQxo40FZjWixFIs3-Jk5-GsARy_nhVqmCYnws1CMdD1wEUzztE-kI2LDjxRuKAfo0WorzxUFZXyrnGKklmbawpzgchwTlaD2UPKO04dzSe4kt8iP0nWCNLgdFEEvm4g4RfcO8iWhbE-liTek7aBA1JHXamElTFNL5X20BXkFHRQjH9w55AdIGJ4r0bsSLU-isEeQoyLgn4Oz4V6_cpJjfnLAerBbjxDotjiwvhzrUAhrkha1vqdWJK94vekotQDFlWOIGLqliPvB7vPIcZT065jNi1oxZ_mXnxqr1yjtsz438peZelAA7dlAe7YVWUHYvqIR6Z6kPTMfxL5r1lBATslsAgVGfB3oyvVC0ZUv659yWF61mY8CPzJa3PKOtowIGPJwJAGVQQR_G_K5iz3PFbhRlgL-1z6vT2AEoN_YHy8L2FxKGOqyxWour4xau4UL21wvBY1NBEX4iGAfBKTytSacDZng2NH5Y3vtQAwA_-Ii4X7auzfIPrl7fRE5f8-ako2S6qieT87JmIBJmTDGMFzPwJJR-_DBYsXSHSiY2eqkPLhquiNg2QyDz5lB3tuqdJfgBPUjekssjY9pasFPBvB6TP=w690-h388-no?authuser=0", 2, "Jerzy Panek", null, null }
                });

            migrationBuilder.InsertData(
                table: "Techniques",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 21, 4, "Technika rysunku", "Inne" },
                    { 20, 4, "Technika rysunku", "Tusz" },
                    { 19, 4, "Technika rysunku", "Kreda" },
                    { 18, 4, "Technika rysunku", "Ołówek" },
                    { 17, 4, "Technika rysunku", "Węgiel" },
                    { 16, 3, "Technika rzeźbiarska", "Inne" },
                    { 15, 3, "Technika rzeźbiarska", "Metal" },
                    { 14, 3, "Technika rzeźbiarska", "Kamień" },
                    { 13, 3, "Technika rzeźbiarska", "Drewno" },
                    { 12, 2, "Technika grafiki warsztatowej", "Litografia" },
                    { 10, 2, "Technika grafiki warsztatowej", "Miedzioryt" },
                    { 9, 2, "Technika grafiki warsztatowej", "Drzeworyt" },
                    { 8, 2, "Technika grafiki warsztatowej", "Sucha igła" },
                    { 7, 2, "Technika grafiki warsztatowej", "Akwaforta" },
                    { 6, 2, "Technika grafiki warsztatowej", "Akwatinta" },
                    { 5, 1, "Technika malarska", "Pastele" },
                    { 4, 1, "Technika malarska", "Tempera" },
                    { 3, 1, "Technika malarska", "Akryl" },
                    { 2, 1, "Technika malarska", "Akwarela" },
                    { 11, 2, "Technika grafiki warsztatowej", "Linoryt" },
                    { 1, 1, "Technika malarska", "Olej" }
                });

            migrationBuilder.InsertData(
                table: "Artworks",
                columns: new[] { "Id", "ArtistId", "Description", "ImgSource", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Pablo picasso painting", "https://lh3.googleusercontent.com/BWlHe0S5T4abGwk2emrtxCDIBjHYOfG5kPhN6QsnaTf-pCxyT7FYTOPJUPuxKpqLg4hnv4-YuqO6XTUH-G97Jrmpdpr0yeLMAO6HuE2sTJCLDn2jLDgj0SdGMh4UF7paZu3m1E8xh1WLVvxNw0y1O3YC9QE713Zi-_ntaD-v6xqWTh_XArAC6Q7hvZPCxm_L7aAmABlGWVpNn8s2n_bwZgPQvlUW4K_gHEpiopRN-AlT1K_PImkte4elFCJ6AJMqXB3KIQSCJHiw7g-Dn_ILGY3KpRJhoUU_zZKqFq5AUDtp07zbcNpCFyufwgA3l_f4grFP1rIGsUbaeBZab7tdagg0BH-RrHZGrmXEzIneYtBgN0TMxrCeHfwgtxakXEPUwmbX3fz3rYC2ZgolNAjJjYSekV5ElYcPBEWXTh8umOXNUqABr0iak91yoO2cL-Bx2WcdWYz1x4TCJVT3QH9u9zD4p3JaDFo65tyWIApvIVV5IKjuf5iOR2rc3IrY0gGKvb8TFsQn57_xIBCg8ClDtm2UpFMkEyWJDVdwUN46JgVkkjbSKODC7VnGhlJ47zM54YbzdIzVSoMmKu6xjXcAubpCe6FxHIkOU1jsKMuBzxNcmpkVigho2ITJToEAvdtMnqo58EJxc9LhIr_q_5Yi3rNV96_-Shs4I7nSrE9AHv-zQIAXkPNz5cJXGG6xCvJ6p5DDbPglArPO6IYN6p2ObRCpwJv48KFyY8gCrLbs9-1wwSZ4UfpBqaNiV65U0ZvKuK9ZAdmxqiw9RwJPY9DcFWD8Sp7eUcJ8nsFm=w541-h717-no?authuser=0", "Blue nude" },
                    { 2, 1, "Pablo picasso painting", "https://lh3.googleusercontent.com/OF5oCENl8mbGTyw10GgWxvbYDaeiIbam9Ci9SsRmc33U9jD2OExfw_amdv-uHZw6__tkKhKqh9z-Evn4mQx1NtZxSyXMYrw_0z1Flbf3TTGThKh9QTkC4wdvvWo3vWX0vOGzV6fSfpEIh_73TNShBDpDaiyQ1WyKq4e_phGX2PQT6le6IyOkycD7aa9rVVbvw0VRK6OsihNVoJgWjti6M3AA_RiMca94tVu1XjFuOBW-GPi8wcDaPqUT447Q3qJVb7HgqQI1eDESRxVILm_rTfiSKy_beQyMSNcWwG6f1MYT-Z0Co5kynZN6DDKDSmpls0nXlLjKJQc0fGdDngI6lCXTEbdoR8FakLMLNIzEjr7Ypy0OBd50V-2nvroidl35xUCva-7cHIGZ1SXc46jS0LMIxM5jPT-5-9oDkVz_hvhccTJMRP21E4R32XsnWovp-k7o9_-8GbIIA6yK859ZDA-xTzpEVRO6HcQ34B7iach1L1_s-16MBjwdod9JuDWPZVr17hI9wzvWG3eLgcKFmDtrWS2P7rQQFE6oH-m3CGQ8dZXsycaTBri42lWcDa3-bMHV44s5sjyEKwz5vPVC1bKTsOGwom5uijeygBWJpMIACybC1f7wPzQ-ME1tjN15AMoxj4CL6lKLMGEAYWkN9-vexWzrrt1bbmeTDxI2bqAQwI86RgL7DYfJ4Dw2RV40a81p-ozy8cumRC0cGuDBkqDb4AmX1uLenaU3k3TIPC62-UTm4-MrKbBttkyItoD681g7ekQcpeuJ1MCGlmXnrlAET1hx2O2UePub=w650-h805-no?authuser=0", "Girl before a mirror" },
                    { 3, 1, "Pablo picasso painting", "https://lh3.googleusercontent.com/CTiBgzayuRBCJlSaCIY6tYjYWNM4JmeY3v4kQ4hHqvHtiXqmSbPQd8fZkRQEcelA8YzcHaw80-WsRWERrbgd5j-o9dE05O3NYs_XFPi9-dvzTfYGv26qhk6Iv3uY7JzrB_-eS-_rEcRMsinPPVAMn7mEx_E_0pV5vGgiXCjV-E-lOCFgxQyD1cz7N16yWO9vflZ16ioa-0oYO_Ej-TmkFn4m7K8Dg-_n1mBYl-WTM8sLPOGW4nqNewMtfrJ3fuZMgsQPPWlgBg-aI2VpZqRLcWHtTHSMMPpgywv_fvmsbxz0Ze93EmjBWQAL_i4XmNG07Ns-_Zu9URzjO64SLIbCu922OdD0w7S1TI7VEJ7FEy7evTHZPp7pOpndFWokfOAdBVz8NTNLAQ5ajqre1YaBO-CzptLK0VtS6yp-FDNHnomFFC64dFGl_39a2MqFJKvj23eq4_5lc6UcSR1YJbTb9PedGinrH037QgmGV0NVG3sz9Mcj6VGiXILqUkNV6XO2RpT_DvB9C-BRjFhoBmviFbPFZ_ooZ5Syrm8yIDJIlmVemWTxqhKHSUKTGO2jjIIP0q_TP6GLqvYwB7Aqx5YH38EObfyPCyq6tpy1eRY8S0kiVrYDT3WnagHK8okSDhHqQaY57wdFEW2gqt7trH1QT4a-20oPyQ-biXU5Fgs1kO85hV5qTiTJ_CfQajWKG8XVc1UxTiNI9kqmFyUWvvMoM8cJD7sgnamS7GRMLeWSyO_8i-suVVpCcqWAfXt-IaBv5lGaG68VITdl6qqsKUHwPIdON0Qm0dwRD0fa=w900-h707-no?authuser=0", "Bullfight III" },
                    { 4, 1, "Pablo picasso painting", "https://lh3.googleusercontent.com/fYN_MLVZ3IO-yyfHsWRk7rtIh9zFYO4_GmHESLqY8-u0WIGbQXTHxKjDwTq4EXmN0q-xsfuTAlfX5Wr7xYkBUUc50zLOYO6dJdvJHlED7SU255bKeqZwvHthvmR-wWg3cU5J02j_jTqrkIdyKOtO-wCzCAKNHtiyLUrbhPJSzQalm7-ZI84kxHJwj1Ac5U0mozfJQ7-852lpAEhDR2VEriBDXzA6lzQK2yFpV-KnQ9gHXPOPgDLJwtezsREArOX_F4XLgjR0qol9biC6jzYldXpqFWbQ0GiGB4ohjsf8Qrujuzd1yDygl2l5dg-a6lqDdBWRVDZBTipnpHZq3Ig2ufjJrFm1_9-ksL_dZg46a0Jg85GQphLQBV_p3PWOuq6CzYU1yyxK8p6SsQpZ9TA8JII-XcF9e2V5NuykcEAuUgnDV6qHhVXkdL2JiE0K0QLDfLFbS6Y-QqFwjawD-eXboKwgJlNbzgG__DzAcRc3wSdoWzJ8c13YLp56ejoiWiZUrZAKjBlh1oNcbvaNHpUkM6oHZpSKcsyrOVwHaWt19ANUPnNbHbshM_UWg7WslvHT4px7LzXB322JzhL8ujp7U6eUIDrZQdLyXZqNhjuwgLqxsw6iOdEBxzAwG66qVUBC4-N1y3ovB0RW7ku5PUFsBlTFhh3Bedptsp6EMj2nOceW1-P2iUmknbSFzwH74YaXzaaglLxncI73hDY3d-kM-8AargfLW3uDNzk_kuyIDfWSM-BDYp08s1UyvNQZytTMPjkGUALn1uAt0bDcGEJ85UawWz8O029TqXeG=w600-h464-no?authuser=0", "Dog" },
                    { 5, 2, "Grafika Jerzy Panek", "https://lh3.googleusercontent.com/yCrplNvAr6Vueo1Fu7Bhc4lFUkiJcEQl-9PC46luUDGe-Ke0nX3j9pO7Uyum3DaAFhoWwVMuAD0VEtZIZIhesBA-SgQx1pzgF1CDAxB-XLoA7ZdlNEH0VyWGML7BDmUdVYGcX20fP_L_qiHFI1uVdsAlzFSrMyd8Wh68-rycaAdJF0ItxiaU8-CLFPO25UBUbFFRc60DRseUKxSP3funsemF-QLKP3ytKdxqb_S1xOLb8gYy7BVZGQWmmewHDIISDIVuK9ggg_z1ybl0JYecLkwuZlIJmFpyD43BGF8YmpVAnVYDQLpNZqoj-XkqSOefmftxLGTirfo3xtj9rUgS3aBU0272_tM2TjvnNhFe35NInufZnngH7XsEyrBfOf88_3mL0lP6xQ6xKecoIE9k_1DFxcynWRXxOtviDkhgbMYjxhxROdtMysaL3VsTcbnBUa95p5cO-Ez1xDfW-KRK8_Ap-Doooq6g615hp2u4GPZ-yNywWgzCQVReksN8rLd4k5VxajH63DE02Z52B34hCKQOiJIDa3UQrAuqzKrGGIEpHstWYHFrOzQ8pNEaHZhgWp0Jn9gnKtwvGAwc8htnegVVGlrSKzl1v_h5sEkSgi0xuZtbHWdKUC_5N9We_0eZrY3vnvv3rPKqiMUGlObEOUJoqtnPN5LM9qNwHPJxDQ2QXu6Jd4eQzzZmmfrDnFQRm8S9ck0asEt0JJqGxGRgLAY2xy7ksYctDLt-4AE8-LEzIsA8aBG41Wa-VXkL9ExcE_stzzFoYWieX7lj481naG5VEEICKTCe2i4C=w580-h802-no?authuser=0", "Pasterka" },
                    { 6, 2, "Grafika Jerzy Panek", "https://lh3.googleusercontent.com/0YAl8IEdWAb5RVU4RClLpRKqHcTkpXjgf0IhOlqPZ69TWrBjQVv7JaGGUafrXq2ztUjLhGVsNbuelXT1ibp0ntits4_bVzDRu5Yn19dBvs0ItKYxPHC8VlgHD9Co2Ck7pxkZW9NXDy1tnYsMuOupGQ4Vucg8Gsu0DkXfzHP_i0TOOMjPymoQ9gzLT2nyn5sjhYKz0jFUEau-JlhbzbPgwwbFsYT9M9YOJXqkV35XyeLbRM2wiNNvfzmAy98ppDyP7guZ5poiTtNLrXak6VWG21RC9N48X3uiH66sIaz2LAXOFZatYgF73qXfXryAZYCCpVgrPkwK2CKeYQqj6NxZINkuVIEvpqgjnrmr7aOv8db9XTjwNX_rtnf_0j2o_izH9CdnFewwhiq-tCdU1aXNMEgpX-DurREXzUpU7VDFDkYw-AdXGb8op2updSXuy8rMCECkP-3dQjshfSZAUIZpu85_UzdYy64rlVHVXVCGtBIF6LZQf7JnkhTr8q3U90mj8JMUui8XYJasbk2Bz8CImCnmWCVTLqsmKc0tedWUjg-Vpkou_n8wJQbCH3FYoXATaBq-qicG3nkXeKbUmqZIWf7a8zRY0jbgcg78xtao0wwe7rfOTvaT4CjUkVCRkZ7O7x6_-BluqmjRKbFmQl8sB573vXIUXDrP169f7JN61Axqh7pfvAGdnILL4TN7ggQknWptlDncDzaEuEWGbbGVHBHm0P7v9TZCZ5B_vp1unqWehI3DGFESIv2SfWT5uJ4GW9I0rIpXaN7EeeAH9r1Sw5A4ihykIODjXEkQ=w860-h722-no?authuser=0", "Biały Koń I" }
                });

            migrationBuilder.InsertData(
                table: "CategoriesArtwork",
                columns: new[] { "ArtworkId", "CategoryId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 },
                    { 5, 2, 5 },
                    { 6, 2, 6 }
                });

            migrationBuilder.InsertData(
                table: "TechniquesArtwork",
                columns: new[] { "ArtworkId", "TechniqueId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 20, 3 },
                    { 4, 20, 4 },
                    { 5, 9, 5 },
                    { 6, 9, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artists_LocationId",
                table: "Artists",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Artists_ResumeId",
                table: "Artists",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_ArtistId",
                table: "Artworks",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesArtists_CategoryId",
                table: "CategoriesArtists",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoriesArtwork_CategoryId",
                table: "CategoriesArtwork",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Hashtag_ArtworkId",
                table: "Hashtag",
                column: "ArtworkId");

            migrationBuilder.CreateIndex(
                name: "IX_Milestone_ResumeId",
                table: "Milestone",
                column: "ResumeId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialMedia_ArtistId",
                table: "SocialMedia",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Techniques_CategoryId",
                table: "Techniques",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TechniquesArtwork_TechniqueId",
                table: "TechniquesArtwork",
                column: "TechniqueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoriesArtists");

            migrationBuilder.DropTable(
                name: "CategoriesArtwork");

            migrationBuilder.DropTable(
                name: "Hashtag");

            migrationBuilder.DropTable(
                name: "Milestone");

            migrationBuilder.DropTable(
                name: "SocialMedia");

            migrationBuilder.DropTable(
                name: "TechniquesArtwork");

            migrationBuilder.DropTable(
                name: "Artworks");

            migrationBuilder.DropTable(
                name: "Techniques");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Resume");
        }
    }
}
