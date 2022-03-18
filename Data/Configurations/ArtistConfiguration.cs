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
    public class ArtistConfiguration: IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.HasData(
                new Artist { 
                    Id = 1, Name="Pablo Picasso", 
                    LocationId=1, 
                    Email="picasso-pablo@xxx.com", 
                    ImgSrc="https://lh3.googleusercontent.com/TmD9WKyVaYAeahGuyOu4Dri9G6bPGBCX1cECtvv1Re9Wwkq-I9dFravaTqvqowg0XFQ6o2gFoZBRMfGbqmiD9HUAajcSnw1r1ZPuB86roSZ-bJUzJIe7he3S8fonHXrlqgBHG1dT-B75hYxouqAO0OQ8K8rpSAtU4_0aR31nMvilf5-OYPQAWYdk0HQ7prFez5BJAQqQfQ_2OETZZTlnSrl69178R1hnx4h5F0izDxCq9-BXneYjz0Epa6fU1b7FcuZEvUQgmXzlm3mfywn6O2DfsFijw4aQZ0gzc4JXO5dfx7lKA-ncb69MxL7-hHOOaAMosYvnGhU6XCJAIgxT_XkzRJRQ19yP1t4UKF5fvkD76XMPF6Qng7LSnzFGEjyBF5LVQG5OmJAB3Nqweq8J-ac-GD0N-3WKFn9ofZazUNdqbUe7cDzuRaagsY0UipeF8yNh7jVLZdgMOxn5UaRTQqTjfZ43Y9bJfxTZJFDxJT3vJ-0q3_LhHBze63dwoqupZTMttcVpdmU695V5Tm_JsQfuTBtfyOANIByZ_fLd-43FPvvMBPDlKKVh5mBgF1xz8L1-MO2nETJbnDNg8xcw5nEY4Idc7Q6EXOXfkTpLcBTHKcpHgbiruQGuRUNLJe0g_kOeQr7OR-lokrI_aoTDqNBQjnZrms7WZ2RGI0WWexdLeF_280iVN5B735OnhfRVuiVDPJ2qtt3M_DqiI0yrlatNzO9FkR2hV8eK5JP6WbvF9LllkXiPMwmifvYw6GsoJAtbT6Ah6zNsi0aY7Cm02cizTjNo3RnuQVi_=w752-h830-no?authuser=0", 
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed posuere nisl tristique purus volutpat sagittis. Cras suscipit placerat varius. Aenean fermentum metus ut iaculis ultrices. Nullam semper sollicitudin faucibus. Nam vel bibendum justo. Cras mollis ex odio, at iaculis nunc iaculis eget. Nullam volutpat bibendum tincidunt. Vestibulum aliquam risus quis hendrerit tempor. Suspendisse ut ex in arcu convallis gravida. In venenatis feugiat posuere. Duis ac aliquam odio. Vestibulum sit amet volutpat erat, in elementum tortor. Phasellus malesuada ipsum id velit viverra elementum. Nulla eleifend sem sed nunc facilisis venenatis. Cras pellentesque quam sit amet urna convallis scelerisque." },
                
                new Artist
                {
                    Id = 2,
                    Name = "Jerzy Panek",
                    LocationId = 2,
                    Email = "panek-jerzy@xxx.com",
                    ImgSrc = "https://lh3.googleusercontent.com/ccL6CWavQz5f-p7P2n2Jxv5EUiGvKxDFoU5pAlqhYJQ-yG8gv1sFq3zzECP-_QOBDuEgLrlfKA6ZFs1ezDy7oWDHv7gt8cXkGBOJDJJ5gzNvvU4LqmLHXPFxzEPTYmKo6yv8vaJAJdukr7CQ7MGkxZ0QFcVntEKoyz8rzQlqd_Smh6sUFgwFolSc2_Sz3Kr5wShkezcVupRQxo40FZjWixFIs3-Jk5-GsARy_nhVqmCYnws1CMdD1wEUzztE-kI2LDjxRuKAfo0WorzxUFZXyrnGKklmbawpzgchwTlaD2UPKO04dzSe4kt8iP0nWCNLgdFEEvm4g4RfcO8iWhbE-liTek7aBA1JHXamElTFNL5X20BXkFHRQjH9w55AdIGJ4r0bsSLU-isEeQoyLgn4Oz4V6_cpJjfnLAerBbjxDotjiwvhzrUAhrkha1vqdWJK94vekotQDFlWOIGLqliPvB7vPIcZT065jNi1oxZ_mXnxqr1yjtsz438peZelAA7dlAe7YVWUHYvqIR6Z6kPTMfxL5r1lBATslsAgVGfB3oyvVC0ZUv659yWF61mY8CPzJa3PKOtowIGPJwJAGVQQR_G_K5iz3PFbhRlgL-1z6vT2AEoN_YHy8L2FxKGOqyxWour4xau4UL21wvBY1NBEX4iGAfBKTytSacDZng2NH5Y3vtQAwA_-Ii4X7auzfIPrl7fRE5f8-ako2S6qieT87JmIBJmTDGMFzPwJJR-_DBYsXSHSiY2eqkPLhquiNg2QyDz5lB3tuqdJfgBPUjekssjY9pasFPBvB6TP=w690-h388-no?authuser=0",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed posuere nisl tristique purus volutpat sagittis. Cras suscipit placerat varius. Aenean fermentum metus ut iaculis ultrices. Nullam semper sollicitudin faucibus. Nam vel bibendum justo. Cras mollis ex odio, at iaculis nunc iaculis eget. Nullam volutpat bibendum tincidunt. Vestibulum aliquam risus quis hendrerit tempor. Suspendisse ut ex in arcu convallis gravida. In venenatis feugiat posuere. Duis ac aliquam odio. Vestibulum sit amet volutpat erat, in elementum tortor. Phasellus malesuada ipsum id velit viverra elementum. Nulla eleifend sem sed nunc facilisis venenatis. Cras pellentesque quam sit amet urna convallis scelerisque."
                },

                new Artist
                {
                    Id = 3,
                    Name = "Zdzisław Beksiński",
                    LocationId = 3,
                    Email = "beksinski-zdzislaw@xxx.com",
                    ImgSrc = "https://lh3.googleusercontent.com/jJlkVuK17yo7d276rsJXENi73l1TGhPyfJaGbf1Ndk83kbI5gZbMfPIlnnmR1fjVTmU5MEJQ0smqg1LJt5VLFPH3NVLieeQkpjrtdIKmPKNYzyucf24puAzAVIQZfbNzEk1yvoBV7L3VDWhsxXb65lxYa449RT3rkghD8d54OJARr4kYLeGjQu2TvLj85-BCq_LR8hn3Uk1v_gHNWFj_PgGfiG6Jq3IapONqroJFO4ng-XSOLj4EEIMzaan3vNaHhn8hBLbc8Q6Tkkvx6Olt9FJNbVebahI5bU7Z9SP-DznGUiFYV9Gim4TO4HCf2pyPVzxIQ7spEtGl96vanwL_RaRul3lvRJHsT68zv_ou2H8bLZGZPifdXRNBnfR7BmLJOnV8vL9Hu-efx9VMLTl05O3mekQ3eNfeOz-WDAtMDSinYnLkjmq5SBjesXFMj6PZFg41qGsfX6Bfi2gbwuMJBVXDkQsIyZoU7egfRJw96ziBrp9_MED0m1PD2eqEqbEoTXMFLnmnaJiV8lKfDKp9RjNP6X1A-htynZEutJDHnLH9EZUbD5z1mpx6we5NxLISoqNsyOA7fVgLWH11s39DK3Ru0fLsJOs_Lerkb0qB257HYDzcmDa7zzXmfWQy5485U1K2quLFdiPMtKP1-q_fPqDYbkhRtMuEjRPa-b7TuZhRP_ebJdmoMBRoFrRYvFzeiOhkfCJAbDUl5HRPKEpcV0npnZwI8emiFj3xAlvSU-hmi1vgZ63UDIF9_mKNF0pEx1RrS7Qs92b07LzvsirzWtvw3KB1VSKTSBJP=w819-h649-no?authuser=0",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed posuere nisl tristique purus volutpat sagittis. Cras suscipit placerat varius. Aenean fermentum metus ut iaculis ultrices. Nullam semper sollicitudin faucibus. Nam vel bibendum justo. Cras mollis ex odio, at iaculis nunc iaculis eget. Nullam volutpat bibendum tincidunt. Vestibulum aliquam risus quis hendrerit tempor. Suspendisse ut ex in arcu convallis gravida. In venenatis feugiat posuere. Duis ac aliquam odio. Vestibulum sit amet volutpat erat, in elementum tortor. Phasellus malesuada ipsum id velit viverra elementum. Nulla eleifend sem sed nunc facilisis venenatis. Cras pellentesque quam sit amet urna convallis scelerisque."
                }


            );
        }
    }
}
