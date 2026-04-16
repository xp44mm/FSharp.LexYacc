namespace FSharp.Substance

type StyleBlock<'b> =
    {
        /// 前面的缩进
        prior: int option
        /// 行末最后一个符号为真
        subsequent: bool
        /// 内含的语句块
        block: 'b
    }

    static member just(prior: int option, subsequent: bool, block: 'b) =
        {
            prior = prior
            subsequent = subsequent
            block = block
        }

    /// block是行首第一个单词
    static member first(spaces: int, block: 'b) =
        {
            prior = Some spaces
            subsequent = false
            block = block
        }

    /// block是行尾最后一个单词
    static member last(block: 'b) =
        {
            prior = None
            subsequent = true
            block = block
        }

    /// block既不在行首，也不在行尾
    static member none(block: 'b) =
        {
            prior = None
            subsequent = false
            block = block
        }
