using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configurations
{
    public class ArtworkConfiguration: IEntityTypeConfiguration<Artwork>
    {
        public void Configure(EntityTypeBuilder<Artwork> builder)
        {
            builder.HasData(
                new Artwork
                {
                    Id = 1,
                    ArtistId = 1,
                    Name = "Blue nude",
                    Description = "Pablo picasso painting",
                    ImgSource = "https://lh3.googleusercontent.com/BWlHe0S5T4abGwk2emrtxCDIBjHYOfG5kPhN6QsnaTf-pCxyT7FYTOPJUPuxKpqLg4hnv4-YuqO6XTUH-G97Jrmpdpr0yeLMAO6HuE2sTJCLDn2jLDgj0SdGMh4UF7paZu3m1E8xh1WLVvxNw0y1O3YC9QE713Zi-_ntaD-v6xqWTh_XArAC6Q7hvZPCxm_L7aAmABlGWVpNn8s2n_bwZgPQvlUW4K_gHEpiopRN-AlT1K_PImkte4elFCJ6AJMqXB3KIQSCJHiw7g-Dn_ILGY3KpRJhoUU_zZKqFq5AUDtp07zbcNpCFyufwgA3l_f4grFP1rIGsUbaeBZab7tdagg0BH-RrHZGrmXEzIneYtBgN0TMxrCeHfwgtxakXEPUwmbX3fz3rYC2ZgolNAjJjYSekV5ElYcPBEWXTh8umOXNUqABr0iak91yoO2cL-Bx2WcdWYz1x4TCJVT3QH9u9zD4p3JaDFo65tyWIApvIVV5IKjuf5iOR2rc3IrY0gGKvb8TFsQn57_xIBCg8ClDtm2UpFMkEyWJDVdwUN46JgVkkjbSKODC7VnGhlJ47zM54YbzdIzVSoMmKu6xjXcAubpCe6FxHIkOU1jsKMuBzxNcmpkVigho2ITJToEAvdtMnqo58EJxc9LhIr_q_5Yi3rNV96_-Shs4I7nSrE9AHv-zQIAXkPNz5cJXGG6xCvJ6p5DDbPglArPO6IYN6p2ObRCpwJv48KFyY8gCrLbs9-1wwSZ4UfpBqaNiV65U0ZvKuK9ZAdmxqiw9RwJPY9DcFWD8Sp7eUcJ8nsFm=w541-h717-no?authuser=0"
                },
                new Artwork
                {
                    Id = 2,
                    ArtistId = 1,
                    Name = "Girl before a mirror",
                    Description = "Pablo picasso painting",
                    ImgSource = "https://lh3.googleusercontent.com/OF5oCENl8mbGTyw10GgWxvbYDaeiIbam9Ci9SsRmc33U9jD2OExfw_amdv-uHZw6__tkKhKqh9z-Evn4mQx1NtZxSyXMYrw_0z1Flbf3TTGThKh9QTkC4wdvvWo3vWX0vOGzV6fSfpEIh_73TNShBDpDaiyQ1WyKq4e_phGX2PQT6le6IyOkycD7aa9rVVbvw0VRK6OsihNVoJgWjti6M3AA_RiMca94tVu1XjFuOBW-GPi8wcDaPqUT447Q3qJVb7HgqQI1eDESRxVILm_rTfiSKy_beQyMSNcWwG6f1MYT-Z0Co5kynZN6DDKDSmpls0nXlLjKJQc0fGdDngI6lCXTEbdoR8FakLMLNIzEjr7Ypy0OBd50V-2nvroidl35xUCva-7cHIGZ1SXc46jS0LMIxM5jPT-5-9oDkVz_hvhccTJMRP21E4R32XsnWovp-k7o9_-8GbIIA6yK859ZDA-xTzpEVRO6HcQ34B7iach1L1_s-16MBjwdod9JuDWPZVr17hI9wzvWG3eLgcKFmDtrWS2P7rQQFE6oH-m3CGQ8dZXsycaTBri42lWcDa3-bMHV44s5sjyEKwz5vPVC1bKTsOGwom5uijeygBWJpMIACybC1f7wPzQ-ME1tjN15AMoxj4CL6lKLMGEAYWkN9-vexWzrrt1bbmeTDxI2bqAQwI86RgL7DYfJ4Dw2RV40a81p-ozy8cumRC0cGuDBkqDb4AmX1uLenaU3k3TIPC62-UTm4-MrKbBttkyItoD681g7ekQcpeuJ1MCGlmXnrlAET1hx2O2UePub=w650-h805-no?authuser=0"
                },
                new Artwork
                {
                    Id = 3,
                    ArtistId = 1,
                    Name = "Bullfight III",
                    Description = "Pablo picasso painting",
                    ImgSource = "https://lh3.googleusercontent.com/CTiBgzayuRBCJlSaCIY6tYjYWNM4JmeY3v4kQ4hHqvHtiXqmSbPQd8fZkRQEcelA8YzcHaw80-WsRWERrbgd5j-o9dE05O3NYs_XFPi9-dvzTfYGv26qhk6Iv3uY7JzrB_-eS-_rEcRMsinPPVAMn7mEx_E_0pV5vGgiXCjV-E-lOCFgxQyD1cz7N16yWO9vflZ16ioa-0oYO_Ej-TmkFn4m7K8Dg-_n1mBYl-WTM8sLPOGW4nqNewMtfrJ3fuZMgsQPPWlgBg-aI2VpZqRLcWHtTHSMMPpgywv_fvmsbxz0Ze93EmjBWQAL_i4XmNG07Ns-_Zu9URzjO64SLIbCu922OdD0w7S1TI7VEJ7FEy7evTHZPp7pOpndFWokfOAdBVz8NTNLAQ5ajqre1YaBO-CzptLK0VtS6yp-FDNHnomFFC64dFGl_39a2MqFJKvj23eq4_5lc6UcSR1YJbTb9PedGinrH037QgmGV0NVG3sz9Mcj6VGiXILqUkNV6XO2RpT_DvB9C-BRjFhoBmviFbPFZ_ooZ5Syrm8yIDJIlmVemWTxqhKHSUKTGO2jjIIP0q_TP6GLqvYwB7Aqx5YH38EObfyPCyq6tpy1eRY8S0kiVrYDT3WnagHK8okSDhHqQaY57wdFEW2gqt7trH1QT4a-20oPyQ-biXU5Fgs1kO85hV5qTiTJ_CfQajWKG8XVc1UxTiNI9kqmFyUWvvMoM8cJD7sgnamS7GRMLeWSyO_8i-suVVpCcqWAfXt-IaBv5lGaG68VITdl6qqsKUHwPIdON0Qm0dwRD0fa=w900-h707-no?authuser=0"
                },

                new Artwork
                {
                    Id = 4,
                    ArtistId = 1,
                    Name = "Dog",
                    Description = "Pablo picasso painting",
                    ImgSource = "https://lh3.googleusercontent.com/fYN_MLVZ3IO-yyfHsWRk7rtIh9zFYO4_GmHESLqY8-u0WIGbQXTHxKjDwTq4EXmN0q-xsfuTAlfX5Wr7xYkBUUc50zLOYO6dJdvJHlED7SU255bKeqZwvHthvmR-wWg3cU5J02j_jTqrkIdyKOtO-wCzCAKNHtiyLUrbhPJSzQalm7-ZI84kxHJwj1Ac5U0mozfJQ7-852lpAEhDR2VEriBDXzA6lzQK2yFpV-KnQ9gHXPOPgDLJwtezsREArOX_F4XLgjR0qol9biC6jzYldXpqFWbQ0GiGB4ohjsf8Qrujuzd1yDygl2l5dg-a6lqDdBWRVDZBTipnpHZq3Ig2ufjJrFm1_9-ksL_dZg46a0Jg85GQphLQBV_p3PWOuq6CzYU1yyxK8p6SsQpZ9TA8JII-XcF9e2V5NuykcEAuUgnDV6qHhVXkdL2JiE0K0QLDfLFbS6Y-QqFwjawD-eXboKwgJlNbzgG__DzAcRc3wSdoWzJ8c13YLp56ejoiWiZUrZAKjBlh1oNcbvaNHpUkM6oHZpSKcsyrOVwHaWt19ANUPnNbHbshM_UWg7WslvHT4px7LzXB322JzhL8ujp7U6eUIDrZQdLyXZqNhjuwgLqxsw6iOdEBxzAwG66qVUBC4-N1y3ovB0RW7ku5PUFsBlTFhh3Bedptsp6EMj2nOceW1-P2iUmknbSFzwH74YaXzaaglLxncI73hDY3d-kM-8AargfLW3uDNzk_kuyIDfWSM-BDYp08s1UyvNQZytTMPjkGUALn1uAt0bDcGEJ85UawWz8O029TqXeG=w600-h464-no?authuser=0"
                },

                new Artwork
                {
                    Id = 5,
                    ArtistId = 2,
                    Name = "Pasterka",
                    Description = "Grafika Jerzy Panek",
                    ImgSource = "https://lh3.googleusercontent.com/yCrplNvAr6Vueo1Fu7Bhc4lFUkiJcEQl-9PC46luUDGe-Ke0nX3j9pO7Uyum3DaAFhoWwVMuAD0VEtZIZIhesBA-SgQx1pzgF1CDAxB-XLoA7ZdlNEH0VyWGML7BDmUdVYGcX20fP_L_qiHFI1uVdsAlzFSrMyd8Wh68-rycaAdJF0ItxiaU8-CLFPO25UBUbFFRc60DRseUKxSP3funsemF-QLKP3ytKdxqb_S1xOLb8gYy7BVZGQWmmewHDIISDIVuK9ggg_z1ybl0JYecLkwuZlIJmFpyD43BGF8YmpVAnVYDQLpNZqoj-XkqSOefmftxLGTirfo3xtj9rUgS3aBU0272_tM2TjvnNhFe35NInufZnngH7XsEyrBfOf88_3mL0lP6xQ6xKecoIE9k_1DFxcynWRXxOtviDkhgbMYjxhxROdtMysaL3VsTcbnBUa95p5cO-Ez1xDfW-KRK8_Ap-Doooq6g615hp2u4GPZ-yNywWgzCQVReksN8rLd4k5VxajH63DE02Z52B34hCKQOiJIDa3UQrAuqzKrGGIEpHstWYHFrOzQ8pNEaHZhgWp0Jn9gnKtwvGAwc8htnegVVGlrSKzl1v_h5sEkSgi0xuZtbHWdKUC_5N9We_0eZrY3vnvv3rPKqiMUGlObEOUJoqtnPN5LM9qNwHPJxDQ2QXu6Jd4eQzzZmmfrDnFQRm8S9ck0asEt0JJqGxGRgLAY2xy7ksYctDLt-4AE8-LEzIsA8aBG41Wa-VXkL9ExcE_stzzFoYWieX7lj481naG5VEEICKTCe2i4C=w580-h802-no?authuser=0"
                },
                 new Artwork
                 {
                     Id = 6,
                     ArtistId = 2,
                     Name = "Biały Koń I",
                     Description = "Grafika Jerzy Panek",
                     ImgSource = "https://lh3.googleusercontent.com/0YAl8IEdWAb5RVU4RClLpRKqHcTkpXjgf0IhOlqPZ69TWrBjQVv7JaGGUafrXq2ztUjLhGVsNbuelXT1ibp0ntits4_bVzDRu5Yn19dBvs0ItKYxPHC8VlgHD9Co2Ck7pxkZW9NXDy1tnYsMuOupGQ4Vucg8Gsu0DkXfzHP_i0TOOMjPymoQ9gzLT2nyn5sjhYKz0jFUEau-JlhbzbPgwwbFsYT9M9YOJXqkV35XyeLbRM2wiNNvfzmAy98ppDyP7guZ5poiTtNLrXak6VWG21RC9N48X3uiH66sIaz2LAXOFZatYgF73qXfXryAZYCCpVgrPkwK2CKeYQqj6NxZINkuVIEvpqgjnrmr7aOv8db9XTjwNX_rtnf_0j2o_izH9CdnFewwhiq-tCdU1aXNMEgpX-DurREXzUpU7VDFDkYw-AdXGb8op2updSXuy8rMCECkP-3dQjshfSZAUIZpu85_UzdYy64rlVHVXVCGtBIF6LZQf7JnkhTr8q3U90mj8JMUui8XYJasbk2Bz8CImCnmWCVTLqsmKc0tedWUjg-Vpkou_n8wJQbCH3FYoXATaBq-qicG3nkXeKbUmqZIWf7a8zRY0jbgcg78xtao0wwe7rfOTvaT4CjUkVCRkZ7O7x6_-BluqmjRKbFmQl8sB573vXIUXDrP169f7JN61Axqh7pfvAGdnILL4TN7ggQknWptlDncDzaEuEWGbbGVHBHm0P7v9TZCZ5B_vp1unqWehI3DGFESIv2SfWT5uJ4GW9I0rIpXaN7EeeAH9r1Sw5A4ihykIODjXEkQ=w860-h722-no?authuser=0"
                 }


            ); 
        }
    }
}
