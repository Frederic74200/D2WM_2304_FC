<?php
require './src/Models/Connexion.php';




class SignClass
{
    private string $lastname_user = "";
    private string  $firstname_user =   "";
    private string  $mail_user =   "";
    private string $pass_user  =   "";
    private int $level_user =   1;
    private  int $avatar =  0;
    private array $image =  [];
    private string   $adresse_virtuelle = "";

    //-----------------------------------------------------------------------------------------
    public function __construct(array $dataUser, array $imgUser = null)
    {
        $this->lastname_user = $dataUser['lastname'];
        $this->firstname_user =   $dataUser['firstname'];
        $this->mail_user =  $dataUser['email'];
        $this->pass_user  =  $dataUser['password'];

        if ($imgUser != null) {
            $this->image =   $imgUser['avatar'];
        }
    }
    //----------------------------------------------------------------------------------

    public function addAvatar(): string
    {

        // Récupération du nom de l'utilisateur
        $username = $this->lastname_user . '_' . $this->firstname_user;
        $nom_fichier = $username . '.jpeg';

        // Stockage de l'image    C:\Users\Fchaput\Documents\gitlocal\D2WM_2304_FC\PHP\Voilier MVC\
        $chemin_physique = './Assets/images';
        $adresse_physique =  $chemin_physique . '/tmp/' . $nom_fichier;
        // $nom_fichier = $username . '.jpeg';
        move_uploaded_file($this->image['tmp_name'],  $adresse_physique);

        // Redimensionnement de l'image
        $image = imagecreatefromjpeg($adresse_physique);
        $largeur_nouvelle = 200;
        $hauteur_nouvelle = 200;
        $image_redimensionnee = imagecreatetruecolor($largeur_nouvelle, $hauteur_nouvelle);
        //   $image = imagecreatefromjpeg($nom_fichier);

        list($width, $height) = getimagesize($adresse_physique);

        imagecopyresampled($image_redimensionnee,    $image, 0, 0, 0, 0, $largeur_nouvelle, $hauteur_nouvelle, $width,  $height);

        imagejpeg($image_redimensionnee, $chemin_physique . '/' . $nom_fichier);


        unlink($adresse_physique);

        // Association de l'adresse virtuelle
        $this->adresse_virtuelle = 'http://localhost/gitphp/Voilier%20MVC//Assets/images/' . $nom_fichier;


        $requete = "INSERT INTO avatars (image_url) VALUES (:image_url);";
        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(":image_url", $this->adresse_virtuelle, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données add avatar ", 1);
        }

        $nb = 0;
        $nb = $state->rowCount();

        return     $nb;
    }
    //----------------------------------------------------------------------------------

    public function getIdAvatar(): int
    {
        $id = 0;

        $requete = "SELECT id FROM avatars WHERE image_url  IN (:image_url)";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(":image_url", $this->adresse_virtuelle, PDO::PARAM_STR);
            $state->execute();
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données get avatar ", 1);
        }

        $nbLigne = $state->rowCount();
        if ($nbLigne > 0) {
            $ligne = $state->fetch();
        }

        $id = $ligne["id"];
        return $id;
    }

    //-----------------------------------------------------------------------------------------------------------------------------------
    public  function addUser(int $idAvatar): int
    {

        $this->avatar = $idAvatar;

        $requete = "INSERT INTO utilisateurs (  lastname_user,  firstname_user, mail_user , pass_user, level_user, avatar   ) 
        VALUES ( :lastname_user    ,  :firstname_user , :mail_user    , :pass_user  , :level_user  ,  :avatar ); ";

        $hash_mdp =  password_hash($this->pass_user, CRYPT_BLOWFISH);


        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            //   $state->bindParam(":mail", $_identifiant, PDO::PARAM_STR);

            $state->bindParam(":lastname_user", $this->lastname_user, PDO::PARAM_STR);
            $state->bindParam(":firstname_user", $this->firstname_user, PDO::PARAM_STR);
            $state->bindParam(":mail_user", $this->mail_user, PDO::PARAM_STR);
            $state->bindParam(":pass_user", $hash_mdp, PDO::PARAM_STR);
            $state->bindParam(":level_user", $this->level_user, PDO::PARAM_INT);
            $state->bindParam(":avatar", $this->avatar, PDO::PARAM_INT);
            $state->execute();
            //  $state->execute([":lastname_user" => $this->lastname_user, ":firstname_user" => $this->firstname_user, ":mail_user" => $this->mail_user, ":pass_user " => $hash_mdp, ":level_user" => $this->level_user, ":avatar" => $this->avatar]);
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données add user ", 1);
        }

        $nb = $state->rowCount();

        return $nb;
    }
}



  /*





        $sth->execute(array(':calories' => $calories, ':colour' => $colour));

INSERT INTO avatars (image_url) VALUES ('')


SELECT id FROM avatars WHERE image_url  IN ('http://localhost/gitphp/Voilier%20MVC//Assets/images/tournesol.jpg')


INSERT INTO utilisateurs (  lastname_user,  firstname_user, mail_user , pass_user, level_user, avatar   ) 
VALUES (     ,   ,    ,   ,    ,                                        ); 


        $loginOk = false;
        $requete = "SELECT * FROM utilisateurs WHERE mail_user =:mail";

        $connect = Connexion::getInstance();

        try {
            $state = $connect->prepare($requete);
            $state->bindParam(":mail", $_identifiant, PDO::PARAM_STR);
            $state->execute([ ":lastname_user"=>$this->latsname_user,  ]);
        } catch (PDOException $e) {
            throw new Exception("Erreur de connexion à la base de données", 1);
        }

        $nbLigne = $state->rowCount();

        if ($nbLigne > 0) {
            $ligne = $state->fetch();

            if (password_verify($_mdp, $ligne["pass_user"])) {
                $loginOk = true;
                echo 'mdp ok';
            } else {
                echo "Mot de passe erroné!";
            }
        } else {
            echo "Identifiant erroné!";
        }

        return $loginOk;



        */