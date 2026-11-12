CREATE DATABASE IF NOT EXISTS romeus_app CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;
USE romeus_app;

-- L'application crée automatiquement ces tables au premier démarrage.
-- Ce fichier permet aussi de préparer la base manuellement.
CREATE TABLE IF NOT EXISTS users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  username VARCHAR(80) NOT NULL UNIQUE,
  password_hash VARCHAR(300) NOT NULL,
  secret_code_hash VARCHAR(300) NOT NULL,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP
);
CREATE TABLE IF NOT EXISTS secrets (
  id INT AUTO_INCREMENT PRIMARY KEY, user_id INT NOT NULL, title VARCHAR(150) NOT NULL,
  username VARCHAR(150), password_value TEXT NOT NULL, notes TEXT,
  created_at DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS activities (
  id INT AUTO_INCREMENT PRIMARY KEY, user_id INT NOT NULL, activity_date DATE NOT NULL,
  title VARCHAR(150) NOT NULL, description TEXT, status VARCHAR(30) NOT NULL DEFAULT 'À faire',
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
);
CREATE TABLE IF NOT EXISTS contacts (
  id INT AUTO_INCREMENT PRIMARY KEY, user_id INT NOT NULL, first_name VARCHAR(80) NOT NULL,
  last_name VARCHAR(80) NOT NULL, phone VARCHAR(50), email VARCHAR(150), notes TEXT,
  FOREIGN KEY (user_id) REFERENCES users(id) ON DELETE CASCADE
);
