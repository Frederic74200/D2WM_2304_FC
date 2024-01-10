<?php


class Connexion
{

    private static $connection = null;


    private function __construct()
    {
    }


    static public final function getInstance()
    {
        if (is_null(self::$connection)) {

            try {
                self::$connection = new PDO('mysql:host=localhost;dbname=voiliers', 'root', '', array(
                    PDO::ATTR_ERRMODE => PDO::ERRMODE_EXCEPTION,
                    PDO::ATTR_CASE => PDO::CASE_LOWER,
                    PDO::ATTR_DEFAULT_FETCH_MODE => PDO::FETCH_ASSOC,
                    PDO::MYSQL_ATTR_INIT_COMMAND => "SET NAMES utf8"
                ));
            } catch (PDOException $e) {
                die("Database connection failed: " . $e->getMessage());

                echo "erreur connexion";
            }
        }

        return self::$connection;
    }
}
