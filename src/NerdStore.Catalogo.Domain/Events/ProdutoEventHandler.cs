﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain.Events
{
    class ProdutoEventHandler : INotificationHandler<ProdutoAbaixoEstoqueEvent>
    {

        private readonly IProdutoRepository _produtoRepository;
        public async Task Handle(ProdutoAbaixoEstoqueEvent mensagem, CancellationToken cancellationToken)
        {
            var produto = await _produtoRepository.ObterPorId(mensagem.AggregateId);

            //Enviar um e-mail para aquisição de produtos
        }
    }
}
