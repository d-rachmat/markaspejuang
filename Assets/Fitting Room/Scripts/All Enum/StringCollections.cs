public static class StringCollections
{

    //String menu
    public const string confirm_clicked = "confirm@click";
    public const string environment_clicked = "environment@click";
    public const string clothes_clicked = "clothes@click";
    public const string gallery_clicked = "gallery@click";

    //String change background
    public const string beach_clicked = "beach@click";
    public const string garden_clicked = "garden@click";
    public const string kidroom_clicked = "kidroom@click";
    public const string livingroom_clicked = "livingroom@click";
    public const string removebackground_clicked = "removebackground@click";

    //String take photo
    public const string takephoto_clicked = "takephoto@click";
    public const string restartphoto_clicked = "restartphoto@click";

    //String clothes
    public const string clothes1_clicked = "clothes1@click";
    public const string clothes2_clicked = "clothes2@click";
    public const string clothes3_clicked = "clothes3@click";

    #region Kids Room
    public const string captain_america_clicked = "Captain America@click";
    public const string mr_incredible_clicked = "Mr.Incredible@click";
    public const string wonder_girl_clicked = "Wonder Girl@click";
    public const string mrs_incredible_clicked = "Ms. Incredible@click";

    public const string incredible_boy_clicked = "Incredible Boy@click";
    public const string incredible_girl_clicked = "Incredible Girl@click";
    public const string super_boy_clicked = "Super Boy@click";
    public const string super_girl_clicked = "Super Girl@click";

    #endregion

    #region Beach
    public const string father_wetsuit_1_clicked = "Father_wetsuit_1@click";
    public const string father_wetsuit_2_clicked = "Father_wetsuit_2@click";

    public const string mom_wetsuit_1_clicked = "Mother_wetsuit_1@click";
    public const string mom_wetsuit_2_clicked = "Mother_wetsuit_2@click";

    public const string son_wetsuit_1_clicked = "Son_wetsuit_1@click";
    public const string son_wetsuit_2_clicked = "Son_wetsuit_2@click";

    public const string daughter_wetsuit_1_clicked = "Daughter_wetsuit_1@click";
    public const string daughter_wetsuit_2_clicked = "Daughter_wetsuit_2@click";
    #endregion

    #region Garden
    public const string father_shirt_1_clicked = "Father_shirt_1@click";
    public const string father_shirt_2_clicked = "Father_shirt_2@click";

    public const string mother_cloth_1_clicked = "Mother_Cloth_1@click";
    public const string mother_cloth_2_clicked = "Mother_Cloth_2@click";

    public const string Son_Shirt_1_clicked = "Son_Shirt_1@click";
    public const string Son_Shirt_2_clicked = "Son_Shirt_2@click";

    public const string daughter_dress_1_clicked = "Daughter_Dress_1@click";
    public const string daughter_dress_2_clicked = "Daughter_Dress_2@click";

    #endregion

    #region Living Room
    public const string Father_Batik_1_clicked = "Father_Batik_1@click";
    public const string Father_Batik_2_clicked = "Father_Batik_2@click";

    public const string Mother_Batik_1_clicked = "Mother_Batik_1@click";
    public const string Mother_Batik_2_clicked = "Mother_Batik_2@click";

    public const string Son_Batik_1_clicked = "Son_Batik_1@click";
    public const string Son_Batik_2_clicked = "Son_Batik_2@click";

    public const string Daughter_Batik_1_clicked = "Daughter_Batik_1@click";
    public const string Daughter_Batik_2_clicked = "Daughter_Batik_2@click";


    #endregion


    public const string removeclothes_clicked = "removeclothes@click";

    //String active clothes
    public const string dadclothes_clicked = "dadclothes@click";
    public const string momclothes_clicked = "momclothes@click";
    public const string sonclothes_clicked = "sonclothes@click";
    public const string daughterclothes_clicked = "daughterclothes@click";

    //For resize clothes

    public const string plus_clicked = "plus@click";
    public const string minus_clicked = "minus@click";

    //String others
    public const string changeuser_clicked = "changeuser@click";


}

enum Status
{
    idle, environment_active, clothes_active, takephoto_active
}

enum Environment
{
    empty = -1,
    beach = 0,
    garden = 1,
    kid_room = 2,
    living_room = 3
}

enum Family
{
    dad, mom, son, daughter
}


