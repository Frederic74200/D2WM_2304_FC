<?php

namespace App\Models;

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
                self::$connection = new \PDO('mysql:host=localhost;dbname=db_cpu;charset=utf8', 'root', '', array(
                    \PDO::ATTR_ERRMODE => \PDO::ERRMODE_EXCEPTION,
                    \PDO::ATTR_CASE => \PDO::CASE_LOWER,
                    \PDO::ATTR_DEFAULT_FETCH_MODE => \PDO::FETCH_OBJ
                ));
            } catch (\PDOException $e) {
                die("Database connection failed: " . $e->getMessage());

                echo "erreur connexion";
            }
        }

        return self::$connection;
    }
}
