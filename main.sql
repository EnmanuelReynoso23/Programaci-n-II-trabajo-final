--
-- PostgreSQL database dump
--

-- Dumped from database version 17.5
-- Dumped by pg_dump version 17.5

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET transaction_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: database; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA database;


ALTER SCHEMA database OWNER TO postgres;

--
-- Name: docs; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA docs;


ALTER SCHEMA docs OWNER TO postgres;

--
-- Name: queries; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA queries;


ALTER SCHEMA queries OWNER TO postgres;

--
-- Name: stored_procedures; Type: SCHEMA; Schema: -; Owner: postgres
--

CREATE SCHEMA stored_procedures;


ALTER SCHEMA stored_procedures OWNER TO postgres;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- Name: Productos; Type: TABLE; Schema: database; Owner: postgres
--

CREATE TABLE database."Productos" (
);


ALTER TABLE database."Productos" OWNER TO postgres;

--
-- Name: TABLE "Productos"; Type: COMMENT; Schema: database; Owner: postgres
--

COMMENT ON TABLE database."Productos";


--
-- PostgreSQL database dump complete
--

