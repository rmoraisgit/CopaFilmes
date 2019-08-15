using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CopaFilmes.Domain.Models
{
    public class Filme : AbstractValidator<Filme>
    {
        public Filme(string id, string titulo, int ano, double nota)
        {
            Id = id;
            Titulo = titulo;
            Ano = ano;
            Nota = nota;
        }

        public string Id { get; private set; }
        public string Titulo { get; private set; }
        public int Ano { get; private set; }
        public double Nota { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        public bool EhValido()
        {
            Validar();
            return ValidationResult.IsValid;
        }

        private void Validar()
        {
            ValidarTitulo();
            ValidarAno();
            ValidarNota();

            ValidationResult = Validate(this);
        }

        #region Validações
        private void ValidarTitulo()
        {
            RuleFor(f => f.Titulo)
                .NotEmpty().WithMessage("O titulo do filme precisa ser fornecido")
                .Length(1, 150).WithMessage("O titulo do filme precisa ter entre 1 e 150 caracteres");
        }
        private void ValidarAno()
        {
            RuleFor(f => f.Nota)
                .NotEmpty().WithMessage("O ano de lançamento do filme precisa ser fornecido");
        }

        private void ValidarNota()
        {
            RuleFor(f => f.Nota)
                .NotEmpty().WithMessage("A nota do filme precisa ser fornecida")
                .ExclusiveBetween(1, 10).WithMessage("A nota do filme precisa estar entre 0 e 10");
        }

        #endregion
    }
}
