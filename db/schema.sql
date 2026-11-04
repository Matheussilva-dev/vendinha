-- Script de criação do banco da Vendinha (PostgreSQL)
-- 1) Crie o banco:   CREATE DATABASE vendinha;
-- 2) Conecte nele (DBeaver) e execute este script.

CREATE TABLE IF NOT EXISTS clientes (
    id               SERIAL PRIMARY KEY,
    nome             VARCHAR(100) NOT NULL,
    cpf              VARCHAR(11)  NOT NULL UNIQUE,   -- somente dígitos
    data_nascimento  DATE         NOT NULL,
    email            VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS dividas (
    id              SERIAL PRIMARY KEY,
    cliente_id      INTEGER        NOT NULL REFERENCES clientes (id),
    valor           NUMERIC(10, 2) NOT NULL CHECK (valor > 0),
    paga            BOOLEAN        NOT NULL DEFAULT FALSE,
    data_criacao    TIMESTAMP      NOT NULL,
    data_pagamento  TIMESTAMP
);

CREATE INDEX IF NOT EXISTS ix_dividas_cliente_id ON dividas (cliente_id);

-- Regra: um cliente só pode ter uma dívida em aberto
CREATE UNIQUE INDEX IF NOT EXISTS ux_dividas_uma_em_aberto
    ON dividas (cliente_id) WHERE paga = FALSE;
