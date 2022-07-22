﻿using BVS.Models.Entity.CompradorAssociado;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations.Schema;

namespace BVS.Models.Request.Atualizar
{
    public class AtualizarAssociadoRequest
    {
        public Guid CadastroId { get; set; }
        public string? Nome { get; set; }
        public string? CPF { get; set; }
        public string? Fazenda { get; set; }
        public DateTime DataDaParceria { get; set; }
        public Guid? IdComprador { get; set; }
        public Comprador? Comprador { get; set; }
        public AtualizarAssociadoRequest(Guid cadastroId, string? cpf,DateTime dataDaParceria, string? fazenda, Guid idComprador, string? nome)
        {
            CadastroId = cadastroId;
            CPF = cpf;
            DataDaParceria = dataDaParceria;
            Fazenda = fazenda;            
            IdComprador = idComprador;
            Nome = nome;                                  
        }
        public static Associado ConverterParaEntidade(AtualizarAssociadoRequest associadoRequest)
        {
            return new Associado
                (
                associadoRequest.CadastroId,
                associadoRequest.CPF,
                associadoRequest.DataDaParceria,
                associadoRequest.Fazenda,                
                associadoRequest.IdComprador,
                associadoRequest.Nome                
                );
        }
        public AtualizarAssociadoRequest()
        {

        }
    }
}
