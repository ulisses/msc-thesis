UNAME := $(shell uname -s)
REL=thesis_proposal
PDF=$(REL).pdf
TEX=$(REL).tex

all:$(PDF)

# Compile the PDF file
$(PDF):$(TEX)
ifeq ($(UNAME),Darwin)
	latexmk -e '$$pdflatex=q/pdflatex --shell-escape -synctex=1 %T/' -pdf $(TEX)
endif
ifeq ($(UNAME),Linux)
	latexmk -pdf $(TEX)
endif

# open PDF file
open:
	make $(PDF)
ifeq ($(UNAME),Darwin)
	open $(PDF)
endif
ifeq ($(UNAME),Linux)
	xpdf $(PDF)
endif

# Clean rules
clean:
	@echo "Cleaning the shop"
	@find . -maxdepth 1 \( \! -iname README* \! -iname .gitignore \! -iname "*.bst" \! -iname "*.bib" \! -iname "*.tex" -type f \! -iname "makefile" \! -iname "*.sty" \! -iname "*.cls" \) -exec rm -f '{}' \;
	@find . \( -name *~ -or -name *.*~ \) -exec rm -f '{}' \;
	@rm -f icst12-dot2tex-*.tex

